/*Girilen sayiya kadar olan sayilarin asal olup olmadigini bulan uygulama*/

#include<iostream>
using namespace std;

int main()
{
    int sayi, sayac=0;
    cout<<"Bir sayi giriniz: "; //Sinir Noktasi Belirlenir...
    cin>>sayi;
    cout<<endl;
    for(int i=2;i<=sayi;i++)	// Dongu 2 Sayisindan Baslar Cunku En Kucuk Asal Sayi 2'dir...
    {
        for(int a=2;a<i;a++)	//1. Dongudeki Sayi 2. Dongudeki Herhangi Sayiya Bolunuyorsa sayac artar
            if(i%a==0)
            {	sayac++; break;	}
        if(sayac==0)
            cout<<i<<" Sayi Asaldir..."<<endl;
        else
            cout<<i<<" Sayi Asal Degildir..."<<endl;
        sayac=0;	//Sayaci Sifirliyoruz ki dongu basa sardiginde sayac dogru calissin...
    }
    return 0;
}
