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

const char* const vertexSource = R"(
	#version 330				// Shader 3.3
	precision highp float;		// normal floats, makes no difference on desktop computers
 
	uniform mat4 MVP;			// uniform variable, the Model-View-Projection transformation matrix
	layout(location = 0) in vec2 vp;	// Varying input: vp = vertex position is expected in attrib array 0
	//uniform float radius, up;
	//layout(location = 0) in vec2 vp;
	void main() {
		gl_Position = vec4(vp.x, vp.y, 0, 1) * MVP;		// transform vp from modeling space to normalized device space
	}
)";

const char* const fragmentSource = R"(
	#version 330			// Shader 3.3
	precision highp float;	// normal floats, makes no difference on desktop computers
	
	uniform vec3 color;		// uniform variable, the color of the primitive
	out vec4 outColor;		// computed color of the current pixel
 
	void main() {
		outColor = vec4(color, 1);	// computed color is the color of the primitive
	}
)";


GPUProgram gpuProgram;
unsigned int vao, vbo;
vec3 nezopont = vec3(0.0f, 0.0f, -1.0f);
const int PontokSzama = 100;

#define Color vec3
#define WHITE Color(1,1,1)
#define BLACK Color(0,0,0)
#define RED Color(1,0,0)
#define GREEN Color(0,1,0)
#define BLUE Color(0,0,1)

vec2 BPVetites(vec3 HPont) {
	return vec2(HPont.x / (HPont.z + 1), HPont.y / (HPont.z + 1));
}

vec3 KetPontIranyvektoraH(vec3 p, vec3 q, float t) {
	return ((q - p * cosh(t)) / sinh(t));
}

vec3 MerolegesHV(vec3 a, vec3 b) {
	a.z *= -1;
	b.z *= -1;
	return cross(a, b);
}

vec3 VElforditas(float szog, vec3 mit, vec3 mikorul) {
	return mit * cos(szog) + MerolegesHV(mit, mikorul) * sin(szog);
}

vec3 HiperVektor(float x, float y) {
	return vec3(x, y, pow(x, 2) + pow(y, 2) + 1);
}

float doth(vec3 a, vec3 b) {
	return a.x * b.x + a.y * b.y - a.z * b.z;
}

float TavolsagH(vec3 a) {
	return sqrt(doth(a, a));
}

vec3 NormalizalasH(vec3 x) {
	return x * (1 / TavolsagH(x));
}

vec3 GetIrany(float t, vec3 a, vec3 b) {
	vec3 tmp = a * sinh(t) + NormalizalasH(b) * cosh(t);
	return tmp + doth(tmp, a) * a;
}

float KetPontTavolsaga(vec3 a, vec3 b) {
	return acosh(doth(a, b) * (-1));
}

vec3 EgyenesKovetkezoPontja(vec3 honnan, vec3 irany, float t) {
	vec3 tmp = honnan * cosh(t) + NormalizalasH(irany) * sinh(t);
	return tmp * sqrt(-1 / (pow(tmp.x, 2) + pow(tmp.y, 2) - pow(tmp.z, 2)));
}

class Drawable {
protected:
	unsigned int Vao;
	unsigned int Vbo;
	Color color;
	GLenum mode;
	std::vector<vec2> KirajzolandoPontok;
public:
	Drawable(Color color, GLenum mode) {
		glGenVertexArrays(1, &Vao);
		glGenBuffers(1, &Vbo);
		this->color = color;
		this->mode = mode;
	}
	void draw(uint32_t size) {
		int location = glGetUniformLocation(gpuProgram.getId(), "color");
		glUniform3f(location, color.x, color.y, color.z);

		float MVPtransf[4][4] = { 1, 0, 0, 0,
					  0, 1, 0, 0,
					  0, 0, 1, 0,
					  0, 0, 0, 1 };
		location = glGetUniformLocation(gpuProgram.getId(), "MVP");
		glUniformMatrix4fv(location, 1, GL_TRUE, &MVPtransf[0][0]);

		glBindVertexArray(Vao);
		glDrawArrays(mode, 0, size);
	}

