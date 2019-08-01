/*Girilen sayiya kadar olan sayilarin toplamini ekrana yazdiran uygulama*/
#include<iostream>
using namespace std;

int main ()
{
    int sayi,toplam=0;
    cout<<"Bir sayi giriniz: ";
    cin>>sayi;
    cout<<endl;
    for(int i=1;i<=sayi;i++)
    {
        toplam+=i;
        cout<<'+'<<i;
    }
    cout<<'='<<toplam;

    return 0;
}
