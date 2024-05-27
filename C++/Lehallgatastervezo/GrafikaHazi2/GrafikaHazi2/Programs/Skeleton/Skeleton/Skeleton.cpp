//=============================================================================================
// Mintaprogram: Zöld háromszög. Ervenyes 2019. osztol.
//
// A beadott program csak ebben a fajlban lehet, a fajl 1 byte-os ASCII karaktereket tartalmazhat, BOM kihuzando.
// Tilos:
// - mast "beincludolni", illetve mas konyvtarat hasznalni
// - faljmuveleteket vegezni a printf-et kiveve
// - Mashonnan atvett programresszleteket forrasmegjeloles nelkul felhasznalni es
// - felesleges programsorokat a beadott programban hagyni!!!!!!! 
// - felesleges kommenteket a beadott programba irni a forrasmegjelolest kommentjeit kiveve
// ---------------------------------------------------------------------------------------------
// A feladatot ANSI C++ nyelvu forditoprogrammal ellenorizzuk, a Visual Studio-hoz kepesti elteresekrol
// es a leggyakoribb hibakrol (pl. ideiglenes objektumot nem lehet referencia tipusnak ertekul adni)
// a hazibeado portal ad egy osszefoglalot.
// ---------------------------------------------------------------------------------------------
// A feladatmegoldasokban csak olyan OpenGL fuggvenyek hasznalhatok, amelyek az oran a feladatkiadasig elhangzottak 
// A keretben nem szereplo GLUT fuggvenyek tiltottak.
//
// NYILATKOZAT
// ---------------------------------------------------------------------------------------------
// Nev    : Rába Tamás
// Neptun : CRLJQ8
// ---------------------------------------------------------------------------------------------
// ezennel kijelentem, hogy a feladatot magam keszitettem, es ha barmilyen segitseget igenybe vettem vagy
// mas szellemi termeket felhasznaltam, akkor a forrast es az atvett reszt kommentekben egyertelmuen jeloltem.
// A forrasmegjeloles kotelme vonatkozik az eloadas foliakat es a targy oktatoi, illetve a
// grafhazi doktor tanacsait kiveve barmilyen csatornan (szoban, irasban, Interneten, stb.) erkezo minden egyeb
// informaciora (keplet, program, algoritmus, stb.). Kijelentem, hogy a forrasmegjelolessel atvett reszeket is ertem,
// azok helyessegere matematikai bizonyitast tudok adni. Tisztaban vagyok azzal, hogy az atvett reszek nem szamitanak
// a sajat kontribucioba, igy a feladat elfogadasarol a tobbi resz mennyisege es minosege alapjan szuletik dontes.
// Tudomasul veszem, hogy a forrasmegjeloles kotelmenek megsertese eseten a hazifeladatra adhato pontokat
// negativ elojellel szamoljak el es ezzel parhuzamosan eljaras is indul velem szemben.
//=============================================================================================
#include "framework.h"

const char* vertexSource = R"(
	#version 330
    precision highp float;
 
	layout(location = 0) in vec2 cVertexPosition;	// Attrib Array 0
	out vec2 texcoord;
 
	void main() {
		texcoord = (cVertexPosition + vec2(1, 1))/2;							// -1,1 to 0,1
		gl_Position = vec4(cVertexPosition.x, cVertexPosition.y, 0, 1); 		// transform to clipping space
	}
)";


const char* fragmentSource = R"(
	#version 330
    precision highp float;
 
	uniform sampler2D textureUnit;
	in  vec2 texcoord;			// interpolated texture coordinates
	out vec4 fragmentColor;		// output that goes to the raster memory as told by glBindFragDataLocation
 
	void main() {
		fragmentColor = texture(textureUnit, texcoord); 
	}
)";

GPUProgram gpuProgram;
unsigned int vao;

struct Color {

	float r, g, b;

};

struct Material {
	Color szin;
	float shine;
	Color ka, kd, ks;
	Material() {
		kd.r = 0.3;
		kd.g = 0.3;
		kd.b = 0.3;
	}
};

