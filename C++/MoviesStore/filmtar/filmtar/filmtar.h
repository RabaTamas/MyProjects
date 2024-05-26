#ifndef FILMTAR_H
#define FILMTAR_H

#include "csaladi.h"
#include "dokumentumfilm.h"
#include "film.h"
#include <iostream>
#include <string.h>
#include <fstream>
#include "memtrace.h"

class Filmtar{
    class ListaElem {
        Film* film;
        ListaElem* kov;
    public:
        ListaElem(Film* f) : kov(NULL)
        {
            film = f;
        }
        ListaElem* getKov()
        {
            return kov;
        }
        void setKov(ListaElem* kov)
        {
            this->kov = kov;
        }

        Film* getData()
        {
            return film;
        }
        void setData(Film* f)
        {
            film = f;
        }
        ~ListaElem(){ delete film;}
    } *lista;
    int db;
    void felcserel(ListaElem** a,ListaElem** b )
    {
        Film* tmp = (*a)->getData();
        (*a)->setData((*b)->getData());
        (*b)->setData(tmp);
    }
    Filmtar(const Filmtar& );
    Filmtar& operator=(const Filmtar& );
public:
    Filmtar() :lista(NULL), db(0) {}
    ~Filmtar()
    {
        ListaElem* mozgo = lista;
        while(mozgo != NULL)
        {
            ListaElem* kov = mozgo->getKov();
            delete mozgo;
            mozgo = kov;
        }

    }

    Film& operator[](int index)
    {
        int i;
        ListaElem* mozgo;
        for(i = 0,mozgo = lista; i < index && mozgo != NULL; i++, mozgo = mozgo->getKov())
            ;
        if(mozgo == NULL)
        {
            throw "Tulindexelted!";
        }
        Film& f = *(mozgo->getData());
    }
    int getDb()
    {
        return db;
    }
    void operator+=(Film& f)
    {
        db++;
        if(lista == NULL)
        {
            lista = new ListaElem(&f);
            return;
        }
        ListaElem* mozgo;
        for(mozgo = lista; mozgo->getKov() != NULL; mozgo = mozgo->getKov()) ;
        mozgo->setKov(new ListaElem(&f));
    }
    void kiir(std::ostream& os) const
    {
        for(ListaElem* mozgo = lista; mozgo != NULL; mozgo = mozgo->getKov())
        {
            os<< *(mozgo->getData())<< std::endl;
        }
    }
    void friendly_torol()
    {
        std::cout << "Hanyadikat szeretned torolni?\n";
        kiir(std::cout);
        int n;
        std::cin >> n;
        torol(n);
    }
    void torol(int n)
    {
        int i = 1;
        ListaElem* lemarado = NULL;
        ListaElem* mozgo = lista;
        while (mozgo != NULL && i != n)
        {
            lemarado = mozgo;
            mozgo = mozgo->getKov();
            i++;
        }
        if (lemarado == NULL)
        {
            ListaElem *ujeleje = mozgo->getKov();
            delete mozgo;
            lista = ujeleje;
        }
        else
        {
            lemarado->setKov(mozgo->getKov());
            delete mozgo;
        }
        db--;

    }
    void keres()
    {
        std::cout << "Film cim reszlet:\n";
        std::string tomb;
        std::cin.ignore();
        std::getline(std::cin,tomb);
        for(ListaElem* mozgo = lista; mozgo != NULL; mozgo = mozgo->getKov())
        {
            if(!strncmp(tomb.c_str(), mozgo->getData()->getCim(),strlen(tomb.c_str() )))
                std::cout << *(mozgo->getData())<< std::endl;
        }
    }
    void mentes()
    {
        std::string nev;
        std::cout<< "Adja meg a fajlnevet(a kiterjesztes nem kell):\n";
        std::cin>> nev;
        std::ofstream file;
        file.open(nev+".txt");
        Film::save=true;
        for(ListaElem* mozgo = lista; mozgo != NULL; mozgo = mozgo->getKov())
        {
            file<< *(mozgo->getData())<< std::endl;
        }
        Film::save = false;
        file.close();
        std::cout<<"Elmentette a filmtar tartalmat a "<<nev<<".txt-be!\n";
    }
    void beolvas(){
        std::ifstream file;
        file.open("filmek.txt");

        std::string sor;
        std::string elvalaszto = ",";
        std::string tipus;

        while(std::getline(file, sor)) {
            Film* uj = NULL;
            int darabszamlalo = 0;
            std::string darab = " ";
            unsigned int pozicio = sor.find(elvalaszto);
            while(darab != "") {
                darab = sor.substr(0, pozicio);
                if(darabszamlalo == 0) {
                    tipus = darab;
                }

                if(tipus == "CsaladiFilm") {
                    if(uj == NULL) {
                    uj = new Csaladi();
                    }
                    if(darabszamlalo == 4) {
                    uj->setKor(stoi(darab));
                    }
                }
                if(tipus == "DokumentumFilm") {
                    if(uj == NULL) {
                    uj = new Dokumentumfilm();
                    }
                    if(darabszamlalo == 4) {
                    uj->setLeiras((char*)darab.c_str());
                    }
                }
                if(tipus == "Film") {
                    if(uj == NULL) {
                    uj = new Film();
                    }
                }

                if(darabszamlalo == 1) {
                    uj->setCim((char*)darab.c_str());
                }
                else if(darabszamlalo == 2) {
                    uj->setHossz(stoi(darab));
                }
                else if(darabszamlalo == 3) {
                    uj->setEv(stoi(darab));
                }

                darabszamlalo++;
                sor.erase(0, pozicio + elvalaszto.length());
                pozicio = sor.find(elvalaszto);
            }
            *this += *uj;
        }
    }

