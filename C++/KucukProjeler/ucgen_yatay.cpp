#include<iostream>
using namespace std;
int main ()
{
    cout<<endl;
    for(int i=0;i<5;i++)
    {
        for(int j=0;j<5;j++)
        {
        	if(j-i==0)
            	cout<<'*';
        }
        cout<<endl;
    }
    /*
    for(int k=0;k<a;k++)
    {
        for(int l=a;l>k;l--)
        {
            cout<<'*';
        }
        cout<<endl;
    }
	*/
    return 0;
}