struct Ray {
	vec3 start;
	vec3 dir;
	bool out;
};
struct Hit {
	float t;
	vec3 position;
	vec3 normal;
	Material material;
	Hit() { t = -1; }
};


struct Intersectable {
	Material material;
	virtual Hit intersect(const Ray& ray) = 0;
};

struct BaseSik : Intersectable {
	vec3 p, n;
	Hit intersect(const Ray& ray)
	{
		float x = dot(n, ray.dir);

		Hit hit;
		if (x == 0) {
			hit.t = -1;
			return hit;
		}


		float t = dot(n, (p - ray.start)) / x;


		if (t <= 0) {
			hit.t = -1;
			return hit;
		}

		hit.t = t;
		hit.position = ray.start + ray.dir * hit.t;
		hit.normal = normalize(n);
		hit.material = material;

		return hit;
	}
};

struct Sik : BaseSik
{
	Hit intersect(const Ray& ray)
	{
		Hit hit = BaseSik::intersect(ray);

		if (dot(normalize(hit.position - ray.start), hit.normal) < 0) {
			hit.t = -1;
			return hit;
		}

		if (fabs(n.y) == 1 && (hit.position.x > 5 || hit.position.x < 0 || hit.position.z > 5 || hit.position.z < 0))
			hit.t = -1;

		if (fabs(n.z) == 1 && (hit.position.y > 2.0 || hit.position.y < -0.5 || hit.position.x > 5 || hit.position.x < 0))
			hit.t = -1;

		if (fabs(n.x) == 1 && (hit.position.y > 2.0 || hit.position.y < -0.5 || hit.position.z > 5 || hit.position.z < 0))
			hit.t = -1;

		return hit;
	}
};



struct Triangle : BaseSik {
	float sideLength;
	vec3 r1, r2, r3;
	Hit intersect(const Ray& ray) {
		n = cross(r2 - r1, r3 - r1);
		p = r1;
		Hit hit = BaseSik::intersect(ray);
		if (dot(cross(r2 - r1, hit.position - r1), n) > 0 && dot(cross(r3 - r2, hit.position - r2), n) > 0 && dot(cross(r1 - r3, hit.position - r3), n) > 0) {
			return hit;
		}
		hit.t = -1;
		return hit;
	}
};

struct Sphere : public Intersectable {
	vec3 center;
	float radius;
	Hit intersect(const Ray& ray) {
		Hit hit;
		vec3 dist = ray.start - center;
		float a = dot(ray.dir, ray.dir);
		float b = dot(dist, ray.dir) * 2;
		float c = dot(dist, dist) - radius * radius;
		float discr = b * b - 4 * a * c;
		if (discr < 0) { hit.t = -1; return hit; }
		else discr = sqrtf(discr);
		float t1 = (-b + discr) / 2 / a, t2 = (-b - discr) / 2 / a;
		if (t1 <= 0)
		{
			hit.t = -1;
			return hit;
		}
		hit.t = (t2 > 0) ? t2 : t1;
		hit.position = ray.start + ray.dir * hit.t;
		hit.normal = (hit.position - center) / radius;
		hit.material = material;
		return hit;
	}
};

struct Cone : public Intersectable {
	vec3 p, n;
	float alfa, height;

	Hit intersect(const Ray& ray) {
		Hit hit;
		n = normalize(n - p);
		vec3 x = ray.start - p;
		float a = pow(dot(ray.dir, n), 2) - pow(cos(alfa), 2);
		float b = 2 * (dot(x, n) * dot(ray.dir, n) - dot(x, ray.dir) * pow(cos(alfa), 2));
		float c = pow(dot(n, x), 2) - dot(x, x) * pow(cos(alfa), 2);

		float discr = b * b - 4 * a * c;
		if (discr < 0) {
			hit.t = -1;
			return hit;
		}

		discr = sqrt(discr);

		float t1 = (-b + discr) / 2 / a, t2 = (-b - discr) / 2 / a;
		if (t1 <= 0)
		{
			hit.t = -1;
			return hit;
		}
		hit.t = (t2 > 0) ? t2 : t1;

		vec3 rp = ray.start + ray.dir * hit.t - p;

		float h = dot(rp, n);
		if (h < 0.001 || h > height) {

			hit.t = -1;
			return hit;
		}

		hit.position = ray.start + ray.dir * hit.t;
		hit.normal = normalize(rp * dot(n, rp) / dot(rp, rp) - n);
		hit.material = material;
		return hit;

	}

};

