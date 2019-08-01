import java.util.Scanner;
public class Problem24 {
	static double Seri(double n)
	{
		if(n<1) 
			return 0;
		else
			return (n / (n+1)) + Seri(n-1);
	}
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		double n,sonuc;
		System.out.print("Seri acilimi icin sayi (n) giriniz : ");
		n = scn.nextInt();
		sonuc = Seri(n);
		System.out.println("Sonuc = "+sonuc);
	}
}
