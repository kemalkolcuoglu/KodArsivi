#include<iostream>
using namespace std;
int main()
{
    int yil,ay,gun,b_gun=3,b_ay=2,b_yil=2016,toplam=0;
    cout<<"Dogum tarihinizi giriniz: ";
    cin>>gun>>ay>>yil;
    cout<<"Bugunun tarihini giriniz: ";
    cin>>b_gun>>b_ay>>b_yil;
    if(b_gun<gun)
    {
        b_gun+=30;
        b_ay--;
    }
    gun=b_gun-gun;
    if(b_ay<ay)
    {
        b_ay+=12;
        b_yil--;
    }
    ay=b_ay-ay;
    yil=b_yil-yil;
    cout<<endl<<yil<<" yil "<<ay<<" ay "<<gun<<" gundur yasiyorsunuz!";
    toplam=gun+(ay*30)+(yil*365);
    cout<<endl<<"Toplam "<<toplam+9<<" gun kadar yasamissiniz!";
    return 0;
}
