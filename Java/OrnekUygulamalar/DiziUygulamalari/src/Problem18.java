import java.util.Scanner;
public class Problem18 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("Kare Matris (NxN) için boyut giriniz : ");
		int N = scn.nextInt();
		int[][] matris = new int[N][N];
		for(int i=0 ; i<N; i++)
			for(int j=0; j<N; j++)
				if(i==j)
					matris[i][j]=1;
				else
					matris[i][j]=0;
		for(int i=0 ; i<N; i++)
		{
			for(int j=0; j<N; j++)
			{
				System.out.print("\t"+matris[i][j]);
			}
			System.out.print("\n\n");
		}
	}
}
