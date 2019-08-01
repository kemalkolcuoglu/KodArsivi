#include<iostream>
#include<stdlib.h>
#include<conio.h>
using namespace std;
int hesap(float);
int ortalama(float);
int karar(int);
int main()
{
    int islem,a=1; string s(50,'-');
    cout<<"\t  ...:::Ogrenci Not Hesaplama Sistemine Hosgeldiniz:::...\n\n"
        <<"Lutfen Bir Islem Seciniz: \n"
        <<"1. Ders Ortamasi Hesabi\n"
        <<"2. Donem Notu Ortalamasi Hesabi\n"
        <<"3. Cikis\n"
        <<"\nIslem -> ";
    karar(islem);
    do{
    cout<<s<<endl<<"Yeni Islem Icin Sayi Giriniz -> ";
    karar(islem);
    a++;
    }while(true);
    return 0;
}
int karar(int islem)
{
    float x; string s(50,'_');
    cin>>islem;
    cout<<s;
    if(islem==1)
        hesap(x);
    else if(islem==2)
        ortalama(x);
    else if(islem==3)
    {
        cout<<"\n\nBu Uygulamayi Kullandiginiz Icin Tesekkur Ederiz :)\n\n";
        islem=3;
        getch();
        exit(3);
    }
    else
        cout<<"\nKomut Anlasilamadi\n";

    return islem;
}
int hesap(float x)
{
    float ara,ort,son; char gir;
	cout<<"\n\nLutfen Ara Sinav Notunuzu Giriniz: ";
	cin>>ara;
	cout<<"Final Notunuzu Giriniz: ";
	cin>>son;
    ort=(ara+son)/2;
    cout<<"\nOrtalamaniz: "<<ort;
    cout<<"\nButunleme Sinavina girecek misiniz? (E/H) ->";
    cin>>gir;
    if(gir=='E')
    {
        cout<<"Butunleme Sinavi Notunu Giriniz: ";
        cin>>son;
        ort=(ara+son)/2;
        cout<<"\nOrtalamaniz: "<<ort<<endl;
    }
    else if(gir=='H')
        cout<<"\n";

    if(ort>=90)
        cout<<"Harf Notunuz: AA Katsayisi: 4";
    else if(ort>=80)
        cout<<"Harf Notunuz: BA Katsayisi: 3.5";
    else if(ort>=70)
        cout<<"Harf Notunuz: BB Katsayisi: 3";
    else if(ort>=65)
        cout<<"Harf Notunuz: CB Katsayisi: 2.5";
    else if(ort>=60)
        cout<<"Harf Notunuz: CC Katsayisi: 2.25";
    else if(ort>=55)
        cout<<"Harf Notunuz: DC Katsayisi: 1.75";
    else if(ort>=50)
        cout<<"Harf Notunuz: DD Katsayisi: 1.25";
    else if(ort>=40)
        cout<<"Harf Notunuz: FD Katsayisi: 0.75";
    else
        cout<<"Harf Notunuz: FF Katsayisi: 0";

    cout<<endl<<endl;

    return ort;
}
int ortalama(float x)
{
    int sayi,i=1; float kredi,katsayi,ort=0,kreditop=0; string s(50,'-');
    cout<<"\n\nLutfen Ders Sayisi Giriniz: ";
    cin>>sayi;
    cout<<s<<endl;
    //Ortalama=((Kredi * Katsayi) / Krediler Toplami)
    for(;i<=sayi;i++)
    {
        cout<<i<<". Dersin Kredisini Giriniz: ";
        cin>>kredi;
        cout<<i<<". Dersin Katsayisini Giriniz: ";
        cin>>katsayi;
        kreditop+=kredi;
        ort+=kredi*katsayi;
    }
    ort=ort/kreditop;
    cout<<"\n\nNot Ortalamaniz: "<<ort<<endl<<endl;
    return ort;
}
