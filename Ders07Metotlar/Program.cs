// See https://aka.ms/new-console-template for more information
Console.WriteLine("Metotlar!");

void ToplamaYap() // void metotlar geriye değer döndürmeyen metotlardır. Görevini yapar ve işlemi tamamlar.
{
    Console.WriteLine(10 + 8);
}

ToplamaYap(); // Yazdığımız metodu bir yerde çağırmamız gerekir yoksa metot çalışmaz.

static void ToplamaYap2() // ToplamaYap() metot ismi ve imzası(parametreleri) 1 kez aynı isimle kullanılabilir
{
    Console.WriteLine(18 + 8);
}

ToplamaYap2();
ToplamaYap();
ToplamaYap2();

void ToplamaYapParametre(int sayi1, int sayi2) // metotlar dışarıdan parametre alarak çalışabilir
{
    Console.WriteLine(sayi1 + sayi2); // dışarıdan gönderilecek sayıları topla ve sonucu ekrana yaz
}

ToplamaYapParametre(18,34); // parametreli metotlarda metodu çağırdığımız yerde gerekli parametreleri de göndermemiz gerekir.

static bool MailGonder(string mailAdresi) //Geriye değer döndüren metot
{
    string sistemdekiMailAdresi = "info@aribilgi.com";
    if (mailAdresi == sistemdekiMailAdresi)
    {
        //Burada mail gönderim kodları olacak
        return true;
    }
    else return false;
}

Console.WriteLine("Mail adresinizi giriniz :");
var mail = Console.ReadLine();

bool sonuc = MailGonder(mail);
if (sonuc)// == true
{
    Console.WriteLine(mail + " adresinde mail gönderimi başarılı!");
}
else
{
    Console.WriteLine(mail + " adresinde mail gönderimi başarısız!");
}

static string MailGonder2(string mailAdresi)
{
    string sistemdekiMailAdresi = "info@bilgi.com";
    if (mailAdresi == sistemdekiMailAdresi)
    {
        //Burada mail gönderim kodları olacak
        return "Başarılı";
    }
    else return "Başarısız";
}

var sonuc2 = MailGonder2(mail);
if (sonuc2 == "Başarılı")
{
    Console.WriteLine(mail + " adresinde mail gönderimi başarılı!");
}
else
{
    Console.WriteLine(mail + " adresinde mail gönderimi başarısız!");
}

static int KucukHarfSay(string kucukHarfiSayilacakMetin)
{
    int kucukharfsayisi = 0;//sayacağımız küçük harf sayısını tutmak için değişkenimiz
    foreach (char harf in kucukHarfiSayilacakMetin)
    {
        if (char.IsLower(harf)) kucukharfsayisi++;//Eğer ekrandan okunan metin içerisindeki harf küçükse kucukharfsayisi değerini 1 artır
    }
    return kucukharfsayisi;//geriye döndürülen değer
}

Console.WriteLine("Bir Cümle yazıp enter a basınız");
string cumle = Console.ReadLine();
Console.WriteLine("Cümledeki küçük harf sayısı {0} adettir.", KucukHarfSay(cumle));

