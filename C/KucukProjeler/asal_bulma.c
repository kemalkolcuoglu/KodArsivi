/*Girilen sayiya kadar olan sayilarin asal olup olmadigini bulan uygulama*/

#include<stdio.h>
#include<conio.h>
int main()
{
	int i,j,sayi,sayac=0;
	printf("Bir Sayi Giriniz -> "); //Sinir Noktasi Belirlenir...
	scanf("%d",&sayi);
	printf("________________________\n\n");
	for(i=2;i<=sayi;i++) // Dongu 2 Sayisindan Baslar Cunku En Kucuk Asal Sayi 2'dir...
	{
		for(j=2;j<i;j++)
			if(i%j==0)
			{	sayac++; break; } //1. Dongudeki Sayi 2. Dongudeki Herhangi Sayiya Bolunuyorsa sayac artar
		if(sayac==0)
			printf("%d Sayi Asaldir...\n",i);
		else
			printf("%d Sayi Asal Degildir...\n",i);
		sayac=0; //Sayaci Sifirliyoruz ki dongu basa sardiginde sayac dogru calissin...
	}
    getchar();
    return 0;
}
