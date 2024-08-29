using System;

public class Kitap
{
    // Özellikler (Properties)
    public string Ad { get; set; }
    public string YazarAd { get; set; }
    public string YazarSoyad { get; set; }
    public int SayfaSayisi { get; set; }
    public string Yayinevi { get; set; }
    public DateTime KayitTarihi { get; set; }

    // Default Constructor
    public Kitap()
    {
        KayitTarihi = DateTime.Now; // Kayıt tarihi otomatik olarak şu anki tarih ve saat olarak atanır
    }

    // Parametreli Constructor
    public Kitap(string ad, string yazarAd, string yazarSoyad, int sayfaSayisi, string yayinevi)
    {
        Ad = ad;
        YazarAd = yazarAd;
        YazarSoyad = yazarSoyad;
        SayfaSayisi = sayfaSayisi;
        Yayinevi = yayinevi;
        KayitTarihi = DateTime.Now; // Kayıt tarihi otomatik olarak şu anki tarih ve saat olarak atanır
    }
}
