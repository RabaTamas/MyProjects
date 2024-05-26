#ifndef CSALADI_H
#define CSALADI_H

#include "film.h"
#include <iostream>
#include <string.h>
#include <fstream>
#include "memtrace.h"
class Csaladi :public Film
{
    int korhatar;
public:
    Csaladi(char*c=(char*)"", int h = 0, int e = 0, int k = 0) :Film(c, h, e), korhatar(k) {}
    Csaladi( const Csaladi &cs ) {*this = cs;}
    void setKor(int s) {korhatar = s;}
    Csaladi& operator=(const Csaladi& cs)
    {

        if(this != &cs)
        {
            korhatar = cs.korhatar;
            Film::operator=(cs);
        }
        return *this;
    }
    void kiir(std::ostream& os) const
    {
        if(save)
        {
            os << "Csaladi";
            Film::kiir(os);
            os<<","<<korhatar;
        }
        else
        {
            Film::kiir(os);
            os<<", "<<korhatar;
        }
    }

};



#endif
