/***********************************************************************************************************************************
*********************                   Klavyeden N tane deðer girilmektedir.                       ********************************
*********************                  Önce, girilen deðerlerin ortalamasý (R),                     ********************************
*********************            daha sonra bu ortalamanýn %10’u (d) hesaplanacaktýr.               ********************************
*********************           Sonuç olarak, girilen sayýlardan R-d ve R+d deðerleri               ********************************
*********************  arasýnda kalanlarýnýn sayýsýný bulan ve ekrana yazdýran bir program yazýnýz. ********************************
***********************************************************************************************************************************/
#include<iostream>
#include<stdlib.h>
#include<conio.h>
using namespace std;
//=============================
int main()
{
    int N, sayac=0; float R=0, d=1;
    cout<<"Sayi Sayisi Giriniz : ";
    cin>>N;
    int a[N];
    for(int i=0;i<N;i++)
    {
        cout<<i+1<<". Sayi : ";
        cin>>a[i];
        R+=a[i];
    }
    for(int i=0;i<N;i++)
        cout<<a[i]<<' ';
    cout<<endl<<"R: "<<R;
    R/=N; cout<<endl<<"R: "<<R;
    d=R*0.1; cout<<endl<<"d: "<<d<<endl<<endl;
    for(int i=0;i<N;i++)
    {
        if(a[i]>R-d && a[i]<R+d)
        {
            cout<<a[i]<<' ';
            sayac++;
        }
    }
    cout<<"\n\nSayac : "<<sayac;
    return 0;
}
