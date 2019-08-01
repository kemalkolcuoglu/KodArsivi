#include"stdafx.h"
#include<iostream>
#include<string>
#include<conio.h>
#define MAX 150
#define MAX2 15
#define MAX3 10
using namespace std;
void gorevli_menu();
void ana_menu();
class Ogrenci
{  //ogrenci sinifi tanýmlandi.
public:
    string ad,soyad;
    int numara,vize,final;
    double ort;
    Ogrenci(){};
    void yenikayit(string,string,int);
}ogrenciler[MAX],ogrenciler1[MAX3];
void Ogrenci::yenikayit(string a,string s,int n)
{
    ad=a; soyad=s; numara=n; //ogrenci sinifinin elemanlarinin atamalari yapildi.
}
class Ogretmen
{   //ogretmen sinifi tanimlandi.
public:
    string ogretmen_ad,ogretmen_soyad,sifre;
    string ders;
    int ogretmen_no;
    void yenikayit(int,string,string,string,string);
    void ogretmen_menu();
}ogretmenler[MAX2];
void Ogretmen::yenikayit1(int n,string a,string s, string d, string pass)
{
    ogretmen_no=n; ogretmen_ad=a; ogretmen_soyad=s; ders=d; sifre=pass; //ogretmen sinifinin elemanlarinin atamalari yapildi.
}
void Ogretmen::ogretmen_menu()
{
    int secim,n;
    static double toplam;   //indis olarak kullanilacagi icin static olarak tanimlandi.
    static int d=-1;        //fonksiyon her cagirildiginda onceki degerini korur.
    system("cls");
    cout<<"Ogretmen Not Sistemi"<<endl
        <<"--------------------"<<endl
        <<"1. Not Girisi"<<endl
        <<"2. Sinif Not Ortalamasi"<<endl
        <<"3. Ogrenci Listesi"<<endl
        <<"4. Ana Menu"<<endl;
    secim=getch();

    switch(secim)
    {
    case'1':
        system("cls");
        cout<<"Notu gireceginiz ogrencinin numarasini giriniz : "<<endl;
        cin>>n;
        for(int c=0;c<150;c++)
        {
            if(ogrenciler[c].numara==n)
            {
                system("cls");
                cout<<"Vize Giriniz : ";
                cin>>ogrenciler[c].vize;
                cout<<"Final Giriniz : ";
                cin>>ogrenciler[c].final;
                cout<<"Islem Basarili."<<endl;
                d++;
                ogrenciler[c].ort=double(ogrenciler[c].vize*0.3+ogrenciler[c].final*0.7);
                ogrenciler1[d]=ogrenciler[c];   //secili ogretmenin dersini alan ogrenciler ayni nesne dizisine aliniyor.
                system("pause");
                ogretmen_menu();
            }
        }
        cout<<"Ogrenci bulunamadi..."<<endl;
        system("pause");
        ogretmen_menu();
    case'2':
        system("cls");
        cout<<"Sinifin Not Ortalamasi : ";
        if(d<0)
        {
            cout<<"Bu dersi alan ogrenci yok."<<endl;
            system("pause");
            ogretmen_menu();
        }
        else
        {
            for(int x=0;x<=d;x++)
                toplam+=ogrenciler1[x].ort; //tum elemanlarin ortalamalari toplanýyor.
            cout<<toplam/(d+1)<<endl;
            system("pause");
            ogretmen_menu();
        }
    case'3':
        system("cls");
        for(int x=0;x<=d;x++)
        {
            for(int y=0;y<=d;y++)
            {
                if(ogrenciler1[x].numara==ogrenciler[y].numara)
                {/*Buradaki if yapisi ogrencinin görevli tarafindan silinmesi durumunda burada notunun gonderilmesi saglar.*/
                    cout<<"Ad : "<<ogrenciler1[x].ad<<"\t"
                        <<"Soyad : "<<ogrenciler1[x].soyad<<"\t"
                        <<"Numara : "<<ogrenciler1[x].numara<<"\t"
                        <<"Ortalama : "<<ogrenciler1[x].ort<<endl;
                }
            }
        }
        system("pause");
        ogretmen_menu();
    case'4':
        system("cls");
        ana_menu();
    }
}
int main()
{
    ana_menu();
    system("pause");
    return 0;
}
void ana_menu()
{
    system("cls");
    int secim,b,num;
    string sifre;
    string k_id,k_sifre;
    cout<<"Okul Otomasyonu"<<endl
        <<"---------------"<<endl
        <<"1. Gorevli Girisi"<<endl
        <<"2. Ogretmen Girisi"<<endl
        <<"2. Cikis"<<endl;
    secim=getch();
    switch(secim)
    {
    case'1':
        system("cls");
        cout<<"Kullanici Adi : ";
        cin>>k_id;
        if(k_id=="1")
        {
            cout<<"Sifre : ";
            cin>>k_sifre;
            if(k_sifre=="1")
                gorevli_menu();
            else
            {
                cout<<"Sifre yanlis!"<<endl;
                system("pause");
                ana_menu();
            }
        }
        else
        {
            cout<<"Hatali Giriþ!.."<<endl;
            system("pause");
            ana_menu();
        }
    case'2':
        system("cls");
        cout<<"Numara giriniz : ";
        cin>>num;
        for(b=0;b<15;b++)
        {
            if(ogretmen[b].ogretmen_no==num)
            {
                cout<<"Sifre Giriniz : ";
                cin>>sifre;
                if(ogretmenler[b]==sifre)
                {
                    cout<<"Sifre Dogru!"<<endl;
                    system("pause");
                    ogretmenler[b].ogretmen_menu();
                }
                else
                {
                    cout<<"Sifre Yanlis!"<<endl;
                    system("pause");
                    ana_menu();
                }
            }
            else
            {
                cout<<"Numara Yanlis!"<<endl;
                system("pause");
                ana_menu();
            }
        }
    case'3': exit(0);
        default:ana_menu();
    }
}
void gorevli_menu()
{

}
