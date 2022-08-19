namespace Ders08Classlar
{
    internal class Urun
    {
        public int Id;
        public string UrunAdi;
        public int Stok;
        public decimal Fiyat;
        public string Ozellikler;
        public Kategori Kategori; // Urun class ı ile kategori class ı arasında bağlantı
        public int KategoriId;
    }
}
