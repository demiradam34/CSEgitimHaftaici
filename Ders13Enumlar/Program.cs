namespace Ders13Enumlar
{
    /* Enum(Numaratör) lar nesneleri numaralandırmak için kullanılır
             * Enum tipler üzerindeki kısıtlar
             * 1-Enum blokunda metot tanımlanamaz
             * 2-Arayüz(Interface) kullanamazlar
             * 3-enum blokunda property kullanılmaz
             */
    enum Aylar : byte//byte koleksiyondaki numaraların veri tipinin byte türünden olacağını belirtiyor
    {
        Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
    }
    enum MesajTuru
    {
        Bilgi, Öneri, Şikayet, Talep, Arıza
    }
    enum SiparisDurumu
    {
        Hazırlanıyor, Hazırlandı, KargoBekleniyor, KargoyaVerildi
    }
    enum Meyveler : int
    {
        Elma = 3, Armut = 7, Çilek = 1
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumlar!");

            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine("Armut = {0}, Elma={1}, Çilek={2}", a, b, c);

            int SiparisDurum = 1;
            if (SiparisDurum == 0) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.Hazırlanıyor);
            if (SiparisDurum == 1) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.Hazırlandı);
            if (SiparisDurum == 2) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.KargoBekleniyor);
            if (SiparisDurum == 3) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.KargoyaVerildi);

        }
    }
}