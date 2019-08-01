package cokbicimlilik;
import java.util.Scanner;
/*
 * @Yazar Turam
 */
public class CokBicimlilik 
{
    public static void main(String[] args)
    {
        Scanner giris = new Scanner(System.in);
        System.out.println("Hesaplanmasını İstediğiniz Şeklin Adını Giriniz");
        System.out.println("1.Kare\n2.Dikdortgen\n3.Daire\n4.Ucgen");
        System.out.print("Seçim -> ");
        int secim = giris.nextInt();
        
        switch (secim)
        {
            case 1:
                Kare kare = new Kare(4);
                System.out.println("Kare Alanı : "+kare.alanHesabı());
                
            case 2:
                Dikdortgen dik = new Dikdortgen(4,9);
                System.out.println("Dikdortgen Alanı : "+dik.alanHesabı());
                
            case 3:
                Daire daire = new Daire(5);
                System.out.println("Daire Alanı : "+daire.alanHesabı());
                
            case 4:
                Ucgen ucgen = new Ucgen(8,6);
                System.out.println("Ucgen Alanı : "+ucgen.alanHesabı());
                break;
            default:
                System.err.println("HATALI GIRIS!");
                break;
        }
    }   
}