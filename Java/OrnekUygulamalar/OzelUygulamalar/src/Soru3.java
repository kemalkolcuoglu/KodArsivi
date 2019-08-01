public class Soru3 {
	public static void main(String[] args) {
		for(int n=2 ; n<= 10000 ; n++)
		{
			int CT = 0;
			for(int i=1 ; i<n ; i++)
			{
				if(n%i==0)
					CT+=i;
			}
			if(CT%n==0)
				System.out.println(n);
		}
	}
}
