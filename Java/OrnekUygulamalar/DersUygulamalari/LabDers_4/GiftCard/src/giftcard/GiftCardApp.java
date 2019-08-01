/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package giftcard;

import java.util.Scanner;

/**
 *
 * @author Tunalı
 */
public class GiftCardApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner reader = new Scanner(System.in);  // Reading from System.in
        do {            
            System.out.println("Gift Card kullanıcısı girmek istiyor musunuz. (E / H)");
            String choice = reader.next(); //
            if(choice.toLowerCase().equals("h"))
                break;            
            System.out.println("Adını Giriniz:");
            String name = reader.next(); 
            System.out.println("Soyadını Giriniz:");
            String surname = reader.next(); //
            System.out.println("Cinsiyeti Giriniz(kadın/erkek):");
            String gender = reader.next(); //
            System.out.println("Yaş Giriniz:");
            int age = reader.nextInt(); //
            System.out.println("Girişler Tamam mı ?(E / H)");            
            String entrance = reader.next(); //
            Customer cs;
            if (entrance.toLowerCase().equals("e"))
            {
                cs = new Customer(name, surname, gender, age); 
            }                       
            else 
            {
                System.out.println("Hangi Şehirdesiniz(konya,ankara,istanbul):");
                String city = reader.next();
                System.out.println("Varsa yuklenecek puanı giriniz:");
                int credit = reader.nextInt(); //
                cs= new Customer(name, surname, gender, age, city, credit);
            }
            cs.SetParameters();
            System.out.println(String.format("%s %s (%s) kullanıcısına ait puan %d olarak belirlenmistir. ",cs.getName(),cs.getSurname(),cs.getCity(),cs.getCredit()));          
        }while(1==1);    
    }
}