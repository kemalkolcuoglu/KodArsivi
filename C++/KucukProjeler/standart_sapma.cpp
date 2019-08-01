//Standart Sapma Gosterimi
#include<iostream>
#include<cmath>
using namespace std;
int main()
{
    int N,toplam=0;
    cout<<"Dizi Icin Sayi Sayisi Giriniz -> ";
    cin>>N;
    int a[N];
    cout<<endl;
    for(int i=0;i<N;i++)
    {
        cout<<"a["<<i+1<<"] = ";
        cin>>a[i];
        toplam+=a[i];
    }
    float ortalama=float (toplam)/N;
    float toplamF=0;
    for(int i=0;i<N;i++)
        toplamF+=pow(a[i]-ortalama,2);
    cout<<"\nStandart Sapma : "<<sqrt(toplamF/N)<<endl;
    return 0;
}