    void friendly_rendez()
    {
        int input;
        std::cout<<"Mi alapjan szeretned rendezni?\n" \
        <<"1:Cim\n2:Hossz\n3:Ev\n";
        std::cin >> input;
        rendez(input);
    }
    void rendez(int input){

        for(ListaElem* mozgo_1 = lista; mozgo_1 != NULL; mozgo_1 = mozgo_1->getKov())
        {
            for(ListaElem* mozgo_2 = mozgo_1->getKov(); mozgo_2 != NULL; mozgo_2 = mozgo_2->getKov())
            {
                if(input == 1)
                {
                    if(strcmp(mozgo_1->getData()->getCim(), mozgo_2->getData()->getCim()) > 0)
                    {
                        felcserel(&mozgo_1, &mozgo_2);
                    }
                }
                else if(input == 2)
                {
                    if(mozgo_1->getData()->getHossz() >  mozgo_2->getData()->getHossz())
                    {
                        felcserel(&mozgo_1, &mozgo_2);
                    }
                }
                else if(input == 3)
                {
                    if(mozgo_1->getData()->getEv() >  mozgo_2->getData()->getEv())
                    {
                        felcserel(&mozgo_1, &mozgo_2);
                    }
                }
            }
        }
    }
    void modosit()
    {
        std::cout<<"Hanyadikat szeretned modositani?\n";
        this->kiir(std::cout);
        int input;
        std::cin>> input;
        try
        {
            int opcio;
            std::cout<<"Melyik adatat szeretned modositani?\n" \
            <<"1:Cim\n2:Hossz\n3:Ev\n4:Korhatar\n5:Leiras\n";
            std::cin>>opcio;
            switch(opcio)
            {
                case(1):
                {
                    std::cout<<"Mi legyen az uj cim?\n";
                    std::string cim;
                    std::cin.ignore();
                    std::getline(std::cin,cim);
                    (*this)[input-1].setCim((char*)cim.c_str());
                }
                break;
                case(2):
                {
                    std::cout<<"Mi legyen az uj hossz?\n";
                    int hossz;
                    std::cin>> hossz;
                    (*this)[input-1].setHossz(hossz);
                }
                break;
                case(3):
                {
                    std::cout<<"Mi legyen az uj kiadasi ev?\n";
                    int ev;
                    std::cin>> ev;
                    (*this)[input-1].setEv(ev);
                }
                break;
                case(4):
                {
                    std::cout<<"Mi legyen az uj korhatar?\n";
                    int korhatar;
                    std::cin>> korhatar;
                    (*this)[input-1].setKor(korhatar);
                }
                break;
                case(5):
                {
                    std::cout<<"Mi legyen az uj leiras?\n";
                    std::string leiras;
                    std::cin.ignore();
                    std::getline(std::cin,leiras);
                    (*this)[input-1].setLeiras((char*)leiras.c_str());
                }
                break;
            }

        }
        catch(const char* f)
        {
            std::cout<< f;
        }



    }
    void add()
    {
        Film *f = NULL;
        std::string cim;
        int ev, hossz, tipus;
        std::cout<<"Milyen filmet szeretnél hozzadni a filmtarhoz?\n1:Film\n2:CsaladiFilm\n3:DokumentumFilm\n";
        std::cin>> tipus;
        std::cout<<"Add meg a film adatait! (Cim, hossz, ev)\n";
        std::cout<<"Cim:\n";
        std::cin.ignore();
        std::getline(std::cin, cim);
        std::cout<<"Hossz:\n";
        std::cin>> hossz;
        std::cout<<"Ev:\n";
        std::cin>> ev;
        if(tipus == 1)
        {
            f = new Film((char*) cim.c_str(),hossz, ev);
        }
        else if(tipus == 2)
        {
            int korhatar;
            std::cout<<"Korhatar:\n";
            std::cin >> korhatar;
            f = new Csaladi((char*)cim.c_str(),hossz, ev, korhatar);
        }
        else if(tipus == 3)
        {
            std::string leiras;
            std::cout<<"Leiras:\n";
            std::cin.ignore();
            std::getline(std::cin, leiras);
            f = new Dokumentumfilm((char*)cim.c_str(),hossz, ev, (char*)leiras.c_str());

        }
        operator+=(*f);
    }

};


#endif
