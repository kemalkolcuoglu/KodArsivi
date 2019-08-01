#include<iostream>
#include<conio.h>
using namespace std;
//=======================================================================
bool artik_yil(unsigned short y)
{
	bool durum=0;
	if(y%4==0)
		durum=1;
	return durum;
}

bool kontrol(unsigned short g,unsigned  short a,unsigned  short y)
{
	bool durum=0;
	if( (g<1 || g>31) || (a<1 || a>12) || (y<1900) )
		cout<<"Dogru deger giriniz..."<<endl;
	else if((a<=7 && a%2==0 && g>30) || (a>=8 && a%2==1 && g>30))
		cout<<"Dogru deger giriniz..."<<endl;
	else
		durum=1;
	return durum;
}

int hesap(unsigned short g,unsigned short a,unsigned short y)
{
	unsigned short yil=y;
	int t_gun=0;
	t_gun+=g;
	for(int j=1;j<=a;j++)
	{
		if(j==2)
		{
			if(artik_yil(yil)==1)
				t_gun+=29;
			else
				t_gun+=28;
		}
		else if((j<=7 && j%2==1) || (j>=8 && j%2==0))
			t_gun+=31;
		else
			t_gun+=30;
	}
	yil--;
	for(int i=yil;i>0;i--)
	{
		for(int j=1;j<=12;j++)
		{
			if(j==2)
			{
				if(artik_yil(y)==1)
					t_gun+=29;
				else
					t_gun+=28;
			}
			else if((j<=7 && j%2==1) || (j>=8 && j%2==0))
				t_gun+=31;
			else
				t_gun+=30;
		}
	}
	return t_gun;
}

int yazdir(int d1,int d2)
{
	int sayi;
	d1<d2 ? sayi=d2-d1 : sayi=d1-d2;
	cout<<"Toplam "<<sayi<<" gun gecmistir..."<<endl;
	if(sayi<365)
		cout<<"Iki Tarih arasinda "<<sayi<<" gun fark vardir."<<endl;
	else
		cout<<"Iki Tarih arasinda "<<sayi/365<<" yil "<<sayi%365<<" gun fark vardir."<<endl;
	return sayi;
}

int main()
{
	unsigned short gun,ay,yil;
	int deger1,deger2;
	char karar;
	bas1:
	cout<<"Bir Tarih Giriniz : ";
	cin>>gun>>ay>>yil;
	
	if(kontrol(gun,ay,yil)==1)
		deger1=hesap(gun,ay,yil);
	else
	{
		kontrol(gun,ay,yil);
		goto bas1;
	}
	bas2:
	cout<<"Bir Tarih Daha Giriniz : ";
	cin>>gun>>ay>>yil;
	
	if(kontrol(gun,ay,yil)==1)
		deger2=hesap(gun,ay,yil);
	else
	{
		kontrol(gun,ay,yil);
		goto bas2;
	}
	yazdir(deger1,deger2);
	
	cout<<"\n\nYeniden hesaplamak ister misiniz? (E/H) -> ";
	cin>>karar;
	
	if(karar=='E'||karar=='e')
	{
		system("CLS");
		goto bas1;
	}
	else
		return 0;
	
    getch();
    return 0;
}
