package java_uygulamalari;
import java.util.Scanner;

public class asal_sayi_alistirmasi 
{
    public static void main(String[] args) 
    {
        Scanner giris = new Scanner(System.in);
        System.out.print("Bir Sayi Giriniz : ");
        int sayi = giris.nextInt();
        int sayac=0;
        for(int i=2;i<=sayi;i++)
        {
            for(int j=2;j<i;j++)
                if(i%j==0)
                {   sayac++; break; }
            if(sayac==0)
                System.out.println(i+" Sayisi Asaldir...");
            else
                System.out.println(i+" Sayisi Asal Degildir...");
            sayac=0;
        }
    }
}
