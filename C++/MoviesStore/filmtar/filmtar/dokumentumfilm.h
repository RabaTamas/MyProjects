#ifndef DOKUMENTUMFILM_H
#define DOKUMENTUMFILM_H

#include "film.h"
#include <iostream>
#include <string.h>
#include <fstream>
#include "memtrace.h"

class Dokumentumfilm :public Film
{
    char* leiras;
public:
    Dokumentumfilm(char*c=(char*)"", int h = 0, int e = 0, char* l =(char*)"") :Film(c, h, e), leiras(new char[strlen(l)+1]) {strcpy(leiras, l);}
    Dokumentumfilm( const Dokumentumfilm &d ) :leiras(NULL) {*this = d;}
    void setLeiras(char* s)
    {
        delete[] leiras;
        leiras = new char[strlen(s)+1];
        strcpy(leiras, s);
    }
    Dokumentumfilm& operator=(const Dokumentumfilm& d)
    {

        if(this != &d)
        {
            delete[] leiras;
            leiras = new char[strlen(d.leiras)+1];
            strcpy(leiras, d.leiras);
            Film::operator=(d);
        }
        return *this;
    }
    ~Dokumentumfilm() {delete[] leiras;}
    void kiir(std::ostream& os) const
    {
        if(save)
        {
            os << "Dokumentum";
            Film::kiir(os);
            os<<","<<leiras; //<<std::endl;
        }
        else
        {
            Film::kiir(os);
            os<<", "<<leiras; //<<std::endl;
        }
    }
};


#endif
