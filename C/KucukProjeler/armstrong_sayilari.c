#include<stdio.h>
#include<conio.h>
int main()
{
	int sayi,a,b,c,kup;
	for(a=1;a<=9;a++)
		for(b=0;b<=9;b++)
			for(c=0;c<=9;c++)
			{
				sayi=100*a+10*b+c;
				kup=a*a*a+b*b*b+c*c*c;
				if(sayi==kup)
					printf("Sayi : %d\n",sayi);
			}
    getchar();
    return 0;
}
