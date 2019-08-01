import java.util.Random;
import java.util.Scanner;
public class Soru6 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int hak=5,n=new Random().nextInt(20),sayi=0;
		System.out.println(n);
		do{
			System.out.print("\n"+hak+" hak kaldi. Sayi Gir : ");
			sayi=scn.nextInt();
			if(n>sayi)
			{
				System.out.print("Sayiyi yukselt!");
				hak--;
			}	
			else if(n<sayi)
			{
				System.out.print("Sayiyi kucult!");
				hak--;
			}
			else
			{
				System.out.print("\nTebrikler. "+(5-hak+1)+" tahminde buldunuz!");
				break;
			}
			if(hak<=0)
				System.out.print("\nKaybettin!\n");
		}while(hak>0);
	}
}
