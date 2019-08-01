#include <iostream>
#include <windows.h>
using namespace std;
int main()
{
    int sayi;
    while(sayi>9||sayi<1)
    {
        cout<<"Bir Sayi Giriniz : ";
        cin>>sayi;
    }
    cout<<"\n";
    for(int i=1;i<=sayi;i++)
    {
        for(int k=0;k<i;k++)
        {
            cout<<' ';
        }
        for(int j=1;j<=sayi;j++)
        {
            cout<<i;
        }
        cout<<'*'<<endl;

    }
    system("PAUSE");
    return EXIT_SUCCESS;
}
