public class Program
{
    public static void Main()
    {
        // Parametreli constructor kullanarak kitap nesnesi oluşturulması
        Kitap ayseKulinKitap = new Kitap("Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

        // Default constructor kullanarak kitap nesnesi oluşturulması
        Kitap defaultKitap = new Kitap();
        defaultKitap.Ad = "Ateşi Yakalamak";
        defaultKitap.YazarAd = "Suzanne";
        defaultKitap.YazarSoyad = "Collins";
        defaultKitap.SayfaSayisi = 448;
        defaultKitap.Yayinevi = "DEX";

        // Kitap bilgilerini ekrana yazdırmak
        Console.WriteLine($"Kitap Adı: {ayseKulinKitap.Ad}");
        Console.WriteLine($"Yazar Adı: {ayseKulinKitap.YazarAd}");
        Console.WriteLine($"Yazar Soyadı: {ayseKulinKitap.YazarSoyad}");
        Console.WriteLine($"Sayfa Sayısı: {ayseKulinKitap.SayfaSayisi}");
        Console.WriteLine($"Yayınevi: {ayseKulinKitap.Yayinevi}");
        Console.WriteLine($"Kayıt Tarihi: {ayseKulinKitap.KayitTarihi}");

        Console.WriteLine("\nDefault Constructor ile oluşturulan kitap:");
        Console.WriteLine($"Kitap Adı: {defaultKitap.Ad}");
        Console.WriteLine($"Yazar Adı: {defaultKitap.YazarAd}");
        Console.WriteLine($"Yazar Soyadı: {defaultKitap.YazarSoyad}");
        Console.WriteLine($"Sayfa Sayısı: {defaultKitap.SayfaSayisi}");
        Console.WriteLine($"Yayınevi: {defaultKitap.Yayinevi}");
        Console.WriteLine($"Kayıt Tarihi: {defaultKitap.KayitTarihi}");
    }
}