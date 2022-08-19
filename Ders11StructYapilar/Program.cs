namespace Ders11StructYapilar
{

    internal class Program
    {
        struct Yapi
        {
            internal string ad;
            //int sayi = 5; struct larda değişkenlere başlangıç değeri atanamaz!
            internal static int sayi = 5; // başlangıç değeri atamamız gerekirse static tanımlamalıyız!
            public string metin;
            internal void StructMetot()
            {
                Console.WriteLine("Struct içerisinde metot kullanımı");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Struct - Yapılar!");
            Yapi yapi = new();
            yapi.metin = "Struct içindeki metin değişkeni";
            yapi.ad = "Taha";
            Console.WriteLine(yapi.metin);
            Console.WriteLine("İsim : " + yapi.ad);
            yapi.StructMetot(); // Struct içindeki metot
            Console.WriteLine(Yapi.sayi); // static değişken kullanımı
        }
    }
}