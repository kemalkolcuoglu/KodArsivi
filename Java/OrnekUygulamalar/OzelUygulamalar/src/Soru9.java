import java.util.Random;
public class Soru9 {
	public static void main(String[] args) {
		int say = 0;
		Random rnd = new Random();
		while(true)
		{
			double x = rnd.nextInt(10);
			double y = rnd.nextInt(10);
			double z = rnd.nextInt(10);
			double dene = 10 + x + y / z + y * y + x / x;
			say++;
			if(dene == (int)dene && dene!=0.0)
			{
				System.out.println("x = "+x);
				System.out.println("y = "+y);
				System.out.println("z = "+z);
				System.out.println("Denklemin Sonucu = "+dene);
				System.out.println("Toplam "+say+" adimda bulundu!");
				break;
			}
		}
	}
}