	void bufferData(std::vector<vec2> pontok) {
		glBindVertexArray(Vao);
		glBindBuffer(GL_ARRAY_BUFFER, Vbo);
		glBufferData(GL_ARRAY_BUFFER,
			pontok.size() * sizeof(vec2),
			pontok.data(),
			GL_STATIC_DRAW);

		glEnableVertexAttribArray(0);
		glVertexAttribPointer(0,
			2, GL_FLOAT, GL_FALSE,
			0, NULL);
	}

	~Drawable() {
		glDeleteBuffers(1, &Vbo);
		glDeleteVertexArrays(1, &Vao);
	}
};

class HEgyenes : Drawable {

public:
	std::vector<vec2> Pontok;

	HEgyenes() : Drawable(WHITE, GL_LINE_STRIP) {	}

	void addPont(vec3 HPont) {
		this->Pontok.push_back(BPVetites(HPont));
		this->bufferData(Pontok);
	}

	void draw() {
		Drawable::draw(this->Pontok.size());
	}
};

class HKor : Drawable {
	vec3 getNormal(vec3 p) {
		float y = ((-1 * KozepPont.x + KozepPont.z) / KozepPont.y);
		return vec3(1, y, 1);
	}

public:
	vec3 KezdetiVektor, IranyVektor, KozepPont;
	std::vector<vec2> LevetitettKor;
	float r;

	HKor(vec3 HKozepPont, float r, Color color) : Drawable(color, GL_TRIANGLE_FAN) {
		this->KozepPont = HKozepPont;
		this->KezdetiVektor = getNormal(KozepPont);
		this->IranyVektor = this->KezdetiVektor;
		this->r = r;
	}

	void MoveCircle(vec3 HKozepPont) {
		this->KozepPont = HKozepPont;
		this->KezdetiVektor = getNormal(KozepPont);
		this->IranyVektor = this->KezdetiVektor;
	}

	void HKorKeszitese() {
		this->LevetitettKor.erase(this->LevetitettKor.begin(), this->LevetitettKor.end());
		vec3 aktualisPont = KezdetiVektor;
		for (int i = 0; i < 100; i++) {
			vec3 a = EgyenesKovetkezoPontja(KozepPont, aktualisPont, r);
			aktualisPont = VElforditas(2 * M_PI / 100, aktualisPont, KozepPont);
			this->LevetitettKor.push_back(BPVetites(a));
		}

		vec2 a = this->LevetitettKor[0], b = this->LevetitettKor[50];
		vec2 kozeppont = a + (b - a) / 2.0f;
		this->LevetitettKor.insert(this->LevetitettKor.begin(), kozeppont);
		this->LevetitettKor.push_back(this->LevetitettKor[1]);
		this->bufferData(LevetitettKor);
	}

	void draw() {
		Drawable::draw(this->LevetitettKor.size());

	}
};

class UFOHami {
	vec3 origo, SzajKozepe, nezesiranya;
	vec3 HamiIranyVektora;
	vec3 ForgatasPont = vec3(0.9f, 0.7f, 1.6);
	Color color;
	vec2 hely;
	float szajmeret, szajmeretSzamlalo = 1.0f;
	float sugar;
	vec3 HamiJobbSzemenekKozepPontja, HamiJobbSzemGolyojanakKozepe;
	vec3 HamiBalSzemenekKozepPontja, HamiBalSzemGolyojanakKozepe;

	vec3 TestenForgatas(float Forgatas) {
		vec3 egysegV = NormalizalasH(this->HamiTeste->KezdetiVektor);
		return EgyenesKovetkezoPontja(this->origo, VElforditas(Forgatas, egysegV, this->origo), sugar);
	}

public:
	HEgyenes* egyenes = NULL;
	HKor* HamiTeste = NULL;
	HKor* HamiSzaja = NULL;
	HKor* BalSzeme = NULL;
	HKor* BalSzemGolyoja = NULL;
	HKor* JobbSzeme = NULL;
	HKor* JobbSzemGolyoja = NULL;

