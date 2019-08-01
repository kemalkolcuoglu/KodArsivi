/*	Sayiyi Basamaklarina Ayirma ve Basamaklarini Toplamak	*/
#include<stdio.h>
#include<conio.h>
int main()
{
	/*
	
	int sayi,sayac[100],i=1,basamakSayisi=0,toplam=0,a=0;		
    printf("Bir sayi giriniz : ");
    scanf("%d",&sayi);
    printf("\n");
    while(1)
    {
        if(sayi>i)									//	i sayisi 10^n olarak kullanilacagi icin sayidan
            i=i*10;									//	buyuk olana kadar 10 ile carpilir
        else
            break;
    }
    i=i/10;											//	Sayiyla ayni basamaga sahip olmasi icin bu islem onemli !!!
    
	for(a=0;basamakSayisi<i||i<sayi;i/=10,a++,basamakSayisi++)
    {												//	a : Basamaktaki rakam, Sart sayinin i'den buyuk olmasi, i her adimda 10'a bolunur 
		if(sayi==0)
			continue;								
        sayac[a]=sayi/i;							//	Basamaktaki sayi sayac[a] 'ya aktarilir
        sayi=sayi%i;								//	Sayi bir basamak azaltilir
        toplam+=sayac[a];							//	Basamaklari toplayacagimiz icin sayac[a] icindeki sayi toplanir
        printf("%d*%d + ",sayac[a],i);
    }
    printf("\n\nBasamak Toplamlari : %d",toplam);
    printf("\nBasamak Sayisi : %d",basamakSayisi);
    
	*/

    int sayi=0,toplam=0;
    
    printf("Sayi Giriniz : ");
    scanf("%d",&sayi);

	while(sayi!=0)
	{
		toplam+=sayi%10;
		printf("%%Sayi : %d\n",sayi);
		sayi/=10;
		printf("//Sayi : %d\n",sayi);
	}
	printf("Basamak Toplami : %d",toplam);
	
    getchar();
    return 0;
}

