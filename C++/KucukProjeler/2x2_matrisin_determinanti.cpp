//2x2 Matrisin Determinanti
#include<iostream>
using namespace std;
int main()
{
    int a[4];
    for(int i=0;i<4;i++)
    {
        cout<<"Sayi giriniz -> ";
        cin>>a[i];
    }
    cout<<endl;
    int toplam=0;
    toplam=(a[0]*a[3])-(a[1]*a[2]);
    for(int i=0;i<4;i++)
    {
        cout<<a[i]<<' ';
        if(i%2==1)
        {
            cout<<"\n";
        }
    }
    cout<<"\n(("<<a[0]<<"*"<<a[3]<<')'<<"-"<<'('<<a[1]<<"*"<<a[2]<<"))"<<"="<<toplam;
    return 0;
}
/*int f(int a[4])
{
    return a[0]*a[3]-a[1]*a[2];
}
int main()
{
    int a[4];
    cout<<"Lutfen 2x2'lik Deterninant Icin Sayilar Giriniz... \n";
    for(int i=0;i<4;i++)
    {
        cout<<"Sayi : ";
        cin>>a[i];
    }
    cout<<"\nDeterminant Toplami : "<<f(a)<<endl;
    return 0;
}
Esiti

int main()
{
    int a[4];
    for(int i=0;i<4;i++)
    {
        cout<<"Sayi giriniz -> ";
        cin>>a[i];
    }
    cout<<endl;
    int toplam=0;
    toplam=(a[0]*a[3])-(a[1]*a[2]);
    cout<<"Toplam = "<<toplam;
    return 0;
}

*/
