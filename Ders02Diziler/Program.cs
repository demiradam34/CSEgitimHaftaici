using System;

namespace Ders02Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziler!");

            int[] sayi; //Dizi oluşturma

            int[] ogrenciler = new int[6]; //Diğer dizi oluşturma yöntemi
            ogrenciler[0] = 100; // yazılımda genelde ilk eleman hep sıfırıncı elemandır
            ogrenciler[1] = 200;
            ogrenciler[2] = 200;
            ogrenciler[3] = 300;
            ogrenciler[4] = 400;
            ogrenciler[5] = 500;
            //ogrenciler[6] = 600; 6 elemanlı diziye 6 dan fazla eleman ekleyemeyiz! Eklersek hata alırız

            //ogrenciler[5] = 800;

            Console.WriteLine("Seçilen öğrenci no : " + ogrenciler[5]);

            ogrenciler[5] = 800;

            Console.WriteLine("Seçilen öğrenci no : " + ogrenciler[5]);

            string[] isimler = new string[5];

            isimler[0] = "Ali";
            isimler[1] = "Veli";
            isimler[2] = "Ayşe";
            isimler[3] = "Aylin";
            isimler[4] = "Mehmet";

            Console.WriteLine("Öğrenci Adı : " + isimler[1]);

            Console.WriteLine("2. Yöntem");
            
            int[] ogrenciler2 = { 100, 200, 300, 400, 500 };

            Console.WriteLine("Seçilen öğrenci no : " + ogrenciler2[1]);

            ogrenciler2[1] = 250;

            Console.WriteLine("Seçilen öğrenci no : " + ogrenciler2[1]);

            string[] kategoriler = { "Bilgisayar", "Monitör", "Klavye", "Mouse" };

            Console.WriteLine("Seçilen kategori : " + kategoriler[1]);
        }
    }
}
