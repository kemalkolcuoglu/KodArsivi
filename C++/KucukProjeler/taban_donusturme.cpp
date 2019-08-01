//Taban Aritmetigi-> Taban Donusturme
#include<iostream>
using namespace std;
int main()
{
    int sayi,taban,sayac=0; int a[100];
    cout<<"Bir Sayi Giriniz -> ";
    cin>>sayi;
    cout<<"Bir Taban Degeri Giriniz -> ";
    cin>>taban;
    while(sayi>=taban)
    {
        a[sayac++]=sayi%taban;
        sayi=sayi/taban;
    }
    a[sayac++]=sayi;
    cout<<endl<<taban<<" Tabaninda Sayinin Yeni Degeri -> ";
    for(int i=sayac-1;i>=0;i--)
        cout<<a[i];
    return 0;
}
