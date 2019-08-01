/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mainclass;

/**
 *
 * @author gkhn
 */

 class Tshirt {
    /*
     * Enum sabiti
     * 
     * önceden belli olan ve şekil olarak değişmeyecek şeyleri tanımlamak için
     * kullanılır. Örnek:Giysilerin boyları ; mesela bir alisveris
     * siteniz var ve müşteriden giysinin boyutunu seçmesini
     * istediniz.(Small,Medium…) gibi ve bunları enum sabiti ile
     * tanımlaya biliyoruz. Çünkü giysi boyutları standarttır.
     * 
     * Not: enumlar Büyük Harfler ile tanımlanır.
     */

    // kullanımı
    // enum <tur> <isim>;

    public enum BOYLAR {
        SMALL, MEDIUM, LARGE, XLARGE
    }

    private BOYLAR boyut;

    public Tshirt(BOYLAR boy) {
        this.boyut = boy;
    }
    
    public void setBoyut(BOYLAR boyut) {
        this.boyut = boyut;
    }

    public double getFiyat() {
        if (boyut == BOYLAR.XLARGE) {
            return 14.00;
        } else if (boyut == BOYLAR.LARGE) {
            return 12.00;
        } else if (boyut == BOYLAR.MEDIUM) {
            return 10.00;
        } else if (boyut == BOYLAR.SMALL) {
            return 8.00;
        } else {
            return 0.00;
        }

    }

}
public class MainClass {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
           //Enum Kullanımı 1
        Tshirt t=new Tshirt(Tshirt.BOYLAR.LARGE);
        System.out.println("Large Tshirt Fiyati :"+t.getFiyat());

        //Enum Kullanımı 2
        t.setBoyut(Tshirt.BOYLAR.MEDIUM);
        System.out.println("Medium Tshirt Fiyatı :"  + t.getFiyat());
    }
    
}
