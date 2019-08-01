#include<iostream>
using namespace std;
class dikucgen
{
private:
	float a,b,c;
public:
	dikucgen (float=3,float=4,float=5);
	void veriAl(float,float,float);
	void goruntule(void);
	float hipotenus(void);
	float cevre(void);
	float alan(void);
};
dikucgen::dikucgen(float xx,float yy,float zz)
{
a=xx;
b=yy;
c=zz;
}
void dikucgen::veriAl(float xx,float yy,float zz)
{
	a=xx;
	b=yy;
	c=zz;
}
void dikucgen::goruntule(void)
{
	cout<<"ucgenin kenarlari="<<a<<" "<<b<<" "<<c;
	return;
}
float dikucgen::hipotenus(void)
{
	float hipotenus;
	hipotenus=a;
	if(a<b)
		hipotenus=b;
	if(b<c)
		hipotenus=c;
	return hipotenus;
}
float dikucgen::cevre(void)
{
	float cevre;
	cevre=a+b+c;
	return cevre;
}
int main()
{
	float c1,c2,tc;
	dikucgen d1,d2(6,8,10);
	c1=d1.cevre();
	c2=d2.cevre();
	tc=c1+c2;
	d1.goruntule();
	d2.goruntule();
	cout<<"ucgenlerin cevreleri toplamý="<<tc<<endl;
	return 0;
}
