import java.util.Scanner;
public class Problem1 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int a,b;
		System.out.print("İlk sayi (a) giriniz : ");
		a = scn.nextInt();
		System.out.print("İkinci sayi (b) giriniz : ");
		b = scn.nextInt();
		int T = a+b;
		int F = a-b;
		int C = a*b;
		int B = a/b;
		System.out.println("Toplam = "+T);
		System.out.println("Fark = "+F);
		System.out.println("Carpim = "+C);
		System.out.println("Bolum = "+B);
	}
}
