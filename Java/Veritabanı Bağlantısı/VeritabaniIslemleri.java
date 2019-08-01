package jt;

import java.sql.*;
import java.util.*;

public class VeritabaniIslemleri{
	public ArrayList<SayfaModel> VeriAl()
	{
		ArrayList<SayfaModel> liste = new ArrayList<SayfaModel>();
		try
		{
			Class.forName("com.mysql.jdbc.Driver");
			Connection con=DriverManager.getConnection("jdbc:mysql://localhost:3306/icerikyonetimsistemi","root","123456");
			Statement stmt = con.createStatement();
			ResultSet res = stmt.executeQuery("Select * From sayfalars");
			while(res.next())
			{
				SayfaModel sm = new SayfaModel();
				sm.setID(res.getInt(1));
				sm.setAd(res.getString(2));
				sm.setEtkin(res.getBoolean(4));
				
				liste.add(sm);
			}
			con.close();
		}
		catch(Exception exp)
		{
			System.out.println("Hata -> " + exp.getMessage());
		}
		return liste;
	}
}
