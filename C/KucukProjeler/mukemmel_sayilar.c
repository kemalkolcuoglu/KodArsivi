/***** Mukemmel Sayilarin Bulunusu	*****/

/*** Mukemmel Sayi : Carparnlarinin toplaminin kendisine esit olan sayilardir ***/

#include<stdio.h>
#include<conio.h>
//=============================================================================================================================================
int main()
{
	unsigned int bolen=0,b_sayi,k_sayi,sayi;					// Eksili sayilara ihtiyacimiz olmadigi icin "unsigned" etiketi kullanildi
	int i,j,k=0;												// i : Sayi Araligimiz , j : Bolenlerin tespiti, k : Mukemmel Sayi Sayisi
	
	printf("Baslangic Sayisini Giriniz : ");
	scanf("%d",&k_sayi);
	printf("Bitis Sayisini Giriniz : ");
	scanf("%d",&b_sayi);
	
	if(k_sayi>b_sayi)
	{	sayi=k_sayi; k_sayi=b_sayi; b_sayi=sayi;	}			// Eger baslangic bitisten buyukse yerler degistirilir
	
	printf("\n");
	
	for(i=k_sayi; i<b_sayi; i++)
	{
		for(j=1;j<i;j++)
		{
			if(i%j==0)
			{
				bolen+=j;										// Bolenlerin toplamlari istendigi icin j degeri bolene eklenir
			}
		}
		if(bolen==i)											// Bolenlerin Sayiya esit olma durumu
		{
			k++;
			printf("%d Sayisi %d. Mukemmel Sayidir...\n",i,k);
		}
		bolen=0;												// Bolen sýfýrlanmazsa dogru sonuc elde edilemez
	}

    getch();
    return 0;
}
