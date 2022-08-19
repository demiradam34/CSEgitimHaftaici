namespace Ders10OzgenlerProperties
{
    internal class Kisi
    {
        private int yas;
        private string dogumYeri;
        string meslek;
        double maas;

        public double Maas
        {
            get { return maas; }
            set
            {
                if (value <= 4250)
                {
                    maas = 4250;
                }
                else maas = value;
            }
        }

        public int Yas
        {
            get { return yas; }
            set
            {
                if (value >= 18 && value <= 65) yas = value;
                else yas = 18;
            }
        }

        public string DogumYeri
        {
            get { return dogumYeri; }
            set { dogumYeri = value; }
        }

    }
}
