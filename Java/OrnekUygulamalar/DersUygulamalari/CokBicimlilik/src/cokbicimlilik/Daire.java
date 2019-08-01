package cokbicimlilik;

public class Daire extends Sekiller
{
    private double yaricap;
    Daire()
    {
        yaricap=0;
    }
    Daire(double yaricap)
    {
        setDaire(yaricap);
    }
    public double getDaire()
    {
        return yaricap;
    }
    private void setDaire(double yaricap)
    {
        this.yaricap=yaricap;
    }
    @Override
    public double alanHesabı()
    {
        return 2*Math.PI*yaricap;
    }
}
