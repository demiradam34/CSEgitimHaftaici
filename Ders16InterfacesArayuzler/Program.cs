namespace Ders16InterfacesArayuzler
{
    interface OrnekArayuz // Örnek interface
    {
        public int Id { get; set; } // interface içindeki prop
    }

    interface IDemo // interface isimleri I ile başlamalıdır
    {
        void Goster(); // Interface içerisinde örnek bir metot imzası
    }

    interface icerebilecekleri : IDemo // Bir interface başka bir interface den miras alabilir
    {
        public int Sayi1 { get; set; }
        int Sayi2 { get; set; }
        static int sayi2 { get; set; } // static öğe
        void Topla(); // void metot imzası
        void Topla(int sayi);
        int ToplamaYap(); // geriye int tipinde değer dönen metot imzası
        // İçeremedikleri
        // string metin; interfaceler değişken kabul etmez, sadece prop verebiliriz
        // interfacelerde classlardaki gibi constructor(kurucu metot olmaz)
    }
    class ArayuzKullanimi : icerebilecekleri // bir class a : ile interface den kalıtım alırsak artık o interface deki tüm imzaları class da kulanmamız gerekir.. Aksi halde interface in altı kızarır!
    {
        public int Id { get; set; }
        string degisken;
        public int Sayi1 { get; set; }
        int Sayi2 { get; set; }
        int icerebilecekleri.Sayi2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Goster()
        {
            Console.WriteLine("ArayuzKullanimi Goster metodu çalıştı");
        }

        public void Topla()
        {
            Console.WriteLine(10 + 8);
        }

        public void Topla(int sayi)
        {
            Console.WriteLine(10 + sayi);
        }

        public int ToplamaYap()
        {
            return 10 + 18;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces - Arayüzler!");
            // C# dilinde arayüz soyut bir veri tipidir. Sınıfa benzer şekilde bildirilir ancak içerdiği öğelerin tanımı değil yalnızca imzaları vardır.
            ArayuzKullanimi arayuz = new();
            arayuz.Sayi1 = 18;
            arayuz.Topla();

            Urun urun = new();
            urun.Add();
            urun.CreateDate = DateTime.Now;
            Console.WriteLine($"Ürün Eklenme Tarihi : {urun.CreateDate}");
            urun.Update();
            urun.Delete();
        }
    }

    interface ISinifGereksinimleri
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ChangeDate { get; set; }
        string User { get; set; }
    }

    interface IVeritabaniIslemleri // her class-sınıf için gerekli veritabanı metot imzaları
    {
        // Zorunlu Metot İmzaları
        void Add(); // ekleme
        void Update(); // güncelleme
        void Delete(); // silme
        void Get(); // kayıt getirme
        void GetAll(); // tüm kayıtları getirme
    }

    class Kategori : ISinifGereksinimleri, IVeritabaniIslemleri // 1 class a 1 den fazla interface den kalıtım alınacaksa interface ler arasına virgül konularak yan yana yazılır. Class larda bu şekilde bir çoklu kullanım yoktur!
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string User { get; set; }
        public bool Aktif { get; set; }

        public void Add()
        {
            Console.WriteLine();
        }

        public void Delete()
        {
            Console.WriteLine();
        }

        public void Get()
        {
            Console.WriteLine();
        }

        public void GetAll()
        {
            Console.WriteLine();
        }

        public void Update()
        {
            Console.WriteLine();
        }
    }

    class Urun : ISinifGereksinimleri, IVeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string User { get; set; }

        public decimal Fiyat { get; set; }

        public void Add()
        {
            Console.WriteLine("Ürün Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Ürün Silindi");
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("Ürün Güncellendi");
        }
    }

}