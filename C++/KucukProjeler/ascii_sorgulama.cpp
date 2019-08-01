//ASCII Kod Sorgulama
#include<iostream>
using namespace std;
int main()
{
    int a=1; string str;
    while(a<100)
    {
        cout<<"Sorgulamak istediginiz karakteri giriniz -> ";
        cin>>str;
        for(int i=0;i<=str.length();i++)
            cout<<str[i]<<" : "<<int(str[i])<<endl;
        a++;
    }
    return 0;
}
