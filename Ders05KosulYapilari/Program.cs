using System;

namespace Ders05KosulYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koşul(Karar) Yapıları!");

            Console.WriteLine("Bir sayı girip enter a basınız!");
            /*
            var s = Console.ReadLine(); //var anahtar kelimesi değişken oluşturmak için kullanılır ve oluşan değişkene atanan değerin veri tipine göre değişkenin tipini otomatik belirler. Console.ReadLine() metodu ekrandaki satırdan girilen değeri okur

            int sayi = Convert.ToInt32(s);

            if (sayi > 0) // eğer sayı 0 dan büyükse
            {
                // Buradaki kodları çalıştır
                Console.WriteLine("Girilen sayı 0 dan büyük!");
            }
            else if (sayi == 0) // yukardaki şart değilse eğer sayı 0 e eşit mi
            {
                Console.WriteLine("Girilen sayı 0");
            }
            else // yukardakilerden hiçbiri değilse
            {
                Console.WriteLine("Negatif sayı girdiniz!");
            }
            */
            // Örnek 2
            /*
            Console.WriteLine("Kullanıcı Adınızı Giriniz");
            string kullaniciadi = Console.ReadLine();//Console.ReadLine() metodu ekrandan girilen değeri yakalar ve kullaniciadi değişkenine atar
            Console.WriteLine("Şifrenizi Giriniz");
            string sifre = Console.ReadLine();//Console.ReadLine() metodu ekrandan girilen değeri yakalar ve sifre değişkenine atar
            string veritabanindakiKullaniciAdi = "admin";
            string veritabanindakiSifre = "123456";

            if (kullaniciadi == veritabanindakiKullaniciAdi && sifre == veritabanindakiSifre)
            {
                Console.WriteLine("Sisteme giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı Bulunamadı!");
            }
            Console.Read();
            */
            
            // Örnek 3
            int saat = DateTime.Now.Hour; // geçerli zamanın saat bilgisini alıp saat değişkenine atadık
            int dakika = DateTime.Now.Minute;
            if (saat < 20)
            {
                Console.WriteLine("Saat : "  + saat + ":" + dakika + " İyi Günler Üstat Splinter");
            }
            /*else Console.WriteLine("Saat : " + saat + " İyi Akşamlar Çekirge"); // Eğer tek satırlık bir kod yazacaksak süslü parantez kullanmak zorunda değiliz!
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            */
            Console.WriteLine("Ternary Operatörü ile if else yazmadan ");
            Console.WriteLine((saat < 20) ? "İyi Günler" : "İyi Akşamlar"); // Eğer sadece if ve else kullanacaksak bu operatörle daha kısa bir kodla işimizi çözebiliriz. Burada şartı (saat < 20) ? kısmı belirler burası if şartı olarak çalışır. : karakterinden sonraki bölüm ise değilse yani else kısmıdır

            int ay = DateTime.Now.Month;
            Console.WriteLine("Ay Değeri : " + ay);
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimi");
                    break;
                default:
                    Console.WriteLine("Yanlış bilgi.");
                    break;
            }

        }
    }
}