struct Light {
	vec3 pos;
	float in;



	virtual bool isInside(vec3 p) {
		return true;
	}

	virtual Color colorIllumination(vec3 p) {
		Color c;
		c.r = 0;
		c.g = 0;
		c.b = 0;
		return c;
	}

};

struct ColorLight : Light {
	Color color;
	float szog;
	vec3 dir;

	bool isInside(vec3 p) {
		vec3 v = p - pos;
		vec3 _dir = normalize(dir - pos);
		if (cos(szog) < dot(_dir, v) / (length(_dir) * length(v))) {
			return true;
		}
		return false;
	}

	Color colorIllumination(vec3 p) {
		Color c;
		if (!isInside(p)) {
			c.r = 0;
			c.g = 0;
			c.b = 0;
			return c;
		}
		float distanceFromObj = length(p - pos);

		c.r = (color.r * in) / (distanceFromObj * 1);
		c.g = (color.g * in) / (distanceFromObj * 1);
		c.b = (color.b * in) / (distanceFromObj * 1);
		return c;
	}
};

struct Camera {
	vec3 eye;
	vec3 lookat;
	vec3 up, right;
	float xm = 600, ym = 600;
	Ray getRay(int x, int y)
	{

		vec3 dir = lookat - eye;
		float l = length(dir);
		dir = normalize(dir);
		vec3 right = vec3(1, 0, 0);
		up = cross(dir, right);
		up = normalize(up) * l * tanf(45 * M_PI / 180 / 2);
		right = cross(dir, up);
		right = normalize(right) * l * tanf(45 * M_PI / 180 / 2);

		vec3 p = lookat + (2 * (x + 0.5) / xm - 1) * right + (2 * (y + 0.5) / ym - 1) * up;
		Ray r;
		r.start = eye;
		r.dir = normalize(p - eye);
		return r;
	}
};

struct World {
	Camera cam;
	Intersectable* objects[30];
	int object_counter = 0;
	Color kep[600][600];
	Light light;
	ColorLight clightb;
	ColorLight clightg;
	ColorLight clightr;
	Light* lights[10];
	int light_counter;

	vec3 lightBPos = vec3(1, 0.75, 2);
	vec3 lightGPos = vec3(2, 0.75, 2);
	vec3 lightRPos = vec3(0.5, -0.2, 0.5);

