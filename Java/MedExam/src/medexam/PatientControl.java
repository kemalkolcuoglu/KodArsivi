package medexam;

public class PatientControl extends Control
{
    Patient ptmed = new Patient();          //  Patient Sinifinin cagrilmasi icin nesne olusturuldu
    
    public boolean id(String id)
    {
        boolean durum = false;
        int id_int=Integer.parseInt(id);
        if(id_int%100==0)
        {
            id_int++;
            durum = true;
        }
        return durum;
    }
    public boolean gc(char g)
    {
        boolean durum = false;
        
        if(g=='E'||g=='e'||g=='K'||g=='k')
            durum = true;
       return durum; 
    }
    public boolean hi(int h)
    {
        boolean durum = false;
        if(h>=0 && h<=4)
            durum = true;
       return durum; 
    }
    public boolean bd(String b)
    {
        boolean durum = false;
        
        int gun = Integer.parseInt(b.split("/")[0]);
        int ay = Integer.parseInt(b.split("/")[1]);
        int yil = Integer.parseInt(b.split("/")[2]);
           
        if((gun>0 && gun<=31)&&(ay>0 && ay<=12)&&(yil>1900&&yil<9999))
            durum = true;
        
       return durum; 
    }
    public boolean is(boolean i)
    {
        boolean durum = false;
        if(i==false||i==true)
            durum = true;
       return durum; 
    }
}