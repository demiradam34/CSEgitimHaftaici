namespace Ders17AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Classes!");
            //Database database = new Database(); abstract class lar bu şekilde new lenemez!!
            Database database = new Oracle();//Database sınıfından yeni bir oracle nesnesi oluşturuyoruz
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();//Database sınıfından yeni bir SqlServer nesnesi oluşturuyoruz
            database2.Add();
            database2.Delete();
            database2.Update();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Ekle metodu çalıştı!");
        }
        public abstract void Delete(); // silme metot imzası
        public abstract void Update(); // CRUD
        public abstract void Get();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("SqlServer Delete metodu çalıştı!");
        }

        public override void Get()
        {
            Console.WriteLine("SqlServer Get metodu çalıştı!");
        }

        public override void Update()
        {
            Console.WriteLine("SqlServer Update metodu çalıştı!");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Oracle Delete metodu çalıştı!");
        }

        public override void Get()
        {
            Console.WriteLine("Oracle Get metodu çalıştı!");
        }

        public override void Update()
        {
            Console.WriteLine("Oracle Update metodu çalıştı!");
        }
    }
    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("MySql Delete metodu çalıştı!");
        }

        public override void Get()
        {
            Console.WriteLine("MySql Get metodu çalıştı!");
        }

        public override void Update()
        {
            Console.WriteLine("MySql Update metodu çalıştı!");
        }
    }
}