	void Build()
	{
		light_counter = 0;
		object_counter = 0;

		cam.eye = vec3(-4, 1, -4);
		cam.lookat = vec3(0, 1, 0);

		light.in = 0.1;
		lights[light_counter++] = &light;

		Cone cb;
		cb.p = lightBPos;
		cb.n = vec3(2, 0, 2);
		cb.height = 0.07;
		cb.alfa = 1.2;
		objects[object_counter++] = &cb;

		clightb.pos = lightBPos + -1 * cb.n * 0.01;
		clightb.dir = vec3(1, 0, 1);
		clightb.szog = 1.2;
		clightb.in = 1;
		clightb.color.r = 0;
		clightb.color.g = 0;
		clightb.color.b = 1;
		lights[light_counter++] = &clightb;

		Cone cg;
		cg.p = lightGPos;
		cg.n = vec3(2, 0, 2);
		cg.height = 0.07;
		cg.alfa = 1.2;
		objects[object_counter++] = &cg;

		clightg.pos = lightGPos + cg.n * 0.01;
		clightg.dir = vec3(2, 0, 2);
		clightg.szog = 1.3;
		clightg.in = 0.8;
		clightg.color.r = 0;
		clightg.color.g = 1;
		clightg.color.b = 0;
		lights[light_counter++] = &clightg;

		Cone cr;
		cr.p = lightRPos;
		cr.n = vec3(2, 10, 2);
		cr.height = 0.07;
		cr.alfa = 1.2;
		objects[object_counter++] = &cr;

		clightr.pos = lightRPos + cb.n * 0.01;
		clightr.dir = vec3(2, 10, 2);
		clightr.szog = 1.2;
		clightr.in = 0.8;
		clightr.color.r = 1;
		clightr.color.g = 0;
		clightr.color.b = 0;
		lights[light_counter++] = &clightr;

		Sik padlo;
		padlo.p = vec3(0, -0.5, 0);

		padlo.n = vec3(0, -1, 0);
		padlo.material.szin.r = 1;
		padlo.material.szin.g = 1;
		padlo.material.szin.b = 1;

		padlo.material.ka.r = 0;
		padlo.material.ka.g = 0;
		padlo.material.ka.b = 0;

		padlo.material.kd.r = 0.2;
		padlo.material.kd.g = 0.2;
		padlo.material.kd.b = 0.2;

		padlo.material.ks.r = 0;
		padlo.material.ks.g = 0;
		padlo.material.ks.b = 0;
		padlo.material.shine = 0;
		objects[object_counter++] = &padlo;

		Sik plafon;
		plafon.p = vec3(0, 2, 0);

		plafon.n = vec3(0, 1, 0);
		plafon.material.szin.r = 1;
		plafon.material.szin.g = 1;
		plafon.material.szin.b = 1;

		plafon.material.ka.r = 0.5;
		plafon.material.ka.g = 0.5;
		plafon.material.ka.b = 0.5;

		plafon.material.kd.r = 0.2;
		plafon.material.kd.g = 0.2;
		plafon.material.kd.b = 0.2;

		plafon.material.ks.r = 0;
		plafon.material.ks.g = 0;
		plafon.material.ks.b = 0;
		plafon.material.shine = 1;
		objects[object_counter++] = &plafon;

		Sik falHatso;

		falHatso.p = vec3(-5, 0, 5);
		falHatso.n = vec3(0, 0, 1);
		falHatso.material.szin.r = 1;
		falHatso.material.szin.g = 1;
		falHatso.material.szin.b = 1;

		falHatso.material.ka.r = 0.5;
		falHatso.material.ka.g = 0.5;
		falHatso.material.ka.b = 0.5;

		falHatso.material.kd.r = 0.2;
		falHatso.material.kd.g = 0.2;
		falHatso.material.kd.b = 0.2;

		falHatso.material.ks.r = 0;
		falHatso.material.ks.g = 0;
		falHatso.material.ks.b = 0;
		falHatso.material.shine = 1;
		objects[object_counter++] = &falHatso;

		Sik falOldalso;
		falOldalso.p = vec3(5, 0, 5);
		falOldalso.n = vec3(1, 0, 0);
		falOldalso.material.szin.r = 1;
		falOldalso.material.szin.g = 1;
		falOldalso.material.szin.b = 1;

		falOldalso.material.ka.r = 0.5;
		falOldalso.material.ka.g = 0.5;
		falOldalso.material.ka.b = 0.5;

		falOldalso.material.kd.r = 0.2;
		falOldalso.material.kd.g = 0.2;
		falOldalso.material.kd.b = 0.2;

		falOldalso.material.ks.r = 0;
		falOldalso.material.ks.g = 0;
		falOldalso.material.ks.b = 0;
		falOldalso.material.shine = 0;
		objects[object_counter++] = &falOldalso;

		Sik falElsoBal;
		falElsoBal.p = vec3(0, 0, 0);
		falElsoBal.n = vec3(0, 0, -1);
		falElsoBal.material.kd.r = 0.2;
		falElsoBal.material.kd.g = 0.2;
		falElsoBal.material.kd.b = 0.2;

		falElsoBal.material.ks.r = 0;
		falElsoBal.material.ks.g = 0;
		falElsoBal.material.ks.b = 0;

		falElsoBal.material.ka.r = 0.5;
		falElsoBal.material.ka.g = 0.5;
		falElsoBal.material.ka.b = 0.5;
		objects[object_counter++] = &falElsoBal;

		Sik falElsoJobb;
		falElsoJobb.p = vec3(0, 0, 0);
		falElsoJobb.n = vec3(-1, 0, 0);
		falElsoJobb.material.kd.r = 0.5;
		falElsoJobb.material.kd.g = 0.5;
		falElsoJobb.material.kd.b = 0.5;

		falElsoJobb.material.ks.r = 0;
		falElsoJobb.material.ks.g = 0;
		falElsoJobb.material.ks.b = 0;

		falElsoJobb.material.ka.r = 0.5;
		falElsoJobb.material.ka.g = 0.5;
		falElsoJobb.material.ka.b = 0.5;
		objects[object_counter++] = &falElsoJobb;

		Sphere g;
		g.center = vec3(0, 0, 0);
		g.radius = 0.5;
		g.material.szin.r = 1;
		g.material.szin.g = 1;
		g.material.szin.b = 1;

		g.material.ka.r = 0;
		g.material.ka.g = 0;
		g.material.ka.b = 0;

		g.material.kd.r = 0.05;
		g.material.kd.g = 0.05;
		g.material.kd.b = 0.05;

		g.material.ks.r = 0;
		g.material.ks.g = 0;
		g.material.ks.b = 0;
		g.material.shine = 1;

		vec3 tetraederEltolas = vec3(2, 0, 3);
		Triangle t1;
		t1.r1 = vec3(0, 0.5, 0) + tetraederEltolas;
		t1.r2 = vec3(0.5, 0, 0) + tetraederEltolas;
		t1.r3 = vec3(0, 0, 0.5) + tetraederEltolas;


		objects[object_counter++] = &t1;

		Triangle t2;
		t2.r1 = vec3(0, 0.5, 0) + tetraederEltolas;
		t2.r2 = vec3(0, 0, 0) + tetraederEltolas;
		t2.r3 = vec3(0.5, 0, 0) + tetraederEltolas;


		objects[object_counter++] = &t2;

		Triangle t3;
		t3.r1 = vec3(0, 0.5, 0) + tetraederEltolas;
		t3.r2 = vec3(0, 0, 0) + tetraederEltolas;
		t3.r3 = vec3(0, 0, 0.5) + tetraederEltolas;


		objects[object_counter++] = &t3;

		Triangle t4;
		t4.r1 = vec3(0, 0, 0) + tetraederEltolas;
		t4.r2 = vec3(0.5, 0, 0) + tetraederEltolas;
		t4.r3 = vec3(0, 0, 0.5) + tetraederEltolas;


		objects[object_counter++] = &t4;



		Triangle o1;
		vec3 eltolas = vec3(1.5, 0, 0.5);
		o1.r1 = vec3(0.25, 0.5, 0.25) + eltolas;
		o1.r2 = vec3(-0.5, 0, 0) + eltolas;
		o1.r3 = vec3(0.5, 0, 0) + eltolas;

		objects[object_counter++] = &o1;

		Triangle o2;
		o2.r1 = vec3(0.25, 0.5, 0.25) + eltolas;
		o2.r2 = vec3(0.5, 0, 0) + eltolas;
		o2.r3 = vec3(0.5, 0, 0.5) + eltolas;

		objects[object_counter++] = &o2;

		Triangle o3;
		o3.r1 = vec3(0.25, 0.5, 0.25) + eltolas;
		o3.r2 = vec3(-0.5, 0, 0) + eltolas;
		o3.r3 = vec3(-0.5, 0, 0.5) + eltolas;

		objects[object_counter++] = &o3;

		Triangle o4;
		o4.r1 = vec3(0.25, 0.5, 0.25) + eltolas;
		o4.r2 = vec3(-0.5, 0, 0.5) + eltolas;
		o4.r3 = vec3(0.5, 0, 0.5) + eltolas;

		objects[object_counter++] = &o4;

		Triangle o5;
		o5.r1 = vec3(0.25, -0.5, 0.25) + eltolas;
		o5.r2 = vec3(-0.5, 0, 0) + eltolas;
		o5.r3 = vec3(0.5, 0, 0) + eltolas;

		objects[object_counter++] = &o5;

		Triangle o6;
		o6.r1 = vec3(0.25, -0.5, 0.25) + eltolas;
		o6.r2 = vec3(0.5, 0, 0) + eltolas;
		o6.r3 = vec3(0.5, 0, 0.5) + eltolas;

		objects[object_counter++] = &o6;

		Triangle o7;
		o7.r1 = vec3(0.25, -0.5, 0.25) + eltolas;
		o7.r2 = vec3(-0.5, 0, 0) + eltolas;
		o7.r3 = vec3(-0.5, 0, 0.5) + eltolas;

		objects[object_counter++] = &o7;

		Triangle o8;
		o8.r1 = vec3(0.25, -0.5, 0.25) + eltolas;
		o8.r2 = vec3(-0.5, 0, 0.5) + eltolas;
		o8.r3 = vec3(0.5, 0, 0.5) + eltolas;

		objects[object_counter++] = &o8;

		Render();
	}
	void Render() {
		for (int i = 0; i < 600; i++) {
			for (int j = 0; j < 600; j++) {
				Ray r = cam.getRay(i, j);
				kep[i][j] = trace(r);
			}
		}

	}
	Color trace(Ray ray) {
		Hit hit = firstIntersect(ray);
		Color c;
		c.r = 0;
		c.g = 0;
		c.b = 0;
		if (hit.t < 0) {

			c.r = 0;
			c.g = 0;
			c.b = 0;
			return c;
		}


		Color outRad;

		outRad.r = hit.material.kd.r * M_PI * 0.25;
		outRad.g = hit.material.kd.g * M_PI * 0.25;
		outRad.b = hit.material.kd.b * M_PI * 0.25;



		for (int i = 1; i < light_counter; i++) {

			Light* _light = lights[i];
			Ray shadowRay;
			shadowRay.start = hit.position + (hit.normal * 0.01);

			shadowRay.dir = normalize(_light->pos - shadowRay.start);
			if (_light->isInside(hit.position)) {
				Hit shadowHit = firstIntersect(shadowRay);

				vec3 Ll = _light->pos - hit.position;

				vec3 Hl = (_light->pos - hit.position) + (cam.eye - hit.position);

				if (shadowHit.t < 0 || shadowHit.t > length(Ll)) {


					vec3 v = normalize(cam.eye - hit.position);
					vec3 n = hit.normal;

					outRad.r += 0.2 * (1 + dot(n, v));
					outRad.g += 0.2 * (1 + dot(n, v));
					outRad.b += 0.2 * (1 + dot(n, v));


					Color c = _light->colorIllumination(hit.position);
					outRad.r += c.r;
					outRad.g += c.g;
					outRad.b += c.b;

				}
			}
		}



		return outRad;

	}

