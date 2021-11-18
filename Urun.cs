sing System;

public class Urun
{
    int barkodNo;
    string urunAd;
    string urunAcıklama;
    int kategoriNo;
    int ureticiNo;
    int stokAdedi;
    double alısFiyati;
    double satisFiyati;


    public Urun (int v1 , string v2 , double v3)
    {
        this.UrunAd = v2;
        this.SatisFiyati = v3;
        this.BarkodNo = v1;


    }

    public int BarkodNo { get => barkodNo; set => barkodNo = value; }
    public string UrunAd { get => urunAd; set => urunAd = value; }
    public string UrunAcıklama { get => urunAcıklama; set => urunAcıklama = value; }
    public int KategoriNo { get => kategoriNo; set => kategoriNo = value; }
    public int UreticiNo { get => ureticiNo; set => ureticiNo = value; }
    public int StokAdedi { get => stokAdedi; set => stokAdedi = value; }
    public double AlısFiyati { get => alısFiyati; set => alısFiyati = value; }
    public double SatisFiyati { get => satisFiyati; set => satisFiyati = value; }
}

