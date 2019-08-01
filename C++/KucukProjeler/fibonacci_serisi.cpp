/******************************************************
********************    Fibonacci   *******************
********************      Serisi    *******************
******************************************************/
#include<iostream>
using namespace std;
int main()
{
    int sayi[20];
    sayi[0]=1;
    sayi[1]=2;
    for(int i=2;i<22;i++)
    {
        cout<<sayi[i-2]<<endl;
        sayi[i]=sayi[i-1]+sayi[i-2];
    }
    return 0;
}
