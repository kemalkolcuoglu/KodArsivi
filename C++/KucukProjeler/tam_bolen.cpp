//Girilen Sayinin Tam Bolenlerini Bulan ve Bu Sayilari Toplayan Uygulama
#include<iostream>
using namespace std;
int fonk(int sayi)
{
    int toplam=0;
    cout<<"Tam Bolenleri : ";
    for(int i=1;i<=sayi;i++)
    {
        if(sayi%i==0)
        {
            toplam+=sayi/i;
            cout<<i<<", ";
        }
    }
    return toplam;
}
int main()
{
    int sayi;
    cout<<"Girilen Sayinin Tam Bolenlerini Bulan ve Bu Sayilari Toplayan Uygulama\n\n"
        <<"Bir sayi giriniz -> ";
    cin>>sayi;
    cout<<"\nSayilarin Toplami = "<<fonk(sayi)<<endl;
    return 0;
}
