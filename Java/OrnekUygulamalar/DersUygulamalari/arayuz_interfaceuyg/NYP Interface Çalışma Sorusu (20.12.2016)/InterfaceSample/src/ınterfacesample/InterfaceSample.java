/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ınterfacesample;

/**
 *
 * @author Tunalı
 */
public class InterfaceSample {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Square sq = new Square(4);
        System.out.println("Kenarı 4 olan karenin alanı : " + sq.GetArea());
        Circle cr = new Circle(3);
        System.out.println("Yarıçapı 3 olan dairenin alanı : " + String.format("%.2f", cr.GetArea()));
        Cylinder cyl = new Cylinder(3, 4);
        System.out.println("Taban yarıçapı 3 yüksekliği 4 olan silindirin alanı : " + String.format("%.2f", cyl.GetArea()));
        System.out.println("Taban yarıçapı 3 yüksekliği 4 olan silindirin hacmi : " + String.format("%.2f", cyl.GetVolume()));
    }

}
