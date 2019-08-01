package java_uygulamalari;

public class string_hece_silme_alistirmasi 
{
    public static void main(String[] args) 
    {
        char cumle[];
        cumle = new cumle("Babam ablami bakkala abur cubur almaya gonderdi");
        
        for(int i=0;i<cumle.length();i++)
        {
            if(cumle[i]=='a' && cumle[i+1]=='b')
                i++;
            else
                System.out.println(cumle[i]);
        }
    }
}
