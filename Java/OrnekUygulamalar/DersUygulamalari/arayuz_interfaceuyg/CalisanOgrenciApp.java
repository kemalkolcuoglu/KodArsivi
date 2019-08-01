/*
 * @Yazar: Turam
 */

public class CalisanOgrenciApp 
{
    public static void main(String[] args) 
    {
        CalisanOgrenci ogr1 = new CalisanOgrenci(1500,8,11,"Ahmet","Korkmaz",20);
        CalisanOgrenci ogr2 = new CalisanOgrenci(100,5,18,"Hakkı","Bulut",22);
        CalisanOgrenci ogr3 = new CalisanOgrenci(1200,15,7,"Tevfik","İnanır",25);
        
        ogr1.goster();
        ogr2.goster();
        ogr3.goster();
    }
}

public class Kisi
{
    public String ad;
    public String Soyad;
    public int yas;
    
    Kisi(String ad,String Soyad,int yas)
    {
        this.ad = ad;
        this.Soyad = Soyad;
        this.yas = yas;
    }
}

public class CalisanOgrenci extends Kisi implements Calisan,Ogrenci
{
    int maas;
    int dersSayisi;
    int haftalıkCalismaSaati;
    double vergi;
    int harc;
    
    CalisanOgrenci(int maas,int dersSayisi,int haftalıkCalismaSaati,String ad,String Soyad,int yas)
    {
        super(ad,Soyad,yas);
        this.maas = maas;
        this.dersSayisi = dersSayisi;
        this.haftalıkCalismaSaati = haftalıkCalismaSaati;
    }
    
    @Override
    public void vergiHesapla()
    {
        if(dersSayisi<5)
            vergi=0;
        else
        {
            if(haftalıkCalismaSaati<5)
                vergi=maas/0.1;
            else if(haftalıkCalismaSaati>=5 || haftalıkCalismaSaati<=10)
                vergi=maas/0.2;
            else if(haftalıkCalismaSaati>10)
                vergi=maas/0.3;
        }
    }
    
    @Override
    public void HarcHesapla()
    {
        if(maas<300)
            harc=0;
        else
            harc=250;
    }
    
    public void goster()
    {
        System.out.println(super.ad+' '+super.Soyad+" Yas : "+super.yas+" Harc : "+harc+" Vergi : "+vergi);
    }
}

public interface Calisan
{
    public void HarcHesapla();
}

public interface Ogrenci
{
    public void vergiHesapla();
}