/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cember;

import java.util.Scanner;

/**
 *
 * @author HSYNPC
 */
public class Cember {

    /**
     * @param args the command line arguments
     */
    static final double pi = 3.14;
    static double r;
    static double staticR;

//    double alan_hesapla(double r)
//    {
//        return pi*r*r;
//    }
//    double cevre_hesapla(double r)
//    {
//        return 2*pi*r;
//    }    
    double alan_hesapla() {
        return pi * r * r;
    }

    double cevre_hesapla() {
        return 2 * pi * r;
    }

    static double StaticCevre_hesapla() {
        return 2 * pi * r;
    }

    public static void main(String[] args) {
        // TODO code application logic here
        Integer integer1 = new Integer(5);
        int int1 = 5;
        integer1 = int1;

        if (int1==integer1) {
             System.out.println("EŞİTT: ");
        }
        
        Scanner klavye = new Scanner(System.in);
        System.out.println("Yarıçap giriniz: ");

        StaticCevre_hesapla();
        Cember circle = new Cember();
        circle.r = klavye.nextDouble();

        System.out.println("Pi sayısı sabit ve " + pi + " 'tür. ");
//        System.out.println(circle.alan_hesapla(circle.r));
//        System.out.println(circle.cevre_hesapla(circle.r));

        System.out.println(circle.alan_hesapla());
        System.out.println(circle.cevre_hesapla());

        Yaz yeni = new Yaz();
        System.out.println("Bir sayı giriniz: ");
        yeni.count = klavye.nextInt();
        if (Yaz.loop_while == true) {
            System.out.println("Problem while döngüsü ile çözülecek. ");
        } else {
            System.out.println("Problem for döngüsü ile çözülecek.");
        }

        yeni.HepsiniYaz(yeni.count);

    }

}