	UFOHami(vec2 hely, float sugar, Color color) {
		egyenes = new HEgyenes;
		this->hely = hely;
		this->szajmeret = 0;
		this->sugar = sugar;
		this->color = color;

		this->egyenes = new HEgyenes();
		this->HamiTeste = new HKor(HiperVektor(this->hely.x, this->hely.y), this->sugar, this->color);
		this->HamiSzaja = new HKor(SzajKozepe, 0.05, BLACK);
		this->BalSzeme = new HKor(HamiBalSzemenekKozepPontja, 0.08f, WHITE);
		this->BalSzemGolyoja = new HKor(this->HamiBalSzemGolyojanakKozepe, 0.04f, BLUE);
		this->JobbSzeme = new HKor(HamiJobbSzemenekKozepPontja, 0.08f, WHITE);
		this->JobbSzemGolyoja = new HKor(this->HamiJobbSzemGolyojanakKozepe, 0.04f, BLUE);
		this->HamiIranyVektora = this->HamiTeste->IranyVektor;
	}
	void setNezes(UFOHami* hami)
	{
		this->HamiBalSzemGolyojanakKozepe = EgyenesKovetkezoPontja(this->HamiBalSzemenekKozepPontja, NormalizalasH(KetPontIranyvektoraH(this->HamiTeste->KozepPont, hami->HamiTeste->KozepPont, KetPontTavolsaga(this->HamiTeste->KozepPont, hami->HamiTeste->KozepPont))), 0.3f * this->sugar * 0.5f);
		this->HamiJobbSzemGolyojanakKozepe = EgyenesKovetkezoPontja(this->HamiJobbSzemenekKozepPontja, NormalizalasH(KetPontIranyvektoraH(this->HamiTeste->KozepPont, hami->HamiTeste->KozepPont, KetPontTavolsaga(this->HamiTeste->KozepPont, hami->HamiTeste->KozepPont))), 0.3f * this->sugar * 0.5f);
	}

	void SzajMozgat() {
		this->szajmeret = sin(0.01 * szajmeretSzamlalo++);
		for (int i = 0; i < 2; i++) {
			this->HamiSzaja->r = this->szajmeret * 0.25f * this->sugar;
		}

	}

	void Mozgat(float t, float szog) {
		this->HamiTeste->KozepPont = EgyenesKovetkezoPontja(this->HamiTeste->KozepPont, this->HamiIranyVektora, t);
		vec3 irany = GetIrany(t, this->HamiTeste->KozepPont, this->HamiIranyVektora);
		this->HamiIranyVektora = VElforditas(szog, irany, this->HamiTeste->KozepPont);

		this->HamiTeste->MoveCircle(this->HamiTeste->KozepPont);
		this->HamiTeste->KezdetiVektor = this->HamiIranyVektora;
		this->HamiTeste->HKorKeszitese();
		this->origo = HamiTeste->KozepPont;
		this->egyenes->addPont(this->HamiTeste->KozepPont);

		this->SzajKozepe = TestenForgatas(0);
		this->HamiSzaja->MoveCircle(SzajKozepe);
		this->HamiSzaja->HKorKeszitese();

		this->HamiBalSzemenekKozepPontja = this->TestenForgatas(0.43633);
		this->BalSzeme->MoveCircle(this->HamiBalSzemenekKozepPontja);
		this->BalSzeme->HKorKeszitese();
		this->BalSzemGolyoja->MoveCircle(this->HamiBalSzemGolyojanakKozepe);
		this->BalSzemGolyoja->HKorKeszitese();
		this->HamiJobbSzemenekKozepPontja = this->TestenForgatas(5.84685);
		this->JobbSzeme->MoveCircle(this->HamiJobbSzemenekKozepPontja);
		this->JobbSzeme->HKorKeszitese();
		this->JobbSzemGolyoja->MoveCircle(this->HamiJobbSzemGolyojanakKozepe);
		this->JobbSzemGolyoja->HKorKeszitese();
	}

