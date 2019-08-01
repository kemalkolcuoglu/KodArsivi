/*Girilen sayiya kadar olan cift sayilerin toplamini bulan uygulama*/

#include<iostream>
using namespace std;
int main()
{
    int N, sayac=0, toplam=0;
    cout<<"Lutfen bir sayi giriniz: ";
    cin>>N;

    for (int i=0; i<=N; i++)
    {
        if(i%2==0)
        {   toplam+=i;  }
    }
    cout<<"\nCift sayilarin toplami= "<<toplam;
    return 0;
}
