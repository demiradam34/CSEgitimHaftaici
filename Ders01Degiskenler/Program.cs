//using System; // Burası açıklama satırıdır ve sistem tarafından kod olarak görülmez
//Yukarıdaki using System; alanı aşağıda sistem kütüphanesi içindeki yapıları kullanabilmemizi sağlar.

using System;

namespace Ders01Degiskenler // namespace alanı genellikle proje ile aynı isimde olur ve bu projenin başka projelerde referans olarak kullanılabilmesini sağlar
{
    class Program // C# nesne yönelimli bir programlama dilidir ve her şey nesneler ile tanımlanabilir. Nesneler ise sınıflar kullanılarak oluşturulur.
    {
        static void Main(string[] args) // Main bir console uygulamasının çalışan ana metodudur. Starta bastığımızda ilk olarak main metodu içerisindeki kodlar çalışır.
        {
            Console.WriteLine("Hello World!"); // burası ekrana yazı yazdırmamızı sağlayan metodumuz.
            Console.WriteLine();
            Console.WriteLine("Merhaba Dünya!");
            /*
             * Burası çoklu yorum satırı
             * Bu şekilde
             * C# ta çoklu yorum satırı yazabiliriz
             */
            // Heap - Stack
            // C# ta 2 tip yapı vardır
            // 1- Değer Tipler (Stack te tutulur)
            // 2- Referans Tipler (Bellekte heap bölgesinde tutulur, sınıflar(class) ve string değişkenler burada tutulur)

            // C# ta Değişken Tanımlama

            // Tam sayı veri tipleri

            byte plaka_kodu; // Değişken oluşturmak için önce veri tipini sonra değişken adını yazarız. ; ise derleyiciye kodun bittiğini ifade eder. byte 0-255 arasında tam sayı taşıyabilir.
            plaka_kodu = 34; // değişkene değer atama işlemi = operatörü ile gerçekleşir ve eşitliğin sağ tarafındaki değer soldaki değişkene aktarılır.
            sbyte sbyteveri = 18; // değişkeni oluşturduğumuz anda da değerini tanımlayabiliriz. sbyte -128 ile +127 arasında değer taşıyabilir.
            sbyte dolar = -128; // sınırların dışına çıkarsak hata oluşur
            short kisaTamSayi = 1984;
            ushort ortaTamSayi = 12345;
            int tamSayi = 123456789;
            uint uzunTamSayi = 1234567898;
            long upuzunTamSayi = 1234567898765;
            ulong enUzunTamSayi = 12345678987654321;

            // Kesirli sayı veri tipleri
            float kesirliSayi = 34.18f;// float veri tipinde sayının sonuna f harfi eklenir. 4 byte yer kaplar, 6-7 basamak sayı alabilir.
            double kesirli_sayi = 34.18; // double veri tipi 8 byte yer kaplar, 15-16 basamak sayı alabilir.

            // Decimal veri tipi
            decimal urunFiyati = 999; // 12 byte yer kaplar 2-29 basamağa kadar destekler, fiyat hesaplama gibi hassas verilerde kullanılması tavsiye edilir.

            // Char veri tipi
            char karakter = 'c'; // sadece 1 karakter veri tutar

            // string veri tipi (referans tip)
            string metin = "string veri tipi ile klavyeden girilen tüm karakterleri dilediğimiz gibi tutabiliriz!";

            Console.WriteLine(metin); // metin değişkenini ekrana yazdır

            metin = "burada metin içeriği değişti";

            Console.WriteLine(metin);

            // Boolean veri türü : true ve false olarak 2 değer alır, 1 byte lık yer kaplar
            bool urunDurumu = true; // ürün satışta
            bool haberDurumu = false; // haber yayında değil

            // C# ta sabit tanımlama
            const int kdv = 18; // sabitlerde oluşturduğumuz anda değerini atamalıyız
            const int iskonto = 25;
            //kdv = 8; // const ile oluşturulan sabitin değeri sonradan değiştirilemez!

        }
    }
}
