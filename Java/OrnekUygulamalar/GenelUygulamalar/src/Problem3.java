import java.util.Scanner;
public class Problem3 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.println("Karenin bir kenar uzunlugunu giriniz :");
		double u = scn.nextDouble();
		double cevre = u * 4;
		double alan = u * u;
		
		System.out.println("Cevre = "+cevre);
		System.out.println("Alan = "+alan);
	}
}
