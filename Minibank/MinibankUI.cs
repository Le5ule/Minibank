namespace Minibank
{
    public partial class MinibankUI : Form
    {
        Minibank minibank = new Minibank();

        public MinibankUI()
        {
            InitializeComponent();
            minibank.Saldo_ = Convert.ToDouble(File.ReadLines("saldo.txt").Last());
        }
        private void BTN_loggut_Click(object sender, EventArgs e)
        {
            minibank.LoggUt();
            this.Hide();
            minibank.Saldo_ = Convert.ToDouble(File.ReadLines("saldo.txt").Last());
        }
        private void BTN_saldo_Click(object sender, EventArgs e)
        {
            TB_info.Text = ($"Din saldo er: \t {minibank.Saldo():f2} kr");
        }

        private void BTN_uttak_Click(object sender, EventArgs e)
        {
            TB_info.Text = ("Vennligst velg hvor mye du vil ta ut");

            BTN_100u.Visible = true;
            BTN_200u.Visible = true;
            BTN_500u.Visible = true;
            BTN_1000u.Visible = true;
            BTN_avbryt.Visible = true;
            BTN_innskudd.Visible = false;
        }
        private void BTN_100_Click(object sender, EventArgs e)
        {
            UttakSegment(100);   
        }
        private void BTN_200_Click(object sender, EventArgs e)
        {
            UttakSegment(200);
        }
        private void BTN_500_Click(object sender, EventArgs e)
        {
            UttakSegment(500);
        }
        private void BTN_1000_Click(object sender, EventArgs e)
        {
            UttakSegment(1000);
        }
        private void BTN_avbryt_Click(object sender, EventArgs e)
        {
            UttakSegment(0);
        }

        private void BTN_innskudd_Click(object sender, EventArgs e)
        {
            TB_info.Text = ("Vennligst sett inn sedler ved å trykke på knappene nederst. Når du har satt inn ønskede sedler, trykk på ferdig");

            BTN_100i.Visible = true;
            BTN_200i.Visible = true;
            BTN_500i.Visible = true;
            BTN_1000i.Visible = true;
            BTN_ferdig.Visible = true;
            BTN_uttak.Visible = false;
            BTN_saldo.Visible = false;
        }
        private void BTN_100i_Click(object sender, EventArgs e)
        {
            InnskuddSegment(100);
        }
        private void BTN_200i_Click(object sender, EventArgs e)
        {
            InnskuddSegment(200);
        }
        private void BTN_500i_Click(object sender, EventArgs e)
        {
            InnskuddSegment(500);
        }
        private void BTN_1000i_Click(object sender, EventArgs e)
        {
            InnskuddSegment(1000);
        }
        private void BTN_ferdig_Click(object sender, EventArgs e)
        {
            InnskuddSegment(0);
            TB_info.Clear();
            BTN_100i.Visible = false;
            BTN_200i.Visible = false;
            BTN_500i.Visible = false;
            BTN_1000i.Visible = false;
            BTN_ferdig.Visible = false;
            BTN_uttak.Visible = true;
            BTN_saldo.Visible = true;
        }

        void UttakSegment(double beløp)
        {
            if (minibank.Uttak(beløp) == true)
            {
                double saldo = minibank.Saldo() - beløp;
                minibank.Saldo();
                BTN_100u.Visible = false;
                BTN_200u.Visible = false;
                BTN_500u.Visible = false;
                BTN_1000u.Visible = false;
                BTN_avbryt.Visible = false;
                BTN_innskudd.Visible = true;
                TB_info.Clear();
            }
            else
                MessageBox.Show($"Ikke nok dekning på konto!\nDisponibel saldo er {minibank.Saldo():f2} kr");
         }
        void InnskuddSegment(double beløp)
        {
            TB_info.Text = ($"Penger satt inn hittil: \t {minibank.Innskudd(beløp)} kr");
        }
    }
}
