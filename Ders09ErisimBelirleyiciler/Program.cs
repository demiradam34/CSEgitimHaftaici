// See https://aka.ms/new-console-template for more information


/*C# nesne yönelimli bir programlama dili olduğu için her şey sınıflar içinde tanımlanır.
     sınıflara ve sınıf öğelerine erişim kısıtlanabilir veya belirli düzeylerde erişime izin verilebilir.
     Öğelere erişimi kısıtlayan ya da yetki veren anahtar sözcüklere "Erişim Belirteçleri" (acces modifiers) denir.
     *Erişim belirteçleri 4 ana sınıfa ayrılır
     * public    : Erişim kısıtı yoktur, her yerden erişilebilir
     * protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
     * internal  : Etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez
     * private   : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
     * Bir öğe yalnızca 1 erişim belirteci alabilir
     * namespace erişim belirteci almaz çünkü o daima public tir
     * Sınıflar public yada internal nitelemesi alabilirler ama protected yada private nitelemesi alamazlar
     * enum erişim belirteci almaz çünkü daima public tir
     */

using Ders08Classlar;

public class Deneme
{
    public string urunAdi = "Bu değişkene herkes erişebilir public olduğu için";
}

internal class Test
{
    string urunAdi = "Klavye";
}

namespace Ders09ErisimBelirleyiciler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erişim Belirleyiciler!");

            Kullanici kullanici = new();
            kullanici.Adi = "Taha";
            kullanici.Soyadi = "Çağlar";
            //kullanici.

            Console.WriteLine("Kullanıcı Bilgileri :");
            Console.WriteLine($"Adı : {kullanici.Adi} - Soyadı : {kullanici.Soyadi}");

            SiniftaMetotKullanimi siniftaMetotKullanimi = new();
            siniftaMetotKullanimi.ToplamaYap();

        }
    }
}