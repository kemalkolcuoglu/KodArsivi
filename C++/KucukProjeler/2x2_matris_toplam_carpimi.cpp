//Girilen Iki Matrisin Toplami ve Carpimi
#include<iostream>
using namespace std;
int main()
{
    int a[2][2],b[2][2],c[2][2]={0,0,0,0},d[2][2]={0,0,0,0};
    cout<<"a Matrisinin Degerlerini Giriniz : \n";
    for(int i=0;i<2;i++)
        for(int j=0;j<2;j++)
        {
            cout<<"a["<<i+1<<"]["<<j+1<<"] = "; cin>>a[i][j];
        }
    cout<<endl<<"b Matrisinin Degerlerini Giriniz : \n";
    for(int i=0;i<2;i++)
        for(int j=0;j<2;j++)
        {
            cout<<"b["<<i+1<<"]["<<j+1<<"] = "; cin>>b[i][j];
        }
    cout<<endl<<"a Matrisi : \n";
    for(int i=0;i<2;i++)
        for(int j=0;j<2;j++)
        {
            cout<<a[i][j]<<' ';
            if(i==2|j==1)
                cout<<endl;
        }
    cout<<endl<<"b Matrisi : \n";
    for(int i=0;i<2;i++)
        for(int j=0;j<2;j++)
        {
            cout<<b[i][j]<<' ';
            if(i==2|j==1)
                cout<<endl;
        }
    cout<<endl<<"a+b Matrisi : \n";
    for(int i=0;i<2;i++)
        for(int j=0;j<2;j++)
        {
            c[i][j]=a[i][j]+b[i][j];
        }
    for(int i=0;i<2;i++)
        for(int j=0;j<2;j++)
        {
            cout<<c[i][j]<<' ';
            if(i==2|j==1)
                cout<<endl;
        }
    d[0][0]=(a[0][0]*b[0][0])+(a[0][1]*b[1][0]);
    d[0][1]=(a[0][0]*b[0][1])+(a[0][1]*b[1][1]);
    d[1][0]=(a[1][0]*b[0][0])+(a[1][1]*b[1][0]);
    d[1][1]=(a[1][0]*b[0][1])+(a[1][1]*b[1][1]);
    cout<<endl<<"a*b Matrisi : \n";
    for(int i=0;i<2;i++)
        for(int j=0;j<2;j++)
        {
            cout<<d[i][j]<<' ';
            if(i==2|j==1)
                cout<<endl;
        }
    return 0;
}
