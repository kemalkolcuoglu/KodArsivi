#include<iostream>
using namespace std;
int main ()
{
    int a;
    cout<<"Bir sayi giriniz: ";
    cin>>a;
    for(int i=0;i<=a;i++)
    {
        cout<<endl;
        for(int j=a-i;j>0;j--)
        {
            cout<<' ';
        }
        for(int k=0;k<i;k++)
        {
            cout<<'*';
        }
    }
    for(int m=1;m<=a;m++)
    {
        cout<<endl;
        for(int n=1;n<=m;n++)
        {
            cout<<' ';
        }
        for(int h=a;h>m;h--)
        {
            cout<<'*';
        }
    }
    return 0;
}
