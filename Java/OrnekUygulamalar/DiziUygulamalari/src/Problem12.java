public class Problem12 {
	public static void main(String[] args) {
		int[] s = {22,36,12,44,56,96,34,23,47,85,76,13,19,45,48,53};
		int tek=0,cift=0,asal=0;
		for(int i=0; i<s.length; i++)
		{
			int sayi=s[i];
			if(sayi%2==0)
				cift++;
			int bolen=0;
			for(int j=1;j<=sayi;j++)
			{
				if(sayi%j==0)
					bolen++;
			}
			if(bolen==2)
				asal++;
		}
		tek = s.length - cift;
		System.out.println("Toplam Cift Sayi = "+cift);
		System.out.println("Toplam Tek Sayi = "+tek);
		System.out.println("Toplam Asal Sayi = "+asal);
	}
}
