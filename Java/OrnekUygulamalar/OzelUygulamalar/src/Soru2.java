public class Soru2 {
	public static void main(String[] args) {
		for(int n=0 ; n<= 4 ; n++)
		{
			long fermat = (long) (Math.pow(2, Math.pow(2, n)) + 1);
			System.out.println("n="+n+"\t"+fermat);
		}
	}
}
