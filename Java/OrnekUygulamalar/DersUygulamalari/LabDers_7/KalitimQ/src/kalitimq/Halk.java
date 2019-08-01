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
public class Halk extends Album{
   boolean yoresel;
   
    public Halk(String Sanatci, int satis,String AlbumAdi,boolean yoresel) {
        super(Sanatci,satis,AlbumAdi);
        this.yoresel=yoresel;
    }
   
    //25 puan
    
     public static void Goster(Halk[] HalkDizi)
	{   
                
		System.out.println("\nYöresel Olan Halk müziklerini göster");
		
		for(int i=0;i< HalkDizi.length;i++)
		{
			if(HalkDizi[i].yoresel)
			{
				System.out.println("\tALBÜM ADI: "+HalkDizi[i].AlbumAdi+"\tSANATÇI: "+ HalkDizi[i].Sanatci+"\tSATIŞ ADETİ"+HalkDizi[i].satisAdet);
			}
	    }
	}
 
    
}
