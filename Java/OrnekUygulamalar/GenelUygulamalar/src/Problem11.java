import java.util.Scanner;
public class Problem11 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("Katsayi A giriniz : ");
		double a = scn.nextDouble();
		System.out.print("Katsayi B giriniz : ");
		double b = scn.nextDouble();
		System.out.print("Katsayi C giriniz : ");
		double c = scn.nextDouble();
		
		double D = (b*b)-4*a*c;
		if(D>0)
		{
			double x1 = (-b+Math.sqrt(D))/2*a;
			double x2 = (-b-Math.sqrt(D))/2*a;
			System.out.println("Kok 1 (x1) = "+x1);
			System.out.println("Kok 2 (x2) = "+x2);
		}
		else if(D==0)
		{
			double x1 = (-b+Math.sqrt(D))/2*a;
			System.out.println("Kok 1 (x1) = "+x1);
		}
		else if(D<0)
		{
			System.out.println("Reel kokler yoktur");
		}

	}
}
