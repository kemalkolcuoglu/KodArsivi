import java.util.Scanner;
public class Problem22 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int n,T1=1,T2=1,T3;
		System.out.print("Eleman Sayisi (n) giriniz : ");
		n=scn.nextInt();
		System.out.print("\n\t" + T1 + "\t" + T2);
		for(int i=1; i<=n-2; i++)
		{
			T3=T1+T2;
			System.out.print("\t" + T3);
			T1=T2;
			T2=T3;
		}
	}
}
