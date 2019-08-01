import java.util.Scanner;
public class Problem1 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int[] Dizi = new int[10];
		for(int i=0; i<10; i++)
		{
			System.out.print((i+1) + ". sayiyi giriniz : ");
			Dizi[i] = scn.nextInt();
		}
	}
}
