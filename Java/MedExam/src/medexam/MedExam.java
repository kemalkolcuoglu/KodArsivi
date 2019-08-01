package medexam;
import java.io.*;
import java.util.Scanner;

public class MedExam 
{   
    public static void main(String[] args) throws IOException
    {
        Patient pt = new Patient();
        Doctor dr = new Doctor();
        
        Scanner giris = new Scanner (System.in);
        
        pt.Dosyalama();
        dr.Dosyalama();
        
        /*pt.hastaKayit();
        pt.dosyalamaBitir();
        pt.dosyaAc();
        pt.kayitOku();*/
    }
}
