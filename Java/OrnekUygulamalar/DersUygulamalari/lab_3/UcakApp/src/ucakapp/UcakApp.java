/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ucakapp;

import java.util.Scanner;

/**
 *
 * @author gkhn
 */
public class UcakApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int select;
        Scanner input=new Scanner(System.in);
        do
        {
            System.out.println("\n1:Yeni uçak kaydı±, 0:cikis");
            System.out.println("Seciminizi girin:");
            select=input.nextInt();
            switch(select)
            {
            case 0: 
                break;
            case 1:                  
                    System.out.println("Uçağın Yolcu kapasitesini giriniz:");
                    int m_yolcukapasitesi=input.nextInt();

                    System.out.println("uçağın yakıt kullanımını(saatte) giriniz:");
                    int m_yakitkullanimorani=input.nextInt();
                    
                   
                   Ucak uck = new Ucak();
                   uck.yakitkullanimorani=m_yakitkullanimorani;
                   uck.yolcukapasitesi=m_yolcukapasitesi;
                   Ucak.toplamUCakSayisiArttir();
                   
                    System.out.println("Uçak için istediğiniz yeni seferin uçuş süresini giriniz! ");
                    int ucussure=input.nextInt();
                    
                    System.out.println("Yakıt fiyatını giriniz! ");
                    int yakitfiyat=input.nextInt();
                    
                    System.out.println("uçuş için bilet fiyatını giriniz! ");
                    int biletfiyati=input.nextInt();
                    
                    if(uck.seferuygunmu(ucussure, biletfiyati, yakitfiyat) )
                        System.out.println(Ucak.gettoplamUCakSayisi()+". ucak için sefer uygun ");
                    else
                        System.out.println(Ucak.gettoplamUCakSayisi()+". uçak için sefer uygun değil");
    
             break;
            }
            
        }while(select!=0);
    }
    
}

 class Ucak {
    public static int toplamUCak;
    public int yolcukapasitesi; 
    public static int yakitkullanimorani;
    
    public static int gettoplamUCakSayisi()
    {
    	return toplamUCak;
    }
    public static void toplamUCakSayisiArttir()
    {
    	toplamUCak++;
    }

    public boolean seferuygunmu(int ucussure,int biletfiyati,int yakitfiyat)
    {
        int maliyet=ucussure*yakitfiyat*yakitkullanimorani;
        maliyet=maliyet*(125/100);
        int eldeedilecekpara=yolcukapasitesi*biletfiyati;
        //System.out.println(teklifedilenpara +" "+maliyet );
    if(eldeedilecekpara>maliyet)
        return true;
                else
        return false;
    }
}
