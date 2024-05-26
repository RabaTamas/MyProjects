#ifndef FILM_H
#define FILM_H

#include <iostream>
#include <string.h>
#include <fstream>
#include "memtrace.h"
class Film
{
    char*cim;
    int hossz, ev;
public:
    static bool save;
    Film(char*c=(char*)"", int h = 0, int e = 0) :cim(new char [strlen(c)+1]), hossz(h), ev(e) {strcpy(cim, c);}
    Film(const Film& f) :cim(NULL) {*this = f;}
    virtual ~Film() {delete[] cim;}
    const char* getCim() const {return cim;}
    const int getHossz() const {return hossz;}
    const int getEv() const {return ev;}
    void setCim(char* s)
    {
        delete[] cim;
        cim = new char[strlen(s)+1];
        strcpy(cim, s);
    }
    void setHossz(int s) {hossz = s;}
    void setEv(int s) {ev = s;}
    virtual void setKor(int s)
    {
        throw "Nem lehet  modositani!\n";
    }
    virtual void setLeiras(char* s)
    {
        throw "Nem lehet modositani!\n";
    }
    Film& operator=(const Film& f)
    {
        if(this != &f)
        {
            delete[] cim;
            hossz = f.hossz;
            ev = f.ev;
            cim = new char[strlen(f.cim)+1];
            strcpy(cim, f.cim);
        }
        return *this;
    }
    virtual void kiir(std::ostream& os) const
    {
        if(save)
        {
            os << "Film," << cim <<"," << hossz << "," << ev;
        }
        else
        {
            os<< cim <<", " << hossz << " perc, " << ev;
        }
    }

};

std::ostream& operator<<(std::ostream& os, const Film& f) {
    f.kiir(os);
    return os;
}

bool Film::save = false;




#endif
