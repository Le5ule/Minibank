namespace Minibank
{
    internal static class Program
    {
        // Klassen som er implementert er Minibank.cs som implementerer IBankOperasjon som interface. I denne klassen er alle operasjonsmetoder definert
        // som er nødvendig for alle funkjsoner i programmet.
        //
        // Har prøvd å implementere lagring og oppdatering av saldo ved av- og pålogging, men dette fungerer ikke helt optimalt, men oppdateres korrekt
        // dersom man avslutter programmet helt, og åpner på nytt. Usikker på hvordan implementer slik funksjon ved bruk av StreamWriter og -Reader når
        // man bruker klasser hvor all info som brukes i forms-klassen hentes fra en "database-klasse", om man kan kalle det for det.


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Innlogging());
        }
    }
}