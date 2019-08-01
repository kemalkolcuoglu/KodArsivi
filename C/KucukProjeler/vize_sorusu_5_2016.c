#include<stdio.h>
#include<conio.h>

int main()
{
	int dizi[4]={1,2,3,4};
	int i=0,adim=0,yedek;
	while(adim<4)
	{
		printf("%d ",dizi[i]);	i++;
		if(i==4)
		{
			yedek=dizi[0];
			for(i=0;i<3;i++)
			{
				dizi[i]=dizi[i+1];
			}
			i=0;	adim++;		printf("\n");
			dizi[3]=yedek;
		}
		else
			continue;
	}

    getchar();
    return 0;
}

