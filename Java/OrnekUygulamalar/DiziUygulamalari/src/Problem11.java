import java.util.Random;
import java.util.Scanner;
public class Problem11 {
	public static void main(String[] args){
		Scanner scn = new Scanner(System.in);
		Random rnd = new Random();
		System.out.print("Eleman Sayisi (n) Giriniz :");
		int n = scn.nextInt();
		
		int[] sayilar = new int[n];
		for(int i=0 ; i<n ; i++){
			sayilar[i] = rnd.nextInt(99) + 1;
		}
		for(int i=0 ; i<n ; i++){
			System.out.print("\t" + sayilar[i]);
		}
	}
}
