/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ogrenciapp;

/**
 *
 * @author gkhn
 */
public class CalisanOgrenci extends Kisi implements Calisan,Ogrenci

{
    int maas;
    int dersSayisi;
    int haftalıkCalismaSaati;
    double vergi;
    int harc;
    public CalisanOgrenci(int maas,int dersSayisi,int haftalıkCalismaSaati,String ad,String Soyad,int yas)
    {
        super(ad,Soyad,yas);
        this.maas=maas;
        this.dersSayisi=dersSayisi;
        this.haftalıkCalismaSaati=haftalıkCalismaSaati;
        vergiHesapla();
        HarcHesapla();
        
      
    }
    public void goster()
    {
        System.out.println(ad+" "+Soyad+" Yas = "+yas+" Harc = "+harc+" vergi = "+vergi );
    }
    @Override
    public void vergiHesapla()
    {
        if (dersSayisi>5)
        {
                if((haftalıkCalismaSaati<5))
        {
                    vergi=maas*0.1;
                }
                else if((haftalıkCalismaSaati>=5) &&(haftalıkCalismaSaati<=10))
                {
                    vergi= maas*0.2;
                }
                else if(haftalıkCalismaSaati>10)
                {
                    vergi= maas*0.3;
                }
            
        }
        else
        {
            vergi=0;
        }

   
   
    }
    @Override
  public void HarcHesapla()
  {
      if (maas<300)
      {
          harc=0;
      }
      else
      {
          harc=250;
      }
  }
}
