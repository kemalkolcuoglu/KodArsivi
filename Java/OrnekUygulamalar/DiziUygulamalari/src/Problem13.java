import java.util.Scanner;
public class Problem13 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		System.out.print("Kelime giriniz : ");
		String kelime = scn.next();
		int[] s = new int[26];
		for(int i=0; i<kelime.length(); i++)
		{
			s[((int)kelime.charAt(i))-97]++;
		}
		for(int i=0;i<s.length;i++)
		{
			if(s[i]!=0)
				System.out.println(((char)(i+97)) + "\t" + s[i]);
		}
	}
}
