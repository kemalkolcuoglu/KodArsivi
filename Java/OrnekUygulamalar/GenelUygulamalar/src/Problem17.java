import java.util.Scanner;
public class Problem17 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int sayi, toplam=0;
		System.out.print("Bir sayi giriniz : ");
		sayi=scn.nextInt();
		
		while(sayi!=0)
		{
			toplam+=sayi%10;
			sayi/=10;
		}
		System.out.println("Toplam = "+toplam);
	}
}
