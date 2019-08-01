/*Carpim tablosu uygulamasi*/
#include<iostream>
using namespace std;

int main ()
{
    int sayi;
    cout<<"Bir sayi giriniz: ";
    cin>>sayi;
    cout<<endl;
    for(int i=1; i<=10; i++)
    {
        cout<<sayi<<'*'<<i<<'='<<sayi*i<<endl;
    }

    return 0;
}
