namespace Minibank
{
    internal interface IBankOperasjon
    {
        double Saldo_ { get; set; }
        bool Autentisering(string bruker);
        void LoggUt();
        double Innskudd(double beløp);
        bool Uttak(double beløp);
        double Saldo();
    }
}
