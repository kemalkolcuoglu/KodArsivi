import java.util.Scanner;
public class Problem23 {
	static int fib(int n)
	{
		if(n == 2 || n==1) 
			return 1;
		else
			return fib(n-1) + fib(n-2);
	}
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int n;
		System.out.print("Sira sayisini (n) giriniz : ");
		n = scn.nextInt();
		int sonuc = fib(n);
		System.out.println("Sonuc = "+sonuc);
	}
}
