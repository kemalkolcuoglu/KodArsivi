//ASCII Kod Sorgulama

#include<stdio.h>
#include<conio.h>
int main()
{
	printf("...::: ASCII KOD TABLOSU :::...\n\n");
	short c,sayi;
	/*for(c=0;c<256;c++)
		printf("%d. Karakter : %c\n",c+1,c);	//%d hangi sayi oldugunu gosteriyor. %c ASCII karsiligini gösteriyor...*/
	
	printf("Bir Sayi Giriniz : ");
	scanf("%d",&sayi);
	
	printf("%d Sayisinin ASCII Karsiligi : %c",sayi,sayi);
	
    getchar();
    return 0;
}
