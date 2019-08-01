package medexam;

import java.io.*;

public class Patient
{
    PatientControl control = new PatientControl();   //  PatientControl Sinifinin cagrilmasi icin nesne olusturuldu
    
    private String Patient_ID;                   //  Degiskenlerimiz tanimlandi
    private String Name;
    private String Surname;
    private char Gender;
    private int HealthInsurance;
    private String BirthDate;
    private boolean Is_Student;
    
    public Patient()                            //Control.java icin kullanilan Yapici Methot
    {
        Patient_ID = "0";
        Name = "Ad Girilmedi";
        Surname = "Soyad Girilmedi";
        Gender = '0';
        HealthInsurance = 0;
        BirthDate = "00/00/0000";
        Is_Student = false;
    }
    
    public Patient(String Patient_ID,String Name,String Surname,char Gender,int HealthInsurance)
    {
        this.Patient_ID = Patient_ID;
        this.Name = Name;                       // Yesil Kart Sigortalilar icin olusturulmus Yapici Methot
        this.Surname = Surname;
        this.Gender = Gender;
        this.HealthInsurance = HealthInsurance;
    }
    public Patient(String Patient_ID,String Name,String Surname,char Gender,int HealthInsurance,String BirthDate,boolean Is_Student)
    {
        this.Patient_ID = Patient_ID;
        this.Name = Name;
        this.Surname = Surname;
        this.Gender = Gender;                   //  Asil Yapici Methotumuz
        this.HealthInsurance = HealthInsurance;
        this.BirthDate = BirthDate;
        this.Is_Student = Is_Student;
    }
    public String getPatient_ID()
    {
        return Patient_ID;                      //  ID Degeri tanımlama
    }
    public void setPatient_ID(String Patient_ID)
    {
        if(control.id(Patient_ID)==true)                 //  Kontrol Sinifi Cagriliyor
            this.Patient_ID = Patient_ID; 
    }
    public String getName()
    {
        return Name;                            //  Ad tanimlaniyor
    }
    public void setName(String Name)
    {
        this.Name = Name;
    }
    public String getSurname()
    {
        return Surname;                         //  Soyad tanimlaniyor
    }
    public void setSurname(String Surname)
    {
        this.Surname = Surname;
    }
    public char getGender()
    {
        return Gender;                          //  Cinsiyet tanimlaniyor
    }
    public void setGender(char Gender)
    {
        if(control.gc(Gender)==true)                     //  Kontrol Sinifi Cagriliyor
            this.Gender = Gender; 
    }
    public int getHealthInsurance()
    {
        return HealthInsurance;                 //  Sigorta tanimlaniyor
    }
    public void setHealthInsurance(int HealthInsurance)
    {
        if(control.hi(HealthInsurance)==true)          //  Kontrol Sinifi Cagriliyor
            this.HealthInsurance = HealthInsurance;
    }
    public String getBirthDate()
    {
        return BirthDate;                       //  Dogum Tarihi tanimlaniyor
    }
    public void setBirthDate(String BirthDate)
    {
        if(control.bd(BirthDate)==true)                  //  Kontrol Sinifi Cagriliyor
            this.BirthDate = BirthDate;
    }
    public boolean getIs_Student()
    {
        return Is_Student;                      //  Ogrenim Durumu tanimlaniyor
    }
    public void setIs_Student(boolean Is_Student)
    {
        if(control.is(Is_Student)==true)                 //  Kontrol Sinifi Cagriliyor
            this.Is_Student = Is_Student;
    }
    
    public float muayeneUcreti(char Gender,int HealthInsurance,String BirthDate,boolean Is_Student) 
    {
        int yil = Integer.parseInt(BirthDate.split("/")[2]);
        
        float fiyat=100;                        //  Muayene Fiyati Tanimlandi
        if(HealthInsurance==1||HealthInsurance==3)
        {
            fiyat-=fiyat*0.4;                   //  SGK,GSS icin indirim
        }
        if(HealthInsurance==4)
        {
            fiyat-=(fiyat*0.6);                 //  Ozel Sigorta icin indirim
        }
        if((Gender=='E'||Gender=='e')&&(Is_Student==true)&&(yil<1998))
        {
            fiyat-=(fiyat*0.2);                 //  Erkek, Ogrenci ve 18 yasindan buyukler icin indirim
        }
        if((Gender=='E'||Gender=='e')&&(Is_Student==true)&&(yil>1998))
        {
            fiyat-=(fiyat*0.3);                 //  Erkek, Ogrenci ve 18 yasindan kucukler icin indirim
        }
        if((Gender=='K'||Gender=='k')&&(Is_Student==true)&&(yil>1991))
        {
            fiyat-=(fiyat*0.3);                 //  Kadin, Ogrenci ve 25 yasindan kucukler icin indirim
        }
        if((Gender=='K'||Gender=='k')&&(Is_Student==false)&&(yil<1991))
        {
            fiyat-=(fiyat*0.2);                 //  Erkek, Ogrenci ve 25 yasindan buyukler icin indirim
        }
        if(HealthInsurance==2)
	{
            fiyat=0;                            //  Yesil Kart icin indirim
	}
        System.out.print(fiyat);
        return fiyat;
    }
    //=================================================================
    
    public void Dosyalama() throws IOException
    {
        File dosya = new File ("C:/hasta.txt");
        dosya.createNewFile();
        FileWriter dYaz = new FileWriter(dosya);
        dYaz.write(getPatient_ID());
        dYaz.write("#"+getName());
        dYaz.write("#"+getSurname());
        dYaz.write("#"+getGender());
        dYaz.write("#"+getHealthInsurance());
        dYaz.write("#"+getBirthDate());
        dYaz.write("#"+getIs_Student());
    }
}