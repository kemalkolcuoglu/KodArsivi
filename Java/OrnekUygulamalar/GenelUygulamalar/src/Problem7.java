import java.util.Scanner;
public class Problem7 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("Ucgenin 1. dik kenar uzunlugunu giriniz : ");
		double k1 = scn.nextDouble();
		System.out.print("Ucgenin 2. dik kenar uzunlugunu giriniz : ");
		double k2 = scn.nextDouble();
		
		double hipotenus = Math.sqrt(k1*k1 + k2*k2);
		System.out.println("Hipotenus = "+hipotenus);
	}
}
