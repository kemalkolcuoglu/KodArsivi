/*Girilen sayilarin arasindaki siralamasini yapan uygulama*/

#include<iostream>
using namespace std;
int main()
{
    int sayi1, sayi2, bs, ks;
    cout<<"Bir sayi giriniz: ";
    cin>>sayi1;
    cout<<"Bir sayi daha giriniz: ";
    cin>>sayi2;
    if (sayi1<sayi2)
    {   ks=sayi1; bs=sayi2;  }
    else
    {   bs=sayi1; ks=sayi2;  }
    cout<<endl<<"Buyuk sayi: "<<bs
        <<endl<<"Kucuk sayi: "<<ks<<endl<<endl;
    if(sayi1<sayi2)
    {
        for (int i=ks; i<=bs; i++)
        { cout<<i<<endl; }
    }
    else
    {
        for(int i=bs;i>=ks;i--)
        { cout<<i<<endl; }
    }
    return 0;
}
