/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package methodoverload;

/**
 *
 * @author HSYNPC
 */
public class MethodOverload {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Insan ins=new Insan(27,174,66.5);
    }

}

class Insan {

    private int yas;
    private int boy;
    private double kilo;

    Insan() {
        System.out.println("Parametresiz Kurucu Metot");
    }

    Insan(double kilo) {
        this();
        System.out.println("Kilo = "+ kilo);
    }

    Insan(int boy, double kilo) {
        this(kilo);
        System.out.println("Boy = " + boy + ", Kilo = "+ kilo);
        
    }

    Insan(int yas, int boy, double kilo) {
        this(boy,kilo);
        System.out.println("Yas = "+ yas + ", Boy = " + boy + ", Kilo = "+ kilo);

    }
}
