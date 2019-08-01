import java.util.Scanner;
public class Problem13 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		double ort=0.0, sayi=0.0;
		int n=0;
		do{
			System.out.print("Bir sayi giriniz, cikmak icin 0 giriniz : ");
			sayi = scn.nextInt();
			if(sayi!=0)
			{
				ort+=1.0/sayi;
				n++;
			}
		}while(sayi!=0);
		
		ort = ((double)n) / ort;
		System.out.println("Harmonik Ortalama = "+ort);
	}
}
