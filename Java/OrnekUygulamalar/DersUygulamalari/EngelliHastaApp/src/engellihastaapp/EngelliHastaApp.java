/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package engellihastaapp;

/**
 *
 * @author HSYNPC
 */
public class EngelliHastaApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Hasta patient=new Hasta(1905,"Metin","OKTAY"); //2Puan
        System.out.println("Hasta TC:"+patient.getTC()+" Hasta Adı ve Soyadı:"+ patient.Ad +" "+ patient.Soyad + " Ucret:"+ patient.Ucret_Hesapla(2)); //2 puan
        EngelliHasta dis_patient=new EngelliHasta(10,"Gheorghe","HAGI",2); //2Puan
        dis_patient.Ucret_Hesapla(2); // 4 puan
        System.out.println("Hasta TC:"+dis_patient.getTC()+" Hasta Adı ve Soyadı:"+ dis_patient.Ad +" "+ dis_patient.Soyad + " Ucret:"+ dis_patient.Indirim_Hesapla()); //2Puan
    }

}

class Hasta {

    private int TC;
    String Ad;
    String Soyad;
    protected double ucret;
    Hasta(int TC, String Ad, String Soyad) { // 3Puan
        this.TC = TC;
        this.Ad = Ad;
        this.Soyad = Soyad;
    }
    int getTC()//2 Puan
    {
        return TC; 
    }
    double Ucret_Hesapla(int Bolum_Id) { // 5Puan
        if(Bolum_Id==1) ucret=60; //KBB
        else if(Bolum_Id==2) ucret=70; //GÖZ
        else if(Bolum_Id==3) ucret=50; //DAHİLİYE
        else System.out.println("Yanlış bölüm ID'si girdiniz");
        
        return ucret;
    }
}

class EngelliHasta extends Hasta {

    int Engel_Derece;
    EngelliHasta(int TC, String Ad, String Soyad, int Engel_Derece) { //8Puan
        super(TC, Ad, Soyad); 
        this.Engel_Derece = Engel_Derece;
    }

     double Indirim_Hesapla()
    {
       double indirim=0;
       if(Engel_Derece==1) indirim=0.8;
       else if(Engel_Derece==2) indirim=0.6;
       else if(Engel_Derece==3) indirim=0.4;
       else System.out.println("Yanlış bir engel derecesi girdiniz");   //5Puan
           
      return this.ucret*indirim;// 5Puan
    }
            
}
