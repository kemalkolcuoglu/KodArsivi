#include <cstdlib>
#include <iostream>
#include <windows.h>
#include <conio.h>
#include <time.h>
using namespace std;
//=======================================================================
int main()
{
    unsigned int tahmin,sayi,hak=10,tekrar=0,seviye; char karar;
    cout<<".....:::::   Sayi Bulma Oyunu   :::::....."<<endl<<endl;
    bas:
    cout<<"Lutfen Zorluk Seviyenizi Seciniz "<<endl
        <<"1. Kolay (10 Tahmin Hakki)"<<endl
        <<"2. Normal (5 Tahmin Hakki)"<<endl
        <<"3. Zor (3 Tahmin Hakki)"<<endl
        <<"4. Nokta Atisi (Tek Tahmin Hakki)"<<endl<<endl
        <<"Seciniz -> ";
    cin>>seviye;
    switch (seviye)
    {
        case 1 : hak=10; break;
        case 2 : hak=5; break;
        case 3 : hak=3; break;
        case 4 : hak=1; break;
    }
    srand(time(NULL));
    sayi=1+rand()%100;
    cout<<"\n";
    cout<<"Bir Sayi Girerek Oyuna Baslayabilirsiniz : ";
    cin>>tahmin;
    cout<<"\n";
    while(true)
    {
        tekrar++;
        if(hak-tekrar==0)
        {
            cout<<"Hakkiniz Bitti! Oyunu Kaybettiniz..."<<endl<<endl
                <<"Bulmaniz Gereken Sayi "<<sayi<<"\'idi...\n\n";
            break;
        }
        if(tahmin==sayi)
        {
            cout<<"Tebrikler! Dogru Cevap!"<<endl;
            break;
        }
        else if(tahmin<sayi)
        {
            cout<<"Kalan Hakkiniz : "<<hak-tekrar<<endl<<endl
                <<"Daha Buyuk Bir Sayi Giriniz! "<<endl
                <<"Tahmin : ";
        }
        else if(tahmin>sayi)
        {
            cout<<"Kalan Hakkiniz : "<<hak-tekrar<<endl<<endl
                <<"Daha Kucuk Bir Sayi Giriniz! "<<endl
                <<"Tahmin : ";
        }

        cin>>tahmin; cout<<endl; continue;
    }
    tekrar=0;
    cout<<"\n\nTekrar Oynamak Ister Misiniz? (E/H) -> ";
    karar = getch();
    cout<<"\n";
    if(karar=='E'||karar=='e')
    {
        cout<<"____________________________________________\n\n";
        goto bas;
    }
    else
        cout<<"\n\nOyunu oynadiginiz icin tesekkurler :)"<<endl;
//=============================================================================
    system("PAUSE");
    return EXIT_SUCCESS;
}
