public class Soru1 {
	public static void main(String[] args) {
		for(int n=1 ; n<= 20 ; n++)
		{
			long cullen = (long) (n*Math.pow(2,n) + 1);
			System.out.print("n="+n+"\t"+cullen);
			int bolen=0;
			for(long i=1;i<=cullen;i++)
			{
				if(cullen%i==0) bolen++;
			}
			if(bolen==2)
				System.out.print("\t\tASAL\n");
			else
				System.out.println();
		}
	}
}
