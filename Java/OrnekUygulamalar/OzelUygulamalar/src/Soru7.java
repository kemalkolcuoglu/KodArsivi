import java.util.Scanner;
public class Soru7 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("Kelime Giriniz : ");
		String s = scn.next();
		boolean durum = true;
		for(int i=0;i<s.length()/2;i++)
		{
			if(s.charAt(i) != s.charAt(s.length()-i-1))
				durum=false;
		}
		if(durum==true)
			System.out.print("Palindrome bir kelime girdiniz");
		else
			System.out.print("Palindrome olmayan bir kelime girdiniz");
	}
}