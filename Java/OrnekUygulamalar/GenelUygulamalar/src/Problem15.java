import java.util.Scanner;
public class Problem15 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int baslangic,bitis,adim,toplam=0;
		System.out.print("Baslangic degerini giriniz : ");
		baslangic=scn.nextInt();
		System.out.print("Bitis degerini giriniz : ");
		bitis=scn.nextInt();
		System.out.print("Adim degerini giriniz : ");
		adim=scn.nextInt();
		
		for(int i=baslangic ; i<=bitis ; i+=adim)
		{
			toplam+=i;
		}
		System.out.println("Toplam = "+toplam);
	}
}
