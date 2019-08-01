import java.util.Scanner;
public class Problem8 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("Ucgenin taban uzunlugunu (x) giriniz : ");
		double x = scn.nextDouble();
		System.out.print("Ucgenin yuksekligini (h) giriniz : ");
		double h = scn.nextDouble();
		
		double alan = x*h / 2;
		System.out.println("Alan = "+alan);
	}
}
