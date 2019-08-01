#include<iostream>
#include<conio.h>
using namespace std;

void dikdortgen(int a,int b)
{
	for(int i=1;i<=a;i++)
	{
		if( i==1 || i==a )	
			for(int j=1;j<=b;j++)
				cout<<"*\t";
		else
			for(int j=1;j<=b;j++)
			{
				if( j==1 || j==b )
					cout<<"*\t";
				else
					cout<<'\t';
			}
		cout<<endl<<endl;
	}
}

int main()
{
	int kenar1,kenar2;
	cout<<"Dikey Kenari Giriniz : ";
	cin>>kenar1;
	cout<<"Yatay Kenari Giriniz : ";
	cin>>kenar2;
	
	dikdortgen(kenar1,kenar2);
	return 0;
}
