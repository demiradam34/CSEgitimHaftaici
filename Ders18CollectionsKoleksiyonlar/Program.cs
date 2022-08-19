using System.Collections;
using System.Collections.Specialized;

namespace Ders18CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections - Koleksiyonlar!");

            //ArrayListKoleksiyon();
            //StringKoleksiyonu();
            //StringDictionaryKoleksiyonu();
            //DictionaryKoleksiyonu();
            StringListKullanimi();
        }
        static void ArrayListKoleksiyon()
        {
            //Koleksiyonlara farklı veri tiplerinden değerler atama
            int tamsayi = 10;
            double dabil = 18.8;
            ArrayList koleksiyon = new(); // Array = Dizi, ArrayList = Dizi Listesi
            koleksiyon.Add("Başkent Angara");
            koleksiyon.Add(tamsayi);
            koleksiyon.Add(dabil);
            for (int index = 0; index < koleksiyon.Count; index++)
            {
                Console.WriteLine(koleksiyon[index]);
            }
            foreach (var item in koleksiyon)
            {
                Console.WriteLine("Koleksiyondaki Değer : " + item);
            }
        }
        static void StringKoleksiyonu()
        {
            StringCollection strlist = new();//string içeriklerden oluşacak koleksiyonlara özel StringCollection sınıfını kullanabiliriz
            strlist.Add("Çankırı");
            strlist.Add("Angara");
            strlist.Add("İstanbul");
            foreach (var item in strlist)
            {
                Console.WriteLine(item);
            }
        }
        static void StringDictionaryKoleksiyonu()
        {
            StringDictionary liste = new();//string içeriklerden oluşacak koleksiyonlara özel StringDictionary sınıfını kullanabiliriz böylece verilere key ve value değerleri atanabilir
            liste.Add("18", "Çankırı");
            liste.Add("06", "Angara");
            liste.Add("34", "İstanbul");
            liste.Add("58", "Sivas");

            Console.WriteLine(liste["06"]);

            foreach (var item in liste.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in liste.Values)
            {
                Console.WriteLine(item);
            }
        }
        static void DictionaryKoleksiyonu()
        {
            Dictionary<string, string> dictionary = new();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Dictionary<int, string> liste = new();
            liste.Add(18, "Çankırı");
            liste.Add(58, "Sivas");
            liste.Add(34, "İstanbul");

            string kelime = "İstanbul";

            foreach (var item in liste)
            {
                Console.WriteLine(item.Value);
            }

        }
        static void StringListKullanimi()
        {
            List<string> sehirler = new(); // veri tipi string olan sehirler isminde liste oluşturduk
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Çankırı");

            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }

            List<User> users = new();

            users.Add(new User
            {
                Id = 1,
                Ad = "Taha",
                Soyad = "Yılmaz"
            });
            users.Add(new User
            {
                Id = 2,
                Ad = "Murat",
                Soyad = "Yılmaz"
            });

            foreach (var item in users)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad);
            }

            List<User> kullanicilar = new()
            {
                new User{ Id = 1, Ad = "Yunus", Soyad = "Kiraz" },
                new User{ Id = 2, Ad = "Muhammed", Soyad = "Musab" }
            };

        }
    }
}