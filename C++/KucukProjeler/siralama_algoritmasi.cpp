/******************************************************
*******************    Siralama     *******************
*******************   Algoritmasi   *******************
******************************************************/
#include<iostream>
using namespace std;
int main()
{
    int N=0,duzen=0;
    cout<<"N Degeri Giriniz : ";
    cin>>N;
    cout<<endl;
    int dizi[N];
    for(int i=0;i<N;i++)
    {
        cout<<i+1<<". Sayiyi Giriniz : ";
        cin>>dizi[i];
    }
    for(int i=0;i<N;i++)
    {
        for(int j=i+1;j<N+1;j++)
        {
            if(dizi[i]>dizi[j])
            {
                duzen=dizi[i];
                dizi[i]=dizi[j];
                dizi[j]=duzen;
            }
        }
    }
    cout<<"\nDuzenlenmis Hali\n____________________________\n";
    for(int i=0;i<N;i++)
        cout<<dizi[i]<<", ";
    return 0;
}
