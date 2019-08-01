import java.util.Scanner;
public class Problem18 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int sayi, t=0;
		System.out.print("Bir sayi giriniz : ");
		sayi=scn.nextInt();
		
		for(int i=1; i<=sayi; i++)
		{
			if(sayi%i==0)
			{
				t++;
			}
		}
		
		if(t==2)
		{
			System.out.println(sayi+" bir asal sayidir");
		}
		else
		{
			System.out.println(sayi+" bir asal sayi degildir");
		}
	}
}
