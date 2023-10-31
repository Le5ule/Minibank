namespace Minibank
{
    public partial class Innlogging : Form
    {
        Minibank innlogging = new Minibank();
        MinibankUI minibankui = new MinibankUI();

        public Innlogging()
        {
            InitializeComponent();
        }
        public void Tast(int inn)
        {
            innlogging.Kode().Add(inn);
            
            if (innlogging.Kode().Count == 1) TB_Kode.Text = "*";
            if (innlogging.Kode().Count == 2) TB_Kode.Text = "**";
            if (innlogging.Kode().Count == 3) TB_Kode.Text = "***";

            if (innlogging.Kode().Count == 4)
            {
                TB_Kode.Text = "****";
                innlogging.Autentisering(innlogging.Kombo());
                
                if (innlogging.Kombo() == "4539")
                {
                    this.Hide();
                    minibankui.Show();
                }
                else
                {
                    TB_Kode.Clear();
                }
            }
        }

        private void BTN_kort_Click(object sender, EventArgs e)
        {
            BTN0.Visible = true;
            BTN1.Visible = true;
            BTN2.Visible = true;
            BTN3.Visible = true;
            BTN4.Visible = true;
            BTN5.Visible = true;
            BTN6.Visible = true;
            BTN7.Visible = true;
            BTN8.Visible = true;
            BTN9.Visible = true;
            BTN_kort.Visible = false;
            label3.Visible = true;
            TB_Kode.Visible = true;
        }
        private void BTN_avbryt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            Tast(1);
        }
        private void BTN2_Click(object sender, EventArgs e)
        {
            Tast(2);
        }
        private void BTN3_Click(object sender, EventArgs e)
        {
            Tast(3);
        }
        private void BTN4_Click(object sender, EventArgs e)
        {
            Tast(4);
        }
        private void BTN5_Click(object sender, EventArgs e)
        {
            Tast(5);
        }
        private void BTN6_Click(object sender, EventArgs e)
        {
            Tast(6);
        }
        private void BTN7_Click(object sender, EventArgs e)
        {
            Tast(7);
        }
        private void BTN8_Click(object sender, EventArgs e)
        {
            Tast(8);
        }
        private void BTN9_Click(object sender, EventArgs e)
        {
            Tast(9);
        }
        private void BTN0_Click(object sender, EventArgs e)
        {
            Tast(0);
        }
    }
}
