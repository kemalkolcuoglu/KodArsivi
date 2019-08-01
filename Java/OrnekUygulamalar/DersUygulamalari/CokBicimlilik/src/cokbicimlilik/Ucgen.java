package cokbicimlilik;

public class Ucgen extends Sekiller
{
    private double taban;
    private double yukseklik;
    Ucgen()
    {
        taban=0;
        yukseklik=0;
    }
    Ucgen(double taban,double yukseklik)
    {
        setTaban(taban);
        this.yukseklik=yukseklik;
    }
    public double getTaban()
    {
        return taban;
    }
    private void setTaban(double taban)
    {
        this.taban=taban;
    }
    
    @Override
    public double alanHesabı()
    {
        return (taban*yukseklik)/2;
    }
}
