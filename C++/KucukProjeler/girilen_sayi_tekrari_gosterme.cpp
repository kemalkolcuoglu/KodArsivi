//Girilen sayi tekrari gösterme
#include<iostream>
using namespace std;
int main()
{
    int sayac[6]={0,0,0,0,0,0};
    int dizi[10];
    for(int i=0;i<10;i++)
    {
        cout<<i+1<<". Sayi -> ";
        cin>>dizi[i];
        for(int j=1;j<=6;j++)
        {
            if(dizi[i]==j)
                sayac[j-1]++;
        }
    }
    cout<<endl;
    for(int i=0;i<6;i++)
    {
        cout<<"Girilen "<<i+1<<" Sayisi : "<<sayac[i]<<endl;
    }
    return 0;
}
