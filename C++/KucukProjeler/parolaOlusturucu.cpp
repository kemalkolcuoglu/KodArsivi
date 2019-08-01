#include<stdio.h>
#include<stdlib.h>
#include<time.h>
int main()
{
    srand(time(NULL));
    int rakam;

    rakam = 65+rand()%25;
    printf("%c",rakam);
    rakam = 97+rand()%25;
    printf("%c",rakam);
    rakam = 10+rand()%100;
    printf("%d",rakam);
    rakam = 97+rand()%25;
    printf("%c",rakam);
    rakam = 10+rand()%100;
    printf("%d",rakam);
    rakam = 97+rand()%25;
    printf("%c",rakam);
    rakam = 65+rand()%25;
    printf("%c\n",rakam);

    return 0;
}
