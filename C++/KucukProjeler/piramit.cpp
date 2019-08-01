#include<iostream>
using namespace std;
int main()
{
    int a;
    cout<<"Bir sayi giriniz: ";
    cin>>a;
    for(int i=0;i<=a;i++)
    {
        for(int k=1;k<=a-i;k++)
        {
            cout<<' ';
        } 
        for(int j=1;j<=i*2-1;j++)
        {
            cout<<'*';
        }
        cout<<endl;
    }
    return 0;
}
