#include<iostream>
using namespace std;
int main()
{
    int a,fak=1;

    cout<<"Bir sayi giriniz: ";
    cin>>a;
    cout<<endl;

    for(int i=1;i<=a;i++)
    {
        for(int f=1;f<=i;f++)
        {
            fak*=f;
        }
        cout<<i<<'!'<<'='<<fak<<endl;
        fak=1;
    }

    return 0;
}