	Hit firstIntersect(Ray ray) {
		Hit bestHit;
		for (int i = 0; i < object_counter; i++) {
			Hit hit = objects[i]->intersect(ray);
			if (hit.t > 0 && (bestHit.t < 0 || hit.t < bestHit.t))
				bestHit = hit;
		}
		if (dot(ray.dir, bestHit.normal) > 0)
			bestHit.normal = bestHit.normal * (-1);
		return bestHit;
	}
};

class FullScreenTexturedQuad {
	unsigned int vao;
	Texture texture;
public:
	FullScreenTexturedQuad(int windowWidth, int windowHeight, std::vector<vec4>& image)
		: texture(windowWidth, windowHeight, image)
	{
		glGenVertexArrays(1, &vao);
		glBindVertexArray(vao);

		unsigned int vbo;
		glGenBuffers(1, &vbo);


		glBindBuffer(GL_ARRAY_BUFFER, vbo);
		float vertexCoords[] = { -1, -1,  1, -1,  1, 1,  -1, 1 };
		glBufferData(GL_ARRAY_BUFFER, sizeof(vertexCoords), vertexCoords, GL_STATIC_DRAW);
		glEnableVertexAttribArray(0);
		glVertexAttribPointer(0, 2, GL_FLOAT, GL_FALSE, 0, NULL);
	}

