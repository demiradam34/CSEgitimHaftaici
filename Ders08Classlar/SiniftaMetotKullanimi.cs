namespace Ders08Classlar
{
    public class SiniftaMetotKullanimi
    {
        public string mesaj = "";
        public SiniftaMetotKullanimi() // klavyeden ctor yazıp 2 kere tab a basarak oluşturduk
        {
            // Burası constructor (yapıcı-kurucu) metot: kurucu metotlar class lar new lendiği anda çalışan metotlardır. Böylece bir class dan nesne oluştuğu anda bir işlem yapmamızı sağlarlar.
            mesaj = "Kurucu metot çalıştı";
            Console.WriteLine(mesaj);
        }
        public void ToplamaYap() // class lar içerisinde metotlar tanımlayabiliriz böylece tekrar eden kodları toparlayıp kod tekrarını engelleyebiliriz.
        {
            Console.WriteLine(10 + 8);
        }
        public static void StatikToplamaYap(int sayi1, int sayi2) // Sınıflarda statik metot kullanımı
        {
            Console.WriteLine(sayi1 + sayi2); // parametreden gönderilecek sayıları topla ve sonucu ekrana yazdır
        }
        public static string StatikDegisken = "Statik değişkenlere sınıfadı.değişkenadı diyerek direk ulaşabiliriz";
    }
}
