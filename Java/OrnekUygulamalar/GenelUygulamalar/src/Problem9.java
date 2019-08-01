import java.util.Scanner;
public class Problem9 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("Birinci kenar uzunlugunu (a) giriniz : ");
		double a = scn.nextDouble();
		System.out.print("Ikinci kenar uzunlugunu (b) giriniz : ");
		double b = scn.nextDouble();
		System.out.print("Kenarlar arasindaki aciyi (alfa-aci) giriniz : ");
		double aci = scn.nextDouble();
		
		double alan = a*b*Math.sin(aci*Math.PI/180)/2;
		System.out.println("Alan = "+alan);
	}
}
