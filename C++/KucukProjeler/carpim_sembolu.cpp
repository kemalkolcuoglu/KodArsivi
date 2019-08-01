/*Girilen bir sayidan diger sayiya kadar olan sayilarin toplamini ekrana yazdiran uygulama*/
#include<iostream>
using namespace std;

int main ()
{
    int sayi1,sayi2,carpim=1,ks=0,bs=0;
    cout<<"Sayi giriniz: ";
    cin>>sayi1;
    cout<<"Sayi giriniz: ";
    cin>>sayi2;
    ((sayi1<sayi2)?(ks=sayi1,bs=sayi2):(bs=sayi1,ks=sayi2));
    cout<<endl;
    for(ks;ks<=bs;ks++)
    {
        carpim*=ks;
        cout<<'*'<<ks;
    }
    cout<<'='<<carpim;

    return 0;
}
