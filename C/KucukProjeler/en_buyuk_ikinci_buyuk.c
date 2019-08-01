/*	En Buyuk ve En Buyuk 2. Sayi */
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
int main()
{
	int i,dizi[10],max,max2;
	srand(time(NULL));
	for(i=0;i<10;i++)
		dizi[i]=1+rand()%100;
	max=dizi[0];
	max2=dizi[0];
	for(i=0;i<10;i++)
	{
		if(dizi[i]>max)
		{
			max2=max;
			max=dizi[i];
		}
		else if(dizi[i]>max2)
			max2=dizi[i];
	}
	printf("En Buyuk Sayi : %d\nEn Buyuk 2. Sayi : %d\n\n\n",max,max2);
	for(i=0;i<10;i++)
		printf("// %d ",dizi[i]);
    getchar();
    return 0;
}

