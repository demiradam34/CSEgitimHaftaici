namespace Ders10OzgenlerProperties
{
    class Skorlar
    {
        private int skor;
        public int Skor // klasik property yapısı
        {
            get { return skor; } // get bloğu yukarıdaki skor değişkeninin değerini döndürür
            set { skor = value; } // set bloğu ise yukarıdaki skor değişkenine değer atamayı sağlar
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Özgenler-Properties!");

            Skorlar skorlar = new();
            skorlar.Skor = 5; //skorlar nesnesinin Skor özelliğine değer ata (Set bloğu çalışır) 

            Console.WriteLine("Skor Değeri : " + skorlar.Skor); // skorlar nesnesinin Skor özelliğinin değerini oku ve ekrana yaz(Get bloğu çalışır)

            Kisi Taha = new Kisi();
            Taha.DogumYeri = "İstanbul";
            Taha.Maas = 2825;
            Taha.Yas = 15;

            Kisi Betul = new()
            {
                DogumYeri = "Angara",
                Maas = 5000,
                Yas = 25
            };

            Console.WriteLine("Taha nın Bilgileri:");
            Console.WriteLine($"Doğum Yeri:{Taha.DogumYeri} - Yaş : {Taha.Yas} - Maaş : {Taha.Maas}");

            Console.WriteLine("Betülün Bilgileri:");
            Console.WriteLine($"Doğum Yeri:{Betul.DogumYeri} - Yaş : {Betul.Yas} - Maaş : {Betul.Maas}");

            User user = new();
            user.Email = "info@admin.co";
            user.Password = "123456";
            user.Name = "Taha";
            user.CreateDate = DateTime.Now;

            Console.WriteLine("Email Giriniz:");
            var email = Console.ReadLine();
            user.Email = email;
            Console.WriteLine("Şifrenizi Giriniz:");
            user.Password = Console.ReadLine();

            var giris = user.KullaniciGiris(user.Email, user.Password); // var variable yani değişken demek ve veri türünü kendisine atanan değere bakarak otomatik belirleyen değişken oluşturmamızı sağlar.
            var sayi = 18;
            var fiyat = 18.58;
            object deger = 25;
            var urunAdi = "Bardak";

            if (giris == true) // Eğer giriş metodunun sonucu true ise
            {
                Console.WriteLine("Giriş Başarılı!");
            }
            else Console.WriteLine("Giriş Başarısız!");
        }
    }
}