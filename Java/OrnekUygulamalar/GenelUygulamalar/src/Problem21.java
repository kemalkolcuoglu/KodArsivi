import java.util.Scanner;
public class Problem21 {
	static int Faktoriyel(int sayi)
	{
		int sonuc=1;
		for(int i=1; i<=sayi; i++)
		{
			sonuc*=i;
		}
		return sonuc;
	}
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("Eleman Sayisi (n) giriniz : ");
		int n=scn.nextInt();
		System.out.print("Secim sayisi (r) giriniz : ");
		int r=scn.nextInt();
		int sonuc = Faktoriyel(n) / Faktoriyel(n-r);
		System.out.println("Permutasyon = "+sonuc);
	}
}
