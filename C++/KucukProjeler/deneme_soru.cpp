/*1'den 75'e kadar olan cift sayilarin karelerinin toplamini veren uygulama*/
#include<iostream>
using namespace std;
int main()
{
    int i=1,top=0,carp=0;
    for( ;i<=75;i++)
    {
        if(i%2==0)
        {
            carp=(i*i);
            top+=carp;
        }
        carp=1;
    }
    cout<<top;

    //Cevap 70300
    return 0;
}
