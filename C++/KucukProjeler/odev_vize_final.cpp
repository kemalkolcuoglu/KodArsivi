#include<iostream>
using namespace std;
int main ()
{
	float vize1,vize2,telafi,ort,ort2,but,final;

	cout<<"Not Degerlendirme Programina Hosgeldiniz...\nLutfen Ilk Ara Sinav Notunuzu Giriniz: ";
	cin>>vize1;
	cout<<"Ikinci Ara Sinav Notunuzu Giriniz: ";
	cin>>vize2;
	ort=(vize1+vize2)/2;

	if((ort)<=50){
		cout<<endl<<"Lutfen Telafi Notunuzu Giriniz: ";
		cin>>telafi;
		ort=(vize1+vize2+telafi)/3 ;
		cout<<endl<<"Yeni Ortalamaniz: "<<ort<<endl;
	}
	cout<<endl<<"Final Notunuzu Giriniz: ";
	cin>>final;
	ort2=(ort+final)/2;
	if (final>=50){
        if (ort2>60){
		cout<<endl<<"Yeni Ortalamaniz: "<<ort2<<endl;
        cout<<"DERSI GECTINIZ...";}
		else{
		cout<<"Yeni Ortalamaniz: "<<ort2<<endl;}
		if(ort2<60){
		cout<<endl<<"Butunleme Notunu Giriniz: ";
		cin>>but;
		ort2=(ort*0.4+but*0.6);
		cout<<endl<<"Yeni Ortalamaniz: "<<ort2<<endl;
        if (ort2>60)
        cout<<"DERSI GECTINIZ...";
		else
		cout<<"GECMIS OLSUN...";
		}
	}
	else{
	if(ort2<60){
		cout<<endl<<"Butunleme Notunu Giriniz: ";
		cin>>but;
		ort2=(ort*0.4+but*0.6);
		cout<<"Yeni Ortalamaniz: "<<ort2<<endl;

			if (ort2>60)
			cout<<"DERSI GECTINIZ...";
			else
			cout<<"GECMIS OLSUN...";
		}
	}
	return 0;
}
