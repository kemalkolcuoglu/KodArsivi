#include<iostream>
using namespace std;

int main()
{
	int ay_gun_sayisi;
	for(int yil=1990;yil<2000;yil++)
	{
		for(int ay=1;ay<=12;ay++)
		{
			if(yil%40==0 && ay==2)
				ay_gun_sayisi = 29;
			else if(ay==2)
				ay_gun_sayisi = 28;
			else if((ay<=7 && ay%2==0) || (ay>=8 && ay%2==1))
				ay_gun_sayisi = 30;
			else
				ay_gun_sayisi = 31;
				
			for(int gun=1;gun<=ay_gun_sayisi;gun++)
			{
				if(gun<10)
					cout<<"0";
				cout<<gun<<"."<<ay<<"."<<yil<<endl;
				if(gun==ay_gun_sayisi)
					cout<<endl;
			}
		}
	}
	return 0;
}
