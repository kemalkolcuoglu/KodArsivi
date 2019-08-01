/** Takvim **/

#include<iostream>
#include<conio.h>
using namespace std;
//=======================================================================
bool artik_yil(unsigned short yil)
{
	bool durum=0;
	if(yil%4==0)
		durum=1;
	return durum;
}
unsigned short songun(unsigned short ay)
{
	unsigned short songun;
	if(ay==2)
	{
		if(artik_yil(2016)==1)
			songun=29;
		else
			songun=28;
	}
	else if((ay<=7 && ay%2==0) || (ay>=8 && ay%2==1))
		songun=30;
	else
		songun=31;
	return songun;
}
void cizim(unsigned short yil)
{
	unsigned short ilkgun=4;
	unsigned short i=1;
	unsigned short songun;
	songun = songun(i);
	for(i=1;i<=12;i++)
	{
		
		switch (i)
		{
			case 1:  cout<<"| 		OCAK 		|\n";	break;
			case 2:  cout<<"| 		SUBAT 		|\n";	break;
			case 3:  cout<<"| 		MART 		|\n";	break;
			case 4:  cout<<"| 		NISAN 		|\n";	break;
			case 5:  cout<<"| 		MAYIS 		|\n";	break;
			case 6:  cout<<"| 		HAZIRAN 	|\n";	break;
			case 7:  cout<<"| 		TEMMUZ 		|\n";	break;
			case 8:  cout<<"| 		AGUSTOS 	|\n";	break;
			case 9:  cout<<"| 		EYLUL 		|\n";	break;
			case 10: cout<<"| 		EKIM 		|\n";	break;
			case 11: cout<<"| 		KASIM 		|\n";	break;
			default: cout<<"| 		ARALIK 		|\n";	break;
		}
		cout<<" _______________________________\n"
			<<"|Pzrt|Sali|Cars|Pers|Cuma|Cmrt|Pazr|\n\n";
		for(int k=ilkgun;k>0;k--)
			cout<<"  ";
		for(int j=1;j<=songun;j++)
		{
			if((ilkgun+j)%7==0)
				cout<<endl;
			cout<<j<<"|  ";
		}
		cout<<endl<<endl;
	}
}
int main()
{
	unsigned short yil;
	cout<<"Yil Giriniz : ";
	cin>>yil;
	cizim(yil);
    getch();
    return 0;
}
