import java.util.Scanner;
public class Problem4 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		double[] A = {1900,2200,2360,2400,3600,3950,4450,4750,4900,6000};
		double[] B = new double[A.length];
		System.out.print("Maas zammi icin katsayi (k) giriniz : ");
		double k = scn.nextDouble();
		for(int i=0; i<A.length; i++)
		{
			B[i]=A[i]*k;
		}
		System.out.print("\tEski\tYeni\tZam\n\n");
		for(int i=0; i<A.length; i++)
		{
			System.out.println("\t"+A[i]+"TL\t"+B[i]+"TL\t("+(B[i]-A[i])+"TL)");
		}
	}
}
