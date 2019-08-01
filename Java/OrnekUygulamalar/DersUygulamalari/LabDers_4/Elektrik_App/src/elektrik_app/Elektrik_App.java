/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package elektrik_app;

import java.util.Scanner;

/**
 *
 * @author HSYN
 */
public class Elektrik_App {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        int select;
        Scanner input=new Scanner(System.in);
        do
        {
            System.out.println("\n1:Yeni Fatura Hesabı, 0:Çıkış");
            System.out.println("Seçiminizi girin:");
            select=input.nextInt();
            switch(select)
            {
            case 0: 
                break;
            case 1:                  
                    System.out.println("Eski sayac değerini giriniz:");
                    int e_sayac=input.nextInt();
                    System.out.println("Yeni sayac değerini giriniz:");
                    int y_sayac=input.nextInt();
                    Elektrik elek1=new Elektrik(e_sayac,y_sayac);
                    System.out.println("Lütfen bir sezon giriniz:(1:Yaz,2:Bahar,3:Kış,4:Sonbahar)");

                    elek1.setSezon(input.nextInt());
                    System.out.println("Kullanılan Toplam Saat(Sayac Farkı): "+ elek1.sayac_fark_hesapla());
                    elek1.musterihesap(elek1.sayac_fark_hesapla());
                    
                    if(elek1.getFaturaTutar()!=0.0)
                        
                    System.out.println("FATURANIZ => "+ elek1.getFaturaTutar());
             break;
            }
            
        }while(select!=0);
        // TODO code application logic here
    }
}
class Elektrik
{
    int sezon;
    int eski_sayac;
    int yeni_sayac;
    double fatura_tutar;
    public Elektrik(int eski_sayac,int yeni_sayac)
    {
        this.eski_sayac=eski_sayac;
        this.yeni_sayac=yeni_sayac;
    }
    public void setSezon(int girilen_sezon)
    {
        sezon=girilen_sezon;
    }
    public double getFaturaTutar()
    {
        return fatura_tutar;
    }
    int sayac_fark_hesapla()
    {
        return yeni_sayac-eski_sayac;
    }
    public void musterihesap( int net_saat)
    {
      double indirim=-1;
      
      if(net_saat>0)
            { 
                if(sezon<5 && sezon>0)
                {
                    if(sezon==1) indirim=0.10;
                    else if(sezon==2) indirim=0.01;
                    else if(sezon==3) indirim=0;
                    else if(sezon==4) indirim=0.07;

                    fatura_tutar= (net_saat*3)-(net_saat*3*indirim);
                }   

                else
                {
                    System.out.println("Hatalı sezon girişi");
                }
            }
      else
    
         {   System.out.println("Hatalı sayaç girişi");}
    }
}
