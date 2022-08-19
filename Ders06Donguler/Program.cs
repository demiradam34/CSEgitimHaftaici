// See https://aka.ms/new-console-template for more information
Console.WriteLine("Döngüler!");

Console.WriteLine("1");
Console.WriteLine("2");
Console.WriteLine("3");
Console.WriteLine("4");
Console.WriteLine("5");

Console.WriteLine("For Döngüsü");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("İ nin değeri : {0}", i);
}

Console.WriteLine("While Döngüsü");

int k = 1;

while (k <= 5)
{
    Console.WriteLine("K nın değeri : {0} diğer değişken {1}", k, 10);
    k++;
}

Console.WriteLine("Do While Döngüsü");

int l = 6;

do
{
    Console.WriteLine("l nın değeri : {0}", l);
    l++;
} while (l <= 5);

Console.WriteLine("Foreach Döngüsü");

string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep Telefonu", "Beyaz Eşya", "Kitap" };

int[] urunler = { 1, 2, 3, 4, 5 };

// ctrl + k + d

Console.WriteLine("Kategoriler");

foreach (var kategoriAdi in kategoriler)
{
    Console.WriteLine($"Kategori Adı : {kategoriAdi}");
}

foreach (var item in urunler)
{
    Console.WriteLine($"Ürün No : {item}");
}

Console.WriteLine();
Console.WriteLine("İç İçe Foreach Döngüsü");

string[] urunListesi = { "Ürün 1", "Ürün 2", "Ürün 3" };

foreach (var kategoriAdi in kategoriler)
{
    Console.WriteLine($"Kategori Adı : {kategoriAdi}");
    foreach (var urunAdi in urunListesi)
    {
        Console.WriteLine($"Ürün Adı : {urunAdi}");
    }
}

Console.WriteLine();
Console.WriteLine("İç İçe For Döngüsü");

for (int i = 1; i < 5; i++)
{
    Console.WriteLine($"İ nin değeri : {i}");
    for (int j = 1; j < 3; j++)
    {
        Console.WriteLine($"\tJ nin değeri : {j}");
    }
}