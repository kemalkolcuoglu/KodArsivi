/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package musteri_app;

import java.util.Scanner;

/**
 *
 * @author gkhn
 */
public class Musteri_App {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int select;
        Scanner input=new Scanner(System.in);
        do
        {
            System.out.println("\n1:Yeni Müsteri kaydı±, 0:cikis");
            System.out.println("Seciminizi girin:");
            select=input.nextInt();
            switch(select)
            {
            case 0: 
                break;
            case 1:                  
                    System.out.println("müsteri adini giriniz:");
                    String m_ad=input.nextLine();
                    System.out.println("soyadini giriniz:");
                    String m_soyad=input.nextLine();
                    System.out.println("müsteri sehir giriniz:");
                    String m_sehir=input.nextLine();
                    System.out.println("yas giriniz:");
                    int m_yas=input.nextInt();
                    Musteri m1=new Musteri();
                    m1.ad=m_ad;
                    m1.soyad=m_soyad;
                    m1.sehir=m_sehir;
                    m1.yas=m_yas;
                    Musteri.musteriSayisiArttir();
                    System.out.println("Sayin"+m1.ad +" "+ m1.soyad+" "+Musteri.getmusteriSayisi()+". müsterimizsiniz");
                
                    if(m1.kacinciMusteri())
                        System.out.println("Tebrikler indiriminiz var!");
    
             break;
            }
            
        }while(select!=0);
    }
    
}
 class Musteri {
            public String ad;
	    public String soyad;
            public int yas;
	    public String sehir;
	    public static int musteriSayisi;
          
	    
	    public static int getmusteriSayisi()
	    {
	    	return musteriSayisi;
	    }
	    public static void musteriSayisiArttir()
	    {
	    	 musteriSayisi++;
	    }
	    
	    public boolean kacinciMusteri()
	    {
             
	    	if( Musteri.musteriSayisi==1)
	    			return true;
	    	else
	    		return false;
	    }

}
