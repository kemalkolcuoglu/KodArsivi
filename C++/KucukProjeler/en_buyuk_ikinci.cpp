//Girilen Sayilar Arasindaki En Buyuk 2. Sayiyi Bulan Uygulama
#include<iostream>
using namespace std;
int main()
{
    int sayi=0;
    int d[100];
    do{
        cout<<"Sayi Giriniz -> ";
        cin>>d[sayi];
        if(d[sayi]<=0|sayi==99)
            break;
        sayi++;
    }while(true);
    cout<<"Eleman Sayisi : "<<sayi<<endl;
    int max1=d[0],max2;
    for(int i=1;i<sayi;i++)
    {
        if(d[i]>max1)
        {
            max2=max1;
            max1=d[i];
            continue;
        }
        if(i==1)
            max2=d[i];
        else if (d[i]>max2)
            max2=d[i];
    }
    cout<<"En Buyuk Deger -> "<<max1<<endl
        <<"Ikinci Buyuk Deger -> "<<max2<<endl;
    return 0;
}
