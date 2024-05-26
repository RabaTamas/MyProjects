#include <iostream>
#include "filmtar.h"
#include "film.h"
#include "memtrace.h"
using namespace std;

#define TEST
#ifdef TEST
#include "gtest_lite.h"
/*int main()
{
    Film *f = new Film((char*)"Eredet",148, 2010);
    Csaladi *cs= new Csaladi((char*)"A dzsungel konyve", 105, 2016, 6);
    Dokumentumfilm *d = new Dokumentumfilm((char*)"Schumacher", 113, 2021, (char*)"A hires Forma 1-es pilota elete");

    TEST(Film, UjFilm){
        std::string vart = "Eredet, 148 perc, 2010";
        std::stringstream sst;
        f->kiir(sst);
        EXPECT_EQ(vart, sst.str());
    }END

    TEST(Film, UjCsaladi){
        std::string vart = "A dzsungel konyve, 105 perc, 2016, 6";
        std::stringstream sst;
        cs->kiir(sst);
        EXPECT_EQ(vart, sst.str());
    }END

    TEST(Film, KorKivetel)
    {
        EXPECT_THROW(f->setKor(6), const char*);
    }END

    TEST(Film, LeirasKivetel)
    {
        EXPECT_THROW(f->setLeiras("Hello"), const char*);
    }END

    TEST(Film, UjDokumentum){
        std::string vart = "Schumacher, 113 perc, 2021, A hires Forma 1-es pilota elete";
        std::stringstream sst;
        d->kiir(sst);
        EXPECT_EQ(vart, sst.str());
    }END

    Filmtar tar;
        TEST(Filmtar, UresTar){
        EXPECT_EQ(0,tar.getDb());
    }END

    TEST(Filmtar, UresTarKiir){
        std::string vart = "";
        std::stringstream sst;
        tar.kiir(sst);
        EXPECT_EQ(vart, sst.str());
    }END

    TEST(Filmtar, TarHozzaad){
        tar += *f;
        EXPECT_EQ(1,tar.getDb());
    }END

    tar += *cs;
    tar += *d;

    TEST(Filmtar, TarKiir){
        std::string vart = "Eredet, 148 perc, 2010\nA dzsungel konyve, 105 perc, 2016, 6\nSchumacher, 113 perc, 2021, A hires Forma 1-es pilota elete\n";
        std::stringstream sst;
        tar.kiir(sst);
        EXPECT_EQ(vart, sst.str());
    }END

    TEST(Filmtar,Mentes)
    {
        Film::save = true;
        std::string vart = "Film,Eredet,148,2010\nCsaladiFilm,A dzsungel konyve,105,2016,6\nDokumentumFilm,Schumacher,113,2021,A hires Forma 1-es pilota elete\n";
        std::stringstream sst;
        tar.kiir(sst);
        EXPECT_EQ(vart, sst.str());
        Film::save =false;
    }END

    TEST(Filmtar,Rendez)
    {
        std::string vart = "A dzsungel konyve, 105 perc, 2016, 6\nEredet, 148 perc, 2010\nSchumacher, 113 perc, 2021, A hires Forma 1-es pilota elete\n";
        std::stringstream sst;
        tar.rendez(1);
        tar.kiir(sst);
        EXPECT_EQ(vart, sst.str());
    }END

    TEST(Filmtar,TarTorol)
    {
        tar.torol(1);
        EXPECT_EQ(2, tar.getDb());
    }END

    return 0;
}
*/

//#else
int main()
{
    Filmtar tar;
    int n = 0;
    std::cout<<"Kedves felhasznalo udvozlom a filmtar programban!\n";
    while(n != 9)
    {
        std::cout<<"\nValasszon az alabbi lehetoseg kozul!\n" \
            <<"1:Filmek beolvasasa\n2:Filmtar kiirasa\n3:Film hozzzadasa\n4:Film torlese\n5:Film modositasa\n6:Film keresese\n7:Filmtar rendezese\n8:Filmtar elmentese\n9:Kilepes\n";
        std::cin>>n;
        switch(n)
        {
            case(1):
            {
                tar.beolvas();
                std::cout<<"Beolvasta filmek.txt tartalmat a filmtarba!\n";
            }
            break;
            case(2):
            {
                std::cout<<"Filmtar tartalma:\n";
                tar.kiir(std::cout);
            }
            break;
            case(3):
                tar.add();
            break;
            case(4):
                tar.friendly_torol();
            break;
            case(5):
                tar.modosit();
            break;
            case(6):
                tar.keres();
            break;
            case(7):
            {
                tar.friendly_rendez();
                std::cout<<"Rendezte a filmtarat valasztasa szerint!\n";
            }
            break;
            case(8):
                tar.mentes();
            break;
            case(9):
                std::cout<<"Kilepett!\n";
            break;
        }
    }
    return 0;
}

#endif // TEST
