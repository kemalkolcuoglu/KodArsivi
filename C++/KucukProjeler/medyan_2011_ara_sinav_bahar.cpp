#include<iostream>
#include<cmath>
#include<stdio.h>
using namespace std;

int main()
{
    int N, *degerler,tmp;
    cout << "N: " ;
    cin>>N;
    degerler=new int(N);
    cout<<"Sayilar:"<<endl;
    for(int i=0; i<N; i++)
    {
        cin>>*(degerler+i);
        for (int j=0; j<i; j++)
            if(*(degerler+i)<*(degerler+j))
            {
                tmp=*(degerler+i);
                *(degerler+i)=*(degerler+j);
                *(degerler+j)=tmp;
            }
    }
    cout<<"**************************"<<endl;
    cout<<"Sayilarin siralanmis hali"<<endl;
    for(int i=0; i<N; i++)
        cout<< *(degerler+i)<<endl;
    cout<<"**************************"<<endl;
    if (N%2!=0)
        cout<<"Medyan = "<<*(degerler+((N)/2))<<endl;
    else
        cout<<"Medyan = "<<(float)(*(degerler+(N/2))+*(degerler+((N-1)/2)))/2<<endl;
    return 0;
}
