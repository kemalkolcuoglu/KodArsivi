/*	1 ile 9 ararsinda girilen sayi kadar rakam ve bosluk yazdirma */
#include<stdio.h>
#include<conio.h>
int main()
{
	int sayi,i,j,k;
    while(sayi>9||sayi<1)	//Sayi 1 ile 9 arasinda olmali
    {
        printf("Bir Sayi Giriniz : ");
        scanf("%d",&sayi);
    }
    printf("\n");
    for(i=1;i<=sayi;i++)
    {
        for(k=0;k<i;k++)	//i kadar bosluk
        {
            printf(" ");
        }
        for(j=1;j<=sayi;j++)	//Girilen sayi kadar rakam
        {
            printf("%d",i);
        }
        printf("*\n";	//Alt satira gecis
    }
    getchar();
    return 0;
}
