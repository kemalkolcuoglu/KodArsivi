/*	Fibonacci Sayilari */
#include<stdio.h>
#include<conio.h>
int main()
{
	int sayi,i=1,j=2,k,b=0,toplam=0;
	printf("Bir Sayi Giriniz : ");
	scanf("%d",&k); printf("\n\n");
    while(b<k)
    {
        sayi=i+j;
        printf("%d ",i);
        i=j;
        j=sayi;
        b++;
        toplam+=sayi;
    }
    printf("\n\nToplam : %d",toplam);
    getchar();
    return 0;
}
