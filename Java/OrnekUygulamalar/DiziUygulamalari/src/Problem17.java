import java.util.Scanner;
public class Problem17 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("Kare Matris (NxN) için boyut giriniz : ");
		int N = scn.nextInt(), T=0;
		int[][] matris = new int[N][N];
		for(int i=0 ; i<N; i++)
		{
			for(int j=0; j<N; j++)
			{
				System.out.print((i+1) + ". satir - " + (j+1) + ". sutun : ");
				matris[i][j] = scn.nextInt();
			}
			System.out.print("\n");
		}
		System.out.println("\tMatrisin Normal Hali---\n");
		for(int i=0 ; i<N; i++)
		{
			for(int j=0; j<N; j++)
			{
				System.out.print("\t"+matris[i][j]);
			}
			System.out.print("\n\n");
		}
		System.out.println("\tMatrisin Transpozu Alinmis Hali---\n");
		for(int i=0 ; i<N; i++)
		{
			for(int j=0; j<N; j++)
			{
				System.out.print("\t"+matris[j][i]);
			}
			System.out.print("\n\n");
		}
	}
}
