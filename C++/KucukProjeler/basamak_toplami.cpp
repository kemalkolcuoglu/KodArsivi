/****   Basamaklardaki Rakamlarin Toplami   ****/
#include<iostream>
using namespace std;

int main()
{
    int sayi,sayac[100],i=1,basamakSayisi=0,toplam=0;
    cout<<"Bir sayi giriniz : "; cin>>sayi;
    while(true)
    {
        if(sayi>i)
            i=i*10;
        else
            break;
    }
    i=i/10;
    for(int a=0;basamakSayisi<i||i<sayi;i/=10,a++,basamakSayisi++)
    {
    	if(sayi==0)
			continue;
        sayac[a]=sayi/i;
        sayi=sayi%i;
        toplam+=sayac[a];
    }
    cout<<"Basamak Toplamlari : "<<toplam<<endl;
    cout<<"Basamak Sayisi : "<<basamakSayisi<<endl;
    getchar();
    return 0;
}
