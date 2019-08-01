#include<iostream>
using namespace std;
int main()
{
  int a,b,c,d,i,j,k;
  cout<<"kaça kaçlık bir matris çarpımı istiyorsunuz"<<endl;
  cout<<"1.matrisin satır sayısı :";
  cin>>a;
  cout<<"1.matrisin sutun sayısı :";
  cin>>b;

  cout<<"2.matrisin satır sayısı :";
  cin>>c;
  cout<<"2.matrisin sutun sayısı :";
  cin>>d;

  int mata[a][b],matb[c][d], matc[a][d];

  cout<<endl;

  if(b != c)
    {
      cout<<"bu işlem yapılamaz "<<endl;
      cout<<"1. matrisin sutun sayısı 2. matrisin satır sayısına eşit olmalı"<<endl;
      return 0;
    }

  cout<<"============================================"<<endl;

  cout<<"birinci matrisin sayılarını girin"<<endl;

    for(i=0;i<a;i++)
      {
for(j=0;j<b;j++)
  {
    cout<<i+1<<". satır "<<j+1<<". sutun elemanı : ";
    cin>>mata[i][j];
  }
cout<<endl;
      }


    cout<<"=========================================="<<endl;
  cout<<"ikinci matrisin sayılarını girin"<<endl;

    for(i=0;i<c;i++)
     { for(j=0;j<d;j++)
{
  cout<<i+1<<". satır "<<j+1<<". sutun elemanı : ";
  cin>>matb[i][j];
}
     cout<<endl;
     }
  cout<<endl<<endl;
  for(i=0;i<a;i++)
    {
      for(j=0;j<b;j++)
cout<<mata[i][j]<<"\t";
      cout<<endl;
    }



  cout<<"==========================================="<<endl;;


  for(i=0;i<c;i++)
    {
      for(j=0;j<d;j++)
cout<<matb[i][j]<<"\t";
      cout<<endl;
    }
  cout<<"===========çarpım sonucu=================="<<endl;

  for(i=0;i<a;i++)
    for(j=0;j<d;j++)
      matc[i][j]=0;

  //çarpma işleminin yapıldığı bölüm
  for(i=0;i<a;i++)
    for(j=0;j<d;j++)
      for(k=0;k<b;k++)
matc[i][j] = matc[i][j] + mata[i][k]*matb[k][j];



  cout<<endl<<endl;



  for(i=0;i<a;i++)
    {
      for(j=0;j<d;j++)
cout<<matc[i][j]<<"\t";
      cout<<endl;
    }
  return 0;
}

