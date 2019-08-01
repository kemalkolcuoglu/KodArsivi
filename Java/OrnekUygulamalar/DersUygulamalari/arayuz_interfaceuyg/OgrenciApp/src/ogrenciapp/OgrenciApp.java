/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ogrenciapp;

/**
 *
 * @author gkhn
 */
public class OgrenciApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        CalisanOgrenci ogr1 = new CalisanOgrenci(1500,8,11,"Ahmet","Korkmaz",20);
        CalisanOgrenci ogr2 = new CalisanOgrenci(100,5,18,"Hakkı","Bulut",22);
        CalisanOgrenci ogr3 = new CalisanOgrenci(1200,15,7,"Tevfik","İnanır",25);
        ogr1.goster();
        ogr2.goster();
        ogr3.goster();
        
    }
    
}
