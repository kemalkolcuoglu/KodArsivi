/*	Girilen Sayiya KadarToplam ve Carpim Sembolu */
#include<stdio.h>
#include<conio.h>
int main()
{
	int i,sayi,toplam=0, carpim=1;	/*DIKKAT! toplam=0 ve carpim=1 atamakari mutlaka yapilmalidir. Carpim mutlaka 0'dan farkli olmalirdir...
									Yoksa PC kafadan degerler verir ve yanlis deger elde edilir...	*/
	printf("Bir Sayi Giriniz -> ");	//Sinir sayisi belirleniyor
	scanf("%d",&sayi);
	for(i=1;i<=sayi;i++)
	{
		toplam+=i;
		carpim*=i;
	}
	printf("Sayilarin Toplami : %d\n",toplam);
	printf("Sayilarin Carpimi : %d\n",carpim);
    getchar();
    return 0;
}
/*	Carpim Sembolu 17'den sonra kafayi yiyor DIKKAT! :D	*/
