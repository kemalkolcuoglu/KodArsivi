#include<iostream>
using namespace std;
int main()
{
    int sayi1,sayi2; char islem;
    cout<<"\t\t...Hesap Makinesi Sistemine Hosgeldiniz..."
        <<"\n\nSayi Giriniz: ";
    cin>>sayi1;
    cout<<"Sayi giriniz: ";
    cin>>sayi2;
    cout<<"Islem giriniz: ";
    cin>>islem;
    cout<<endl;
    switch(islem)
    {
    case '+':
        cout<<sayi1<<islem<<sayi2<<'='<<sayi1+sayi2;
        break;
    case '-':
        cout<<sayi1<<islem<<sayi2<<'='<<sayi1-sayi2;
        break;
    case '*':
        cout<<sayi1<<islem<<sayi2<<'='<<sayi1*sayi2;
        break;
    case '/':
        cout<<sayi1<<islem<<sayi2<<'='<<sayi1/sayi2;
        break;
    default:
        cout<<"Lutfen (+,-,*,/) islemlerinden birini seciniz...";
    }
    return 0;
}
