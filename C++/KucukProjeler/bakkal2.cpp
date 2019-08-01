/*Bakkal Hesap Sistemi-Urun istemeli*/

#include<iostream>
using namespace std;
int main()
{
    string urun; float f,t; int u;
    cout<<"Bakkal Hesap Sistemine Hosgeldiniz...\n\n";
    cout<<"Lutfen alacaginiz urunu seciniz (Ekmek,Cikolata,Margarin) :";
    cin>>urun;

    if(urun=="Cikolata")
    {
        cout<<"Lutfen urun miktari giriniz: ";
        cin>>u;
    }
    else if(urun=="Margarin")
    {
        cout<<"Lutfen urun miktari giriniz: ";
        cin>>u;
    }
    else if(urun=="Ekmek")
    {
        cout<<"Lutfen urun miktari giriniz: ";
        cin>>u;
    }
    else
        cout<<"Komut anlasilamadi...";

    cout<<"\nLutfen urun fiyatini giriniz: ";
    cin>>f;
    t=u*f;
    cout<<"\nToplam Tutar: "<<t;

    return 0;
}
