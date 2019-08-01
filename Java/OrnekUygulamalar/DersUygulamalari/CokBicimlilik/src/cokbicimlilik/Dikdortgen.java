package cokbicimlilik;

public class Dikdortgen extends Sekiller
{
    private double en;
    private double boy;
    Dikdortgen()
    {
        en=0;
        boy=0;
    }
    Dikdortgen(double en,double boy)
    {
        this.en=en;
        this.boy=boy;
    }
    
    @Override
    public double alanHesabı()
    {
        return en*boy;
    }
}
