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
public class Arabesk extends Album{
    int yil;
    public Arabesk(String Sanatci, int satisAdet, String AlbumAdi,int yil) {
        super(Sanatci, satisAdet, AlbumAdi);
        this.yil=yil;
    }
    //25 puan
    public static void EnYeniOlaniBul(Arabesk[] dizi)
	{
		System.out.println("\nEn Yeni Albüm");
		Arabesk enyeni= dizi[0];
		
		for(int i=1;i< dizi.length;i++)
		{
			if(enyeni.yil< dizi[i].yil)
			{
				enyeni=dizi[i];
			}
		}
		
		System.out.println("\tEn yeni Albüm yili: "+enyeni.yil +"\tAlbüm adı...:"+enyeni.AlbumAdi+"\tSanatci: "+enyeni.Sanatci+"\tSatış Adet.."+ enyeni.satisAdet);
		
		
	}

   
}
