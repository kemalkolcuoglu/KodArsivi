#include<iostream>
using namespace std;
int main ()
{
    int sayi;
    cout<<"Bir sayi giriniz: ";
    cin>>sayi;
    for(int i=0;i<=sayi;i++)
    {
        for(int j=0;j<i;j++)
        {
            cout<<'*';
        }
        for(int k=0;k<2*sayi-i*2;k++)
        {
            cout<<' ';
        }
        for(int t=0;t<i;t++)
        {
            cout<<'*';
        }
        cout<<endl;
    }
    return 0;
}
