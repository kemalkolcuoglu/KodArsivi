public class Soru4 {
	public static int Collatz(int x)
	{
		if(x==1)
			return 1;
		else if(x%2==0)
			return Collatz(x/2);
		else
			return Collatz(3*x +1);
	}
	public static void main(String[] args) {
		for(int i=1 ; i<= 1000 ; i++)
		{
			System.out.println(i+"\tCollatz->\t"+Collatz(i));
		}
	}
}
