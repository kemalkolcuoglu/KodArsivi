import java.util.Scanner;
public class Problem10 {
	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		String kelime,yeni="";
		System.out.print("Kelime giriniz : ");
		kelime = scn.next();
		for(int i=0; i<kelime.length(); i++)
		{
			yeni+=(char)(((int)kelime.charAt(i))+15);
		}
		System.out.println("Sifreli Kelime : "+yeni);
	}
}
