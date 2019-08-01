/*Vize-Final Hesabi yapan uygulama*/

#include<iostream>
using namespace std;
int main ()
{
	float ara,ort,son,a;
	cout<<"\t\t  ...Not Degerlendirme Programina Hosgeldiniz...\n\nLutfen Ara Sinav Notunuzu Giriniz: ";
	cin>>ara;
	cout<<"Final Notunuzu Giriniz: ";
	cin>>son;
	cout<<endl;
    ort=(ara+son)/2;

    if(ort>=60)
        cout<<"DERSI GECTINIZ..."<<endl;

    if(ort<60)
    {
		cout<<endl<<"Butunleme Notunu Giriniz: ";
		cin>>son;
		ort=(ara*0.4+son*0.6);
        if (ort>60)
            cout<<endl<<"DERSI GECTINIZ...";
		else
            cout<<endl<<"GECMIS OLSUN...";
    }
    cout<<endl<<"Ders Ortalamaniz: "<<ort<<endl;
    if(ort>=90)
        cout<<"Harf Notunuz: AA";
    else if(ort>=80)
        cout<<"Harf Notunuz: BA";
    else if(ort>=70)
        cout<<"Harf Notunuz: BB";
    else if(ort>=65)
        cout<<"Harf Notunuz: CB";
    else if(ort>=60)
        cout<<"Harf Notunuz: CC";
    else if(ort>=55)
        cout<<"Harf Notunuz: DC";
    else if(ort>=50)
        cout<<"Harf Notunuz: DD";
    else if(ort>=40)
        cout<<"Harf Notunuz: FD";
    else
        cout<<"Harf Notunuz: FF";

	cout<<"\n\n\n";
	cout<<"Cikmak icin bir sayi giriniz -> ";
	cin>>a;
	return 0;
}