	void hozzaErt(UFOHami* hami) {
		if (hami->HamiTeste->r >= KetPontTavolsaga(hami->HamiTeste->KozepPont, this->HamiTeste->KozepPont))
			exit(0);
	}

	void draw() {
		this->egyenes->draw();
		this->HamiTeste->draw();
		this->BalSzeme->draw();
		this->BalSzemGolyoja->draw();
		this->JobbSzeme->draw();
		this->JobbSzemGolyoja->draw();
		this->HamiSzaja->draw();
	}
};

UFOHami* ZoldUfo, * PirosUfo;

void onInitialization() {
	glViewport(0, 0, windowWidth, windowHeight);

	glGenVertexArrays(1, &vao);
	glBindVertexArray(vao);


	glGenBuffers(1, &vbo);
	glBindBuffer(GL_ARRAY_BUFFER, vbo);

	std::vector<vec2> Kor;

	for (int i = 0; i < PontokSzama; i++) {
		Kor.push_back(vec2(cosf(i * 2.0f * M_PI / PontokSzama), sinf(i * 2.0f * M_PI / PontokSzama)));
	}

	glBufferData(GL_ARRAY_BUFFER,
		Kor.size() * sizeof(vec2),
		Kor.data(),
		GL_STATIC_DRAW);

	glEnableVertexAttribArray(0);
	glVertexAttribPointer(0,
		2, GL_FLOAT, GL_FALSE,
		0, NULL);

	PirosUfo = new UFOHami(vec2(-0.99f, -0.99f), 0.27f, RED);
	ZoldUfo = new UFOHami(vec2(0.9f, 0.9f), 0.27f, GREEN);

	gpuProgram.create(vertexSource, fragmentSource, "outColor");
}

void onDisplay() {

	glClearColor(0.5, 0.5, 0.5, 0);
	glClear(GL_COLOR_BUFFER_BIT);


	int location = glGetUniformLocation(gpuProgram.getId(), "color");
	glUniform3f(location, 0.0f, 0.0f, 0.0f);

	float MVPtransf[4][4] = { 1, 0, 0, 0,
							  0, 1, 0, 0,
							  0, 0, 1, 0,
							  0, 0, 0, 1 };

	location = glGetUniformLocation(gpuProgram.getId(), "MVP");
	glUniformMatrix4fv(location, 1, GL_TRUE, &MVPtransf[0][0]);

	glBindVertexArray(vao);
	glDrawArrays(GL_TRIANGLE_FAN, 0, PontokSzama);

	PirosUfo->draw();
	ZoldUfo->draw();
	glutSwapBuffers();
}

void onKeyboard(unsigned char key, int pX, int pY) {
	if (key == 'e')
		PirosUfo->Mozgat(0.5f, 0.0f);
	else if (key == 's')
		PirosUfo->Mozgat(0.0f, -0.03f);
	else if (key == 'f')
		PirosUfo->Mozgat(0.0f, 0.03f);
}

void onKeyboardUp(unsigned char key, int pX, int pY) {
}

void onMouseMotion(int pX, int pY) {
}

void onMouse(int button, int state, int pX, int pY) {

}

void onIdle() {
	long time = glutGet(GLUT_ELAPSED_TIME);
	PirosUfo->Mozgat(0, 0);
	ZoldUfo->setNezes(PirosUfo);
	PirosUfo->setNezes(ZoldUfo);

	ZoldUfo->Mozgat(0.007f, -0.022f);
	PirosUfo->SzajMozgat();
	ZoldUfo->SzajMozgat();
	PirosUfo->hozzaErt(ZoldUfo);
	glutPostRedisplay();
}