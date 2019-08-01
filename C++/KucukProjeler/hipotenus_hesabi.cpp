/*Ucgenin hipotenusunu bulan uygulama*/

#include<iostream>
#include<cmath>
using namespace std;

int main()
{
    cout<<"Bir Dik Ucgen Dusunelim. Alanini Hesaplayiniz.."<<endl<<endl;
    float a,b,c,d;
    cout<<"A degeri giriniz: ";
    cin>>a;
    cout<<"B degeri giriniz: ";
    cin>>b;
    c=(a*b)/2;
    d=sqrt(a*a+b*b);
    cout<<"Ucgenin Alani: "<<c<<endl;
    cout<<"Hipotenus: "<<d;
    return 0;
}
