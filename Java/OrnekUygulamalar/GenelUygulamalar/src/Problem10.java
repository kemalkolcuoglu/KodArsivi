import java.util.Scanner;
public class Problem10 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("a sayisini girin : ");
		double a = scn.nextDouble();
		System.out.print("b sayisini girin : ");
		double b = scn.nextDouble();
		
		if(a>b)
		{
			System.out.println("a sayisi b sayisindan buyuktur");
		}
		else if(a<b)
		{
			System.out.println("b sayisi a sayisindan buyuktur");
		}
		else
		{
			System.out.println("Iki sayida birbirine esittir");
		}
	}
}
