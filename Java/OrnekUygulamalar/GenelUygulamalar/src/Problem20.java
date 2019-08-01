import java.util.Scanner;
public class Problem20 {
	static int Faktoriyel(int sayi)
	{
		int sonuc=1;
		for(int i=1; i<=sayi; i++)
		{
			sonuc*=i;
		}
		return sonuc;
	}
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int sayi;
		System.out.print("Faktoriyeli alinacak sayiyi giriniz : ");
		sayi=scn.nextInt();
		int sonuc = Faktoriyel(sayi);
		System.out.println("Faktoriyel = "+sonuc);
	}
}
