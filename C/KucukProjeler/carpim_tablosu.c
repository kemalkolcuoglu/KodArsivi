/*	Carpim Tablosu */
#include<stdio.h>
#include<conio.h>
int main()
{
	int i,j;
	for(i=1;i<=10;i++)
	{
		for(j=1;j<=10;j++)
		{
			printf("%d*%d=%d  ",j,i,i*j);
			if(j==10)
				printf("\n");
		}
	}
	printf("\n\n_____________________________________\n\n");
	for(i=1;i<=10;i++)
	{
		for(j=1;j<=10;j++)
		{
			printf("%d*%d=%d\n",i,j,i*j);
		}
		printf("\n");
	}
    getchar();
    return 0;
}
