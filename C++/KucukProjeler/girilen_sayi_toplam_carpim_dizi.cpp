#include<iostream>
#include<cmath>
#include<stdio.h>
using namespace std;
int main()
{
    int N=0;
    cout<<"Sayi Sayisi Giriniz -> ";
    cin>>N;
    int a[N];
    int carpim=1,toplam=0;float ortalama=0;
    for(int i=0;i<N;i++)
    {
        cout<<"a["<<i+1<<"] = ";
        cin>>a[i];
        toplam+=a[i]; carpim*=a[i];
    }
    ortalama=float(toplam)/N;
    cout<<"\nToplam = "<<toplam<<endl
        <<"Carpim = "<<carpim<<endl
        <<"Ortalama = "<<ortalama<<endl;
    return 0;
}
