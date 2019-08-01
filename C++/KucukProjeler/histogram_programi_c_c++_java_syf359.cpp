#include <cstdlib>
#include <iostream>
#include <windows.h>
#include <conio.h>
using namespace std;
int main()
{
    int N;
    cout<<"Sayi Sayisi Giriniz : ";
    cin>>N;
    int dizi[N];
    for(int i=0;i<N;i++)
    {
        dizi[i]=1+rand()%30;
    }
    for(int i=0;i<N;i++)
    {
        cout<<i+1<<". Sayi : "<<dizi[i]<<'\t';
        for(int j=1;j<=dizi[i];j++)
        {
            cout<<'*';
        }
        cout<<endl;
    }
    system("PAUSE");
    return EXIT_SUCCESS;
}
