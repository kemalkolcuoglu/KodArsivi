package java_uygulamalari;
import java.util.Scanner;

public class hesap_makinesi_alistirmasi
{   
    public static void main(String[] args) 
    {
        Scanner giris = new Scanner(System.in);
        int sonuc=0;
        System.out.print("Birinci Sayi : ");
        int a = giris.nextInt();
        System.out.print("Ikinci Sayi : ");
        int b = giris.nextInt();
        System.out.print("Islem : ");
        String islem = giris.next();
        
        switch(islem)
        {
            case "+" : sonuc = a+b; break;
            case "-" : sonuc = a-b; break;
            case "*" : sonuc = a*b; break;
            case "/" : sonuc = a/b; break;
            case "%" : sonuc = a%b; break;
            default : System.out.println("Hatali Giris!!!");
        }
        System.out.println("Sonuc : "+ sonuc);
    }
}
