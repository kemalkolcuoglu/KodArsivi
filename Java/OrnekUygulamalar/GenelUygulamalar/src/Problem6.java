import java.util.Scanner;
public class Problem6 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("Kilometre cinsinden uzunlugu (x) giriniz : ");
		double x = scn.nextDouble();
		
		double Mil = (0.621) * x;
		System.out.println("Mil = "+Mil);
	}
}
