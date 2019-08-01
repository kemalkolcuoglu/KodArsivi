/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package kalitimq;

/**
 *
 * @author musti
 */
public class Album {
 
public String Sanatci;
public int satisAdet;
public String AlbumAdi;

    public Album(String Sanatci, int satisAdet,String AlbumAdi) {
       
        this.Sanatci = Sanatci;
        this.satisAdet = satisAdet;
        this.AlbumAdi=AlbumAdi;
    }

     
    
    public static void ToplamSatisBul(Album[] dizi)
{
	int toplam=0; 
	
	for(int i=0;i< dizi.length;i++)
	{
		toplam+= dizi[i].satisAdet;
	}
	
	System.out.println("\nToplam Satış..: "+ toplam+"...adet.");
	
	
}
    
    
    
    
}
