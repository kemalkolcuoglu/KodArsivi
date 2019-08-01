import java.util.Scanner;
public class Problem26 {
	static double Seri(double n)
	{
		if(n<1) 
			return 0;
		else
			return ((Math.pow(n,2)-1) / (Math.pow(n,3)+2)) + Seri(n-1);
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
