import java.util.Scanner;
public class Problem5 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int[] A = {12,18,22,10,23,28,38,56,44,74};
		int[] B = {38,11,14,26,16,39,43,32,20,13};
		int[] C = new int[A.length];
		for(int i=0; i<A.length; i++)
		{
			C[i]=A[i]+B[i];
		}
		System.out.print("\tA + B = C\n");
		for(int i=0; i<A.length; i++)
		{
			System.out.println("\t"+A[i]+" + "+B[i]+" = "+C[i]);
		}
	}
}
