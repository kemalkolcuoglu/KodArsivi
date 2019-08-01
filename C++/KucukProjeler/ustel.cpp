#include<iostream>
#include<math.h>
using namespace std;
double Ustel(double,double);
int fact(int);
int main()
{
double a,m,sonuc;
cout<<"e'nin derecesini giriniz=";
cin>>a;
cout<<"m'nin degerini giriniz=";
cin>>m;
sonuc=Ustel(a,m);
cout<<"ifadenin degeri="<<sonuc<<"dir";
return 0;
}
int fact(int x)
{
int k,d;
d=1;
for(k=1;k<=x;k++)
d=d*k;
return d;
}
double Ustel(double x,double n)
{
int i;
double ustel=0;
for(i=0;i<=n;i++)
{
int fakt;
fakt=fact(i);
ustel=ustel+(pow(x,i)/fakt);
}
return ustel;
}

