#include <stdio.h>

int main()
{
    int i, j, numbers, max = 0;
    
    printf("Enter number of numbers -> ");
    scanf("%d",&numbers);
    
    int arr[numbers];
    for(i=0; i<numbers; i++)
    {
        printf("Enter value -> ");
        scanf("%d", &arr[i]);
        
        if(max < arr[i])
        {
            max = arr[i];
        }
    }
    
    int sparse[max+1] = {0};
    
    for(i=0; i<max+1; i++)
    {
        for(j=0;j<numbers;j++)
        {
          if(arr[j] == i)
          {
            sparse[arr[j]] = 1;    
          }
        }
    }
    
    for(i=0; i<max+1;i++)
    {
        printf("%d -> ", sparse[i]);
    }
    
    return 0;
}