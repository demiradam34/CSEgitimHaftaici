namespace Ders10OzgenlerProperties
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }

        public bool KullaniciGiris(string mail, string sifre)
        {
            string veritabanindakiMail = "info@admin.co";
            string veritabanindakiSifre = "123456";
            bool islemSonucu = false;

            if (mail == veritabanindakiMail & sifre == veritabanindakiSifre)
            {
                islemSonucu = true; // eğer gönderilen değerler eşleşirse islemSonucu değerini true yap
            }
            return islemSonucu;
        }

    }
}
