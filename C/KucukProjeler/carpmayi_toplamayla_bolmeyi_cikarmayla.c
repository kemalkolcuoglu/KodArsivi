/*	Carpimi Toplama ile, Bolme Cikarma ile Yapmak	*/
#include<stdio.h>
#include<conio.h>
int main()
{
	int sayi1,sayi2,i,toplam=0,bolunen,bolmeSonuc=0;
	
	printf("Sayi Giriniz : ");					//	Birinci Sayi Tanimlanir
	scanf("%d",&sayi1);
	printf("Sayi Giriniz : ");					//	Ikinci Sayi Tanimlanir 
	scanf("%d",&sayi2);
	for(i=1;i<=sayi1;i++)						//	Girilen Birinci Sayiyi Kosul Olarak Belirleriz
	{
		toplam+=sayi2;							//	Ikinci Sayiyi Birinci sayi kadar toplatiriz
	}
	printf("\nCarpim : %d",toplam);				//	Carpim Elde Edilir ve Yazdirilir

    bolunen=sayi1;								//	Birinci Sayi Bolunen olarak alinir	
    for(i=1;bolunen>0;i++)						//	Bolunen 0'a esit oldugu anda dongu sona erer
    {
    	bolunen-=sayi2;							//	Ikinci sayi bolunenden cikartilir
    	bolmeSonuc++;							//	Her cikartma bir kat olarak belirlenir
	}
	printf("\nBolme Sonuc : %d",bolmeSonuc);	//	Ekrana yazdirilir
    getchar();
    return 0;
}

