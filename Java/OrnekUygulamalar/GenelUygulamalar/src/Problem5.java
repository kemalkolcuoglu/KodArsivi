import java.util.Scanner;
public class Problem5 {
	public static void main(String[] args) {
		final double PI = 3.14;
		Scanner scn = new Scanner(System.in);
		System.out.print("Kurenin yari capini (r) giriniz :");
		double r = scn.nextDouble();
		double alan = 4 * PI * r * r;
		double hacim = (4/3) * PI * r * r * r;
		
		System.out.println("Alan = "+alan);
		System.out.println("Hacim = "+hacim);
	}
}
