#include <cstdlib>
#include <iostream>
#include <windows.h>
#include <conio.h>
#include <time.h>
using namespace std;
int main()
{
    unsigned int tahmin[6],sayi[6],sayac=0;
    srand(time(NULL));
    for(int i=0;i<6;i++)
        sayi[i]=1+rand()%49;
    cout<<"Lutfen Sayilari Giriniz... "<<endl<<endl;
    for(int i=0;i<6;i++)
    {
        cout<<i+1<<". Sayi : ";
        cin>>tahmin[i];
    }
    cout<<"\n\n";
    for(int i=0;i<6;i++)
    {
        if(sayi[i]==tahmin[i])
        {
            sayac++;
            cout<<i+1<<". Sayiyi Dogru Tahmin Ettiniz -> "<<sayi[i]<<endl;
        }
        else if(sayi[i]!=tahmin[i])
        {
            cout<<i+1<<". Sayiyi Yanlis Tahmin Ettiniz -> "<<sayi[i]<<endl;
        }
    }
    cout<<"\n\n";
    if(sayac==6) cout<<"Artik Milyonersiniz!..\nKazanilan Para : 1.000.000 TL"<<endl;
    else if(sayac==5) cout<<"Bes Sayiyi Dogru Tahmin Ettiniz!..\nKazanilan Para : 5000 TL"<<endl;
    else if(sayac==4) cout<<"Dort Sayiyi Dogru Tahmin Ettiniz!..\nKazanilan Para : 500 TL"<<endl;
    else if(sayac==3) cout<<"Uc Sayiyi Dogru Tahmin Ettiniz!..\nKazanilan Para : 50 TL"<<endl;
    else if(sayac==2) cout<<"Iki Sayiyi Dogru Tahmin Ettiniz!..\nKazanilan Para : 0 TL"<<endl;
    else if(sayac==1) cout<<"Bir Sayiyi Dogru Tahmin Ettiniz!..\nKazanilan Para : 0 TL"<<endl;
    else cout<<"Hicbir Sayiyi Dogru Tahmin Edemediniz!..\nKazanilan Para : 0 TL"<<endl;
    cout<<"\n\n*****************************\n\n";
    for(int i=0;i<6;i++)
    {
        cout<<sayi[i]<<", ";
    }
    cout<<"\n\n*****************************\n\n";
    system("PAUSE");
    return EXIT_SUCCESS;
}
