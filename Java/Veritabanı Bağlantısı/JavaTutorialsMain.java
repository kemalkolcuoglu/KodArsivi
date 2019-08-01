package jt;

import java.util.*;

public class JavaTutorialsMain {

	public static void main(String[] args) {
		VeritabaniIslemleri vt = new VeritabaniIslemleri();
		ArrayList<SayfaModel> al = vt.VeriAl();
		for (SayfaModel sayfaModel : al) {
			System.out.print(" ID -> " + sayfaModel.getID());
			System.out.print(" Ad -> " + sayfaModel.getAd());
			System.out.println(" Etkin -> " + sayfaModel.getEtkin());
		}
	}
}
