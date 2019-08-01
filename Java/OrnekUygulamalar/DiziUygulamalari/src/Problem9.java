public class Problem9 {
	public static void main(String[] args) {
		int[] dizi = {1,2,3,4,5,6,7,8,9,10};
		int kucuk=dizi[0], buyuk=dizi[0];
		for(int i=0; i<dizi.length; i++)
		{
			if(dizi[i]<kucuk)
				kucuk=dizi[i];
			if(dizi[i]>buyuk)
				buyuk=dizi[i];
		}
		System.out.println("En kucuk deger : "+kucuk);
		System.out.println("En buyuk deger : "+buyuk);
	}
}
