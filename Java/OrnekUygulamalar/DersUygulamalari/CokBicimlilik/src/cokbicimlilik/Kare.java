package cokbicimlilik;

public class Kare extends Sekiller
{
    private double kenaruzunlugu;
    Kare()
    {
        kenaruzunlugu=0;
    }
    Kare(double kenaruzunlugu)
    {
        setKare(kenaruzunlugu);
    }
    public double getKare()
    {
        return kenaruzunlugu;
    }
    private void setKare(double kenaruzunlugu)
    {
        this.kenaruzunlugu=kenaruzunlugu;
    }
    @Override
    public double alanHesabı()
    {
        return kenaruzunlugu*kenaruzunlugu;
    }
}
