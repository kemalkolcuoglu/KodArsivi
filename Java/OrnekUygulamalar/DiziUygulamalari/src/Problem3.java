public class Problem3 {
	public static void main(String[] args) {
		int[] Dizi = {2,5,12,17,8,9,1,33};
		int T=0;
		for(int i=0; i<Dizi.length; i++)
		{
			T+=Dizi[i];
			System.out.print(Dizi[i]+"+");
		}
		System.out.print(" = "+T);
	}
}