	void Draw() {
		glBindVertexArray(vao);
		gpuProgram.setUniform(texture, "textureUnit");
		glDrawArrays(GL_TRIANGLE_FAN, 0, 4);
	}
};

FullScreenTexturedQuad* fullScreenTexturedQuad;

World* w;

std::vector<vec4> img(windowWidth* windowHeight);



void onInitialization() {
	glViewport(0, 0, windowWidth, windowHeight);
	w = new World();
	w->Build();

	for (int i = 0; i < windowWidth; i++) {
		for (int j = 0; j < windowHeight; j++) {
			img[i * windowWidth + j] = vec4(w->kep[j][i].r, w->kep[j][i].g, w->kep[j][i].b, 1);
		}
	}
	fullScreenTexturedQuad = new FullScreenTexturedQuad(windowWidth, windowHeight, img);


	gpuProgram.create(vertexSource, fragmentSource, "fragmentColor");

}


void onDisplay() {

	fullScreenTexturedQuad->Draw();
	glutSwapBuffers();
}


void onKeyboard(unsigned char key, int pX, int pY) {
	if (key == 'd') glutPostRedisplay();
}


void onKeyboardUp(unsigned char key, int pX, int pY) {
}


void onMouseMotion(int pX, int pY) {
	float cX = 2.0f * pX / windowWidth - 1;
	float cY = 1.0f - 2.0f * pY / windowHeight;
}


