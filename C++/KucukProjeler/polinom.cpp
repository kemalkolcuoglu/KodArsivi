#include <iostream>
#include <cmath>
using namespace std;

struct Polinom
{
    int  a,b,c;
    void kokbul();

};

Polinom KatsayilariGir(Polinom A)
{
    cout<<"a = ";
    cin>>A.a;
    cout<<"b = ";
    cin>>A.b;
    cout<<"c = ";
    cin>>A.c;
    return A;
}

void Polinom::kokbul()
{
    cout<<"a="<<a<<endl;
    cout<<"b="<<b<<endl;
    cout<<"c="<<c<<endl;
    if (a!=0)
    {
        double delta,kok1,kok2;
        delta = b*b-4*a*c;
        if (delta>=0)
        {
            kok1= (-b+sqrt(delta))/(2*a);
            kok2= (-b-sqrt(delta))/(2*a);
            cout<<a<<"x^2 + "<<b<<"x + "<<c<<" = 0 denkleminin kokleri "<<endl;
            cout<<"x1 = "<<kok1<<endl;
            cout<<"x2 = "<<kok2<<endl;
        }
        else
            cout<<"Denklemin Reel koku bulunmamaktadir";
        cout<<endl<<endl<<endl;
    }
    else
    {
        cout<<b<<"x + "<<c<<" = 0 denkleminin koku "<<a<<endl;
        cout<<(-1.0*c)/b<<endl;
        cout<<endl<<endl<<endl;
    }
}

void KokleriBul(Polinom A)
{
        A.kokbul();
}

Polinom Islem(Polinom A, Polinom B)
{
    Polinom C;
    C.a = A.a + B.a;
    C.b = A.b + B.b;
    C.c = A.c + B.c;
    return C;
}

Polinom Islem(Polinom A, Polinom B, char islem)
{
    Polinom C;
    if (islem=='-')
    {
        C.a = A.a - B.a;
        C.b = A.b - B.b;
        C.c = A.c - B.c;
    }
    else
        C = Islem(A,B);

    return C;
}

int main()
{
    Polinom P1,P2;
    cout<<"1. polinom icin katsayilari giriniz : "<<endl;
    P1=KatsayilariGir(P1);
    cout<<"2. polinom icin katsayilari giriniz : "<<endl;
    P2=KatsayilariGir(P2);
    KokleriBul(P1);
    KokleriBul(P2);

    Polinom P3;
    cout<<"1. Polinomdan 2. Polinom cikariliyoir ve olusan polinomun kokleri bulunuyor...."<<endl;
    P3 = Islem(P1, P2, '-');
    cout<<endl<<endl<<endl;

    KokleriBul(P3);
    cout<<"1. ve 2. Polinomlar toplanarak kokleri bulunuyor...."<<endl;
    P3 = Islem(P1, P2);
    KokleriBul(P3);
    return 0;
}
