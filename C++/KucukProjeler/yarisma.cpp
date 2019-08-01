/*Parali Bilgi Yarismasi*/

#include<iostream>
using namespace std;

int main()
{
    string a,b,c,d,a1,b1,c1,d1,x,ad,soyad;

    cout<<"\t\t\t...Bilgi Yarismasina Hosgeldiniz...\n\n"
        <<"Lutfen adinizi ve soyadinizi giriniz: ";
    cin>>ad>>soyad;
    cout<<"\n\n";

    cout<<"1. Soru : Asagidakilerden hangisi ilk dort yildizli Turk takimidir?\n"
        <<"A)Galatasaray B)Besiktas C)Fenerbahce D)Trabzonspor\n"
        <<"Cevap: ";
    cin>>x;
    a='A';  a1='a';
    b='B';  b1='b';
    c='C';  c1='c';
    d='D';  d1='d';

    if(x==a||x==a1){
    cout<<"Dogru cevap!\n500 TL Kazandiniz...";
    cout<<"\n\n2. Soru : Turk futbol tarihinde en fazla farkla hangi takim galibiyet almistir?\n"
        <<"A)Trabzonspor B)Besiktas C)Fenerbahce D)Galatasaray\n"
        <<"Cevap: ";
    cin>>x;
        if(x==b||x==b1){
        cout<<"Dogru cevap!\n1000 TL Kazandiniz...";
        cout<<"\n\n3. Soru : Asagidaki illerden hangisi sonradan il olmustur?\n"
            <<"A)Usak B)Sivas C)Gaziantep D)Karaman\n"
            <<"Cevap: ";
        cin>>x;
            if(x==d||x==d1){
            cout<<"Dogru cevap!\n2000 TL Kazandiniz...";
            cout<<"\n\n4. Soru : Asagidakilerden hangisi Anadoluda yasamis bir hayvan degildir?\n"
                <<"A)Pars B)Leopar C)Kelaynak D)Timsah\n"
                <<"Cevap: ";
            cin>>x;
                if(x==b||x==b1){
                cout<<"Dogru cevap!\n3000 TL Kazandiniz...";
                cout<<"\n\n5. Soru : Real Madrid'in en cok gol atan oyuncusu kimdir?\n"
                    <<"A)Ozil B)Bale C)C. Ronaldo D)Zidan\n"
                    <<"Cevap: ";
                cin>>x;
                    if(x==c||x==c1){
                    cout<<"Dogru cevap!\n\nTebrikler! Yarismayi basari ile tamamladiniz ve 10000 TL Kazandiniz...";
                    }
                        else{   cout<<"\nKaybettiniz...";     }
                    }

                else{   cout<<"\nKaybettiniz...";     }
            }
            else{   cout<<"\nKaybettiniz...";     }
        }
        else{   cout<<"\nKaybettiniz...";     }
    }
    else{     cout<<"\nKaybettiniz...";    }

    int k;
    cout<<"\n\n\nCikmak icin bir sayi giriniz: ";
    cin>>k;

    return 0;
}