void onMouse(int button, int state, int pX, int pY) {
	float cX = -1 * (2.0f * pX / windowWidth - 1);
	float cY = 1.0f - 2.0f * pY / windowHeight;

	vec3 clickVec = vec3(cX, cY, 0);


	vec3* lightpos = length(clickVec - w->lightBPos) < length(clickVec - w->lightGPos) ? &(w->lightBPos) : &(w->lightGPos);
	lightpos = length(clickVec - *lightpos) < length(clickVec - w->lightRPos) ? lightpos : &(w->lightRPos);


	*lightpos = vec3(cX, cY, lightpos->z);


	w->Build();
	for (int i = 0; i < windowWidth; i++) {
		for (int j = 0; j < windowHeight; j++) {
			img[i * windowWidth + j] = vec4(w->kep[j][i].r, w->kep[j][i].g, w->kep[j][i].b, 1);
		}
	}
	fullScreenTexturedQuad = new FullScreenTexturedQuad(windowWidth, windowHeight, img);
	glutPostRedisplay();
	char* buttonStat;
	switch (state) {
	case GLUT_DOWN: buttonStat = "pressed"; break;
	case GLUT_UP:   buttonStat = "released"; break;
	}

	switch (button) {
	case GLUT_LEFT_BUTTON:   printf("Left button %s at (%3.2f, %3.2f)\n", buttonStat, cX, cY);   break;
	case GLUT_MIDDLE_BUTTON: printf("Middle button %s at (%3.2f, %3.2f)\n", buttonStat, cX, cY); break;
	case GLUT_RIGHT_BUTTON:  printf("Right button %s at (%3.2f, %3.2f)\n", buttonStat, cX, cY);  break;
	}
}


void onIdle() {
	long time = glutGet(GLUT_ELAPSED_TIME);
}