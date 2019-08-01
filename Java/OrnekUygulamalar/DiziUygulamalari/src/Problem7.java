public class Problem7 {
	public static void main(String[] args) {
		int[] dizi = {1,2,3,4,5,6,7,8,9,10};
		int boyut = dizi.length;
		for(int i=0; i<boyut/2; i++)
		{
			int temp = dizi[i];
			dizi[i] = dizi[boyut-i-1];
			dizi[boyut-i-1] = temp;
		}
		
		for(int i=0; i<boyut; i++)
		{
			System.out.print("\t"+dizi[i]);
		}
	}
}
