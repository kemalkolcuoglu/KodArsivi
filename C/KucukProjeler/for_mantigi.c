/*	Ic Ice For Dongusunun Calisma Prensibi */
#include<stdio.h>
#include<conio.h>
int main()
{
	int i,j,k;
	for(i=1;i<=3;i++)
	{
		printf("1. Dongunun Baslangici\n");
		for(j=1;j<=i;j++)
		{
			printf("\t2. Dongunun Baslangici\n");
			for(k=1;k<i+j;k++)
			{
				printf("\t\t3. Dongu Komutlari\n");
			}
			printf("\t2. Dongunun Sonu\n");
		}
		printf("1. Dongunun Sonu\n\n");
	}
    getchar();
    return 0;
}

// Aciklamaya Deger Bisey Bulamadim :D Zaten dongu komutlari herseyi anlatiyor...
