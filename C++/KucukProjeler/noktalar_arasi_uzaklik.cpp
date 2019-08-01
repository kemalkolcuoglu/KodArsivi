#include<iostream>
#include<math.h>
using namespace std;
double Uzaklik(double,double,double,double);
int main()
{
double x1,x2,y1,y2,d;
cout<<"A noktasinin apsisi:"<<endl;
cin>>x1;
cout<<"A noktasinin ordinati:"<<endl;
cin>>y1;
cout<<"B noktasinin apsisi:"<<endl;
cin>>x2;
cout<<"B noktasinin ordinati:"<<endl;
cin>>y2;
d=Uzaklik(x1,x2,y1,y2);
cout<<"iki nokta arasi uzaklik="<<d<<"dir";
return 0;
}
double Uzaklik(double a1,double a2,double b1,double b2)
{
double uzaklik;
uzaklik=sqrt(pow((a1-a2),2)+pow((b1-b2),2));
return uzaklik;
}
