import java.util.Scanner;
public class Problem14 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int a,b;
		int n=0;
		do{
			System.out.print("Mod'u alinacak sayiyi (a) giriniz : ");
			a = scn.nextInt();
			System.out.print("Hangi Mod'un alinacagini (b) giriniz : ");
			b = scn.nextInt();
			System.out.println(a + " mod " + b + " = " + a%b);
		}while(a!=0);
		System.out.println("0 sayisi girildi ve cikildi");
	}
}
