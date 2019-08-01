/*Bakkal Hesap Sistemi-Urun istemeli*/

#include<iostream>
using namespace std;
int main()
{
    float ef,cf,mf,t; int e,c,m;
    cout<<"Bakkal Hesap Sistemine Hosgeldiniz...\n\n";
    cout<<"Lutfen ekmek miktari giriniz: ";
    cin>>e;
    cout<<"Lutfen urun fiyatini giriniz: ";
    cin>>ef;
    cout<<"\nLutfen cikolata miktari giriniz: ";
    cin>>c;
    cout<<"Lutfen urun fiyatini giriniz: ";
    cin>>cf;
    cout<<"\nLutfen margarin miktari giriniz: ";
    cin>>m;
    cout<<"Lutfen urun fiyatini giriniz: ";
    cin>>mf;
    t=(e*ef)+(c*cf)+(m*mf);
    cout<<"\nToplam Tutar: "<<t;
}
