package medexam;

import java.io.*;

public class Doctor
{
    DoktorControl drc = new DoktorControl();
    
    private String Doctor_ID;
    private String Name;
    private String Surname;
    private char Gender;
    private String DiplomaNo;
    private int Department_ID;
    
    public Doctor()
    {
        Doctor_ID = "00";
        Name = "Ad Girilmedi";
        Surname = "Soyad Girilmedi";
        Gender = '0';
        DiplomaNo = "NN-NNNN";
        Department_ID = 0;           
    }
    
    public Doctor(String Doctor_ID,String Name,String Surname,char Gender,String DiplomaNo,int Department_ID)
    {
        this.Doctor_ID = Doctor_ID;
        this.Name = Name;                       
        this.Surname = Surname;
        this.Gender = Gender;
        this.DiplomaNo = DiplomaNo;
        this.Department_ID = Department_ID;
    }
    
    public String getDoctor_ID()
    {
        return Doctor_ID;                      //  ID Degeri tanımlama
    }
    public void setDoctor_ID(String Doctor_ID)
    {
        if(drc.id(Doctor_ID)==true)                 //  Kontrol Sinifi Cagriliyor
            this.Doctor_ID = Doctor_ID; 
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
        if(drc.gc(Gender)==true)                     //  Kontrol Sinifi Cagriliyor
            this.Gender = Gender; 
    }
    public String getDiplomaNo()
    {
        return DiplomaNo;                         
    }
    public void setDiplomaNo(String DiplomaNo)
    {
        if(drc.diplo(DiplomaNo)==true)
            this.DiplomaNo = DiplomaNo;
    }
    public int getDepartment_ID()
    {
        return Department_ID;                 
    }
    public void Department_ID(int Department_ID)
    {
        this.Department_ID = Department_ID;
    }
    //=========================================================================
    public void Dosyalama() throws IOException
    {
        File dosya = new File ("C:/DoktorKayıt.txt");
        dosya.createNewFile();
        FileWriter dYaz = new FileWriter(dosya);
        dYaz.write(getDoctor_ID());
        dYaz.write("#"+getName());
        dYaz.write("#"+getSurname());
        dYaz.write("#"+getGender());
        dYaz.write("#"+getDiplomaNo());
        dYaz.write("#"+getDepartment_ID());
    }
}
