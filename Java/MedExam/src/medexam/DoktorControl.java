package medexam;

public class DoktorControl extends Control
{
    public boolean id(String id)
    {
        boolean durum = false;
        int id_int=Integer.parseInt(id);
        if(id_int%100==0)
        {
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
    public boolean diplo(String diplo)
    {
        char dizi [] = new char[6];
        for(int i=0;i<6;i++)
        {
            dizi[i]=diplo.charAt(i);
        }
        boolean durum = false;
        if(dizi[2]=='-')
        {
            durum=true;
        }
        return durum;
    }
}
