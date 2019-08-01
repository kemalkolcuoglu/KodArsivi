/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package anasinif;

/**
 *
 * @author gkhn
 */
 enum Otomobil {
 
    MERCEDES(70),
    AUDI(80),
    FIAT(30),
    HONDA(48),
    TOYOTA(40);
 
    private int fiyat;
 
    private Otomobil(int f) {
        fiyat = f;
    }
 
    public int getFiyat() {
        return fiyat;
    }
}
public class anaSinif {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
      Otomobil oto1 = Otomobil.AUDI;
       System.out.println("Audi Fiyati :"+oto1.getFiyat());
    Otomobil oto2 = Otomobil.HONDA;
    System.out.println("Honda Fiyati :"+oto2.getFiyat());
}
}
