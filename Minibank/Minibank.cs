using System.Collections.Generic;

namespace Minibank
{
    internal class Minibank : IBankOperasjon
    {
        List<int> kode = new List<int>();
        string kombo = "";

        private double saldo = Convert.ToDouble(File.ReadLines("saldo.txt").Last());
        // private double saldo; // = 2739.87;
        private double innskudd = 0;

        public double Saldo_
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public bool Autentisering(string bruker)
        {
            bool svar = false;
            Saldo_ = Convert.ToDouble(File.ReadLines("saldo.txt").Last());
            kombo = kode[0].ToString() + kode[1].ToString() + kode[2].ToString() + kode[3].ToString();
            bruker = "4539";
            if (kombo == bruker)
            {
                kode.Clear();
                Saldo_ = Convert.ToDouble(File.ReadLines("saldo.txt").Last());
                svar = true;
            }
            else
            {
                MessageBox.Show("Feil kode, skriv inn på nytt");
                kode.Clear();
            }
            return svar;
        }
        public void LoggUt()
        {
            new Innlogging().Show();

            StreamWriter sw = new StreamWriter("saldo.txt");
            sw.WriteLine(Saldo());
            sw.Close();
            Saldo_ = Convert.ToDouble(File.ReadLines("saldo.txt").Last());
            
        }
        
        public double Saldo()
        {
            return Saldo_;
        }

        public double Innskudd(double beløp)
        {
            innskudd = innskudd + beløp;
            if (beløp == 0)
            {
                Saldo_ = Saldo_ + innskudd;
                innskudd = 0;
            }
            return innskudd;
        }

        public bool Uttak(double beløp)
        {
            bool svar = false;
            if (Saldo() >= beløp)
            {
                Saldo_ = Saldo_ - beløp;
                svar = true;
            }
            return svar;
        }

        public List<int> Kode()
        {
            return kode;
        }
        public string Kombo()
        {
            return kombo;
        }
    }
}
