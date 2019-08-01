/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package kalitimq;

import java.util.Scanner;

/**
 *
 * @author musti
 */



public class KalitimQ {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
             
                //25 puan
                Halk h1=new Halk("Neşet Ertaş",10000,"Acem Kızı", true);
                Halk h2=new Halk("Mahsuni Şerif",5000,"Mevlam İki Göz Vermiş", true);
                Halk h3=new Halk("Volkan Konak",1000,"Mora", false);
                Halk[]  HalkDizisi=new Halk[]{h1,h2,h3};                
                Halk.Goster(HalkDizisi);
                
                Arabesk a1=new Arabesk("İbrahim Tatlıses",150000,"Yalnızım",1990);
                Arabesk a2=new Arabesk("Ferdi Tayfur",100000,"Emmoğlu",1995);
                Arabesk a3=new Arabesk("Müslüm Gürses",250000,"Meselem",1993);
		
                Arabesk[] ArabeskDizi=new Arabesk[]{a1,a2,a3};
                Arabesk.EnYeniOlaniBul(ArabeskDizi);
                
                Album[] AlbumDizi=new Album[]{h1,h2,h3,a1,a2,a3};
                Album.ToplamSatisBul(AlbumDizi);
                
              
              
               
                
           
        
        // TODO code application logic here
    }
    
}
