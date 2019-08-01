#include<iostream>
using namespace std;
int main()
{
    string s1="Merhaba Dunya",s2("Bugun hava cok guzel"),s3="aeiou";

    for(int i=0;i<s1.length();i++)
    {
        if(s1[i]==' ')
            cout<<endl;
        else
            cout<<s1[i];
    }
    cout<<endl<<endl;
    cout<<s2<<endl;
    for(int j=0;j<s2.length();j++)
    {
        for(int k=0;k<s3.length();k++)
        {
            if(s2[j]==s3[k])
                s2[j]='*';
        }
        if(s2[j]==' ')
            cout<<endl;
        else
            cout<<s2[j];
    }
    cout<<endl<<endl;

    for(int l=s2.length()-1;0<=l;l--)
    {
        cout<<s2[l];
    }

    return 0;
}
