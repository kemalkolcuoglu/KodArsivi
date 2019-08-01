#include <cstdlib>
#include <iostream>
#include <windows.h>

using namespace std;

int randomsayi(int aralik)
{
srand(GetTickCount());
int sayi = rand()%aralik;
return sayi;
}
int main(int argc, char *argv[])
{
system("color 1f");

int user_gir_sayi;
int random_gir_sayi;
int user_hak=10;

cout<<"|----------------------------|"<<endl;
cout<<"| Programmed By Serhat |"<<endl;
cout<<"| Sayi Tahmin |"<<endl;
cout<<"|----------------------------|"<<endl;
cout<<""<<endl;
cout<<""<<endl;


random_gir_sayi = randomsayi(100);
sorgu:
cout<<"Hakkiniz : "<<user_hak<<endl;
cout<<""<<endl;

if (user_hak == 0)
{
cout<<"Uzgunum hakkiniz bitti!"<<endl;
system("PAUSE");
return EXIT_SUCCESS;
}

cout<<"1 sayi tahmin ediniz :"<<endl;
cout<<""<<endl;
cin>>user_gir_sayi;

if (user_gir_sayi == random_gir_sayi)
{
cout<<""<<endl;
cout<<"Tebrikler Tahmininiz Dogru !!!"<<endl;
cout<<""<<endl;
}
else if (user_gir_sayi > random_gir_sayi)
{
cout<<""<<endl;
cout<<"Lutfen daha kucuk bir sayi giriniz !!!"<<endl;
cout<<""<<endl;
user_hak=(user_hak-1);
goto sorgu;
}
else if (user_gir_sayi < random_gir_sayi)
{
cout<<""<<endl;
cout<<"Lutfen daha buyuk bir sayi giriniz !!!"<<endl;
cout<<""<<endl;
user_hak=(user_hak-1) ;
goto sorgu;
}

system("PAUSE");
return EXIT_SUCCESS;
}
