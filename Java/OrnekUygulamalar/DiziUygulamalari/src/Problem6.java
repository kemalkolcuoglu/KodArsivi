import java.util.Scanner;
public class Problem6 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int[] dizi = {1,2,3,4,5,6,7,8,9};
		System.out.print("Birinci indis (a) giriniz : ");
		int a=scn.nextInt();
		System.out.print("İkinci indis (b) giriniz : ");
		int b=scn.nextInt();
		
		int temp = dizi[a];
		dizi[a] = dizi[b];
		dizi[b] = temp;
		
		for(int i=0; i<dizi.length; i++)
		{
			System.out.print("\t"+dizi[i]);
		}
	}
}
