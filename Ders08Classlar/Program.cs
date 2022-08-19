// See https://aka.ms/new-console-template for more information
//using Ders08Classlar;

public class Ev // C# ta class tanımlama
{
    public int KapiNo; // Sınıf değişkenleri oluşturma
    public string SokakAdi;
}

namespace Ders08Classlar // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar-Classes!");

            // 1. Yöntem
            Ev ev = new(); // ev sınıfından bir nesne oluşturduk

            ev.KapiNo = 1; // ev nesnesinin değişkenlerine değer atadık
            ev.SokakAdi = "Okul sokak";

            Console.WriteLine("Ev adresimiz : " + ev.SokakAdi + " sk. No :" + ev.KapiNo); // ev nesnesinin özelliklerini ekrana yazdırdık

            //2. Yöntem
            Ev yazlik = new()
            {
                SokakAdi = "Yalı kavak sokak",
                KapiNo = 18
            };

            Console.WriteLine($"Yazlık adresi : {yazlik.SokakAdi} sk. No:{yazlik.KapiNo} Bodrum/Muğla");

            Kurs kurs = new()
            {
                KursAdi = "Arı Bilgi",
                EgitimAdi = "Yazılım Uzmanlığı",
                KapiNo = 102,
                SinifMevcudu = 6
            };

            Console.WriteLine("Kurs Bilgilerim \n : Kurs Adı {0} Eğitim Adı : {1} Kapı No : {2}", kurs.KursAdi, kurs.EgitimAdi, kurs.KapiNo);

            Araba araba = new()
            {
                KasaTipi = "Sedan",
                Marka = "Fiat",
                Model = "Linea",
                Renk = "Beyaz",
                UretimYili = 2013
            };

            Console.WriteLine($"Araba Bilgilerimiz : \n Marka : {araba.Marka} \n Model : {araba.Model} \n Renk : {araba.Renk} ");

            Urun urun = new()
            {
                Fiyat = 99,
                Ozellikler = "Işıklı klavye",
                Stok = 18,
                UrunAdi = "Oyuncu klavye"
            };

            Console.WriteLine("Ürün Bilgileri");
            Console.WriteLine($"Ürün Adı : {urun.UrunAdi}");
            Console.WriteLine($"Ürün Fiyatı : {urun.Fiyat}");
            Console.WriteLine($"Ürün Stok : {urun.Stok}");
            Console.WriteLine($"Ürün Özellikler : {urun.Ozellikler}");

            Console.WriteLine();
            Console.WriteLine("Sınıfta Metot Kullanımı");
            SiniftaMetotKullanimi siniftaMetotKullanimi = new();
            siniftaMetotKullanimi.ToplamaYap();
            //Console.WriteLine(siniftaMetotKullanimi.mesaj);
            // Static olarak belirtilmeyen metot ve değişkenler dinamiktir.
            // Sınıfların içindeki Dinamik metot ve değişkenlere ulaşmak için yukarıdaki gibi new leyerek nesne oluşturmamız gerekir.

            SiniftaMetotKullanimi.StatikToplamaYap(18, 18); // statik metoda direk class adı.metot adı şeklinde erişebiliriz, nesneye(siniftaMetotKullanimi) ihtiyacmız yok!
            Console.WriteLine(SiniftaMetotKullanimi.StatikDegisken);
        }
    }
}

public class Kurs
{
    public int KapiNo;
    public string KursAdi;
    public string EgitimAdi;
    public int SinifMevcudu;
}

public class Araba
{
    public string Marka;
    public string Model;
    public string Renk;
    public string KasaTipi;
    public int UretimYili;
}