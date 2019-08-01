import java.util.Scanner;
public class Soru5 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int n;
		double ort=0,vry=0,ss=0;
		System.out.print("Ogrenci adetini (n) giriniz : ");
		n=scn.nextInt();
		int[] notlar = new int[n];
		for(int i=0;i<n;i++)
		{
			System.out.print((i+1)+". Not : ");
			notlar[i] = scn.nextInt();
			ort+=notlar[i];
		}
		ort/=n;
		for(int i=0;i<n;i++)
		{
			vry += Math.pow(ort-((double)notlar[i]), 2);
		}
		vry/=n;
		ss=Math.pow(vry, 1.0/2.0);
		System.out.println("Aritmetik Ortalama = "+ort);
		System.out.println("Varyans = "+vry);
		System.out.println("Standart Sapma = "+ss);
	}
}
