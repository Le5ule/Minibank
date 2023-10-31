namespace Minibank
{
    partial class MinibankUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_innskudd = new System.Windows.Forms.Button();
            this.BTN_uttak = new System.Windows.Forms.Button();
            this.BTN_saldo = new System.Windows.Forms.Button();
            this.BTN_loggut = new System.Windows.Forms.Button();
            this.TB_info = new System.Windows.Forms.TextBox();
            this.BTN_100u = new System.Windows.Forms.Button();
            this.BTN_200u = new System.Windows.Forms.Button();
            this.BTN_500u = new System.Windows.Forms.Button();
            this.BTN_1000u = new System.Windows.Forms.Button();
            this.BTN_1000i = new System.Windows.Forms.Button();
            this.BTN_500i = new System.Windows.Forms.Button();
            this.BTN_200i = new System.Windows.Forms.Button();
            this.BTN_100i = new System.Windows.Forms.Button();
            this.BTN_ferdig = new System.Windows.Forms.Button();
            this.BTN_avbryt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_innskudd
            // 
            this.BTN_innskudd.Location = new System.Drawing.Point(25, 252);
            this.BTN_innskudd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_innskudd.Name = "BTN_innskudd";
            this.BTN_innskudd.Size = new System.Drawing.Size(98, 39);
            this.BTN_innskudd.TabIndex = 0;
            this.BTN_innskudd.Text = "Innskudd";
            this.BTN_innskudd.UseVisualStyleBackColor = true;
            this.BTN_innskudd.Click += new System.EventHandler(this.BTN_innskudd_Click);
            // 
            // BTN_uttak
            // 
            this.BTN_uttak.Location = new System.Drawing.Point(25, 160);
            this.BTN_uttak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_uttak.Name = "BTN_uttak";
            this.BTN_uttak.Size = new System.Drawing.Size(98, 39);
            this.BTN_uttak.TabIndex = 1;
            this.BTN_uttak.Text = "Uttak";
            this.BTN_uttak.UseVisualStyleBackColor = true;
            this.BTN_uttak.Click += new System.EventHandler(this.BTN_uttak_Click);
            // 
            // BTN_saldo
            // 
            this.BTN_saldo.Location = new System.Drawing.Point(25, 206);
            this.BTN_saldo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_saldo.Name = "BTN_saldo";
            this.BTN_saldo.Size = new System.Drawing.Size(98, 39);
            this.BTN_saldo.TabIndex = 2;
            this.BTN_saldo.Text = "Vis saldo";
            this.BTN_saldo.UseVisualStyleBackColor = true;
            this.BTN_saldo.Click += new System.EventHandler(this.BTN_saldo_Click);
            // 
            // BTN_loggut
            // 
            this.BTN_loggut.Location = new System.Drawing.Point(129, 206);
            this.BTN_loggut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_loggut.Name = "BTN_loggut";
            this.BTN_loggut.Size = new System.Drawing.Size(98, 39);
            this.BTN_loggut.TabIndex = 3;
            this.BTN_loggut.Text = "Logg ut";
            this.BTN_loggut.UseVisualStyleBackColor = true;
            this.BTN_loggut.Click += new System.EventHandler(this.BTN_loggut_Click);
            // 
            // TB_info
            // 
            this.TB_info.Location = new System.Drawing.Point(25, 68);
            this.TB_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_info.Name = "TB_info";
            this.TB_info.Size = new System.Drawing.Size(763, 27);
            this.TB_info.TabIndex = 4;
            // 
            // BTN_100u
            // 
            this.BTN_100u.Location = new System.Drawing.Point(25, 114);
            this.BTN_100u.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_100u.Name = "BTN_100u";
            this.BTN_100u.Size = new System.Drawing.Size(98, 39);
            this.BTN_100u.TabIndex = 5;
            this.BTN_100u.Text = "100kr";
            this.BTN_100u.UseVisualStyleBackColor = true;
            this.BTN_100u.Visible = false;
            this.BTN_100u.Click += new System.EventHandler(this.BTN_100_Click);
            // 
            // BTN_200u
            // 
            this.BTN_200u.Location = new System.Drawing.Point(129, 114);
            this.BTN_200u.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_200u.Name = "BTN_200u";
            this.BTN_200u.Size = new System.Drawing.Size(98, 39);
            this.BTN_200u.TabIndex = 6;
            this.BTN_200u.Text = "200kr";
            this.BTN_200u.UseVisualStyleBackColor = true;
            this.BTN_200u.Visible = false;
            this.BTN_200u.Click += new System.EventHandler(this.BTN_200_Click);
            // 
            // BTN_500u
            // 
            this.BTN_500u.Location = new System.Drawing.Point(233, 114);
            this.BTN_500u.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_500u.Name = "BTN_500u";
            this.BTN_500u.Size = new System.Drawing.Size(98, 39);
            this.BTN_500u.TabIndex = 7;
            this.BTN_500u.Text = "500kr";
            this.BTN_500u.UseVisualStyleBackColor = true;
            this.BTN_500u.Visible = false;
            this.BTN_500u.Click += new System.EventHandler(this.BTN_500_Click);
            // 
            // BTN_1000u
            // 
            this.BTN_1000u.Location = new System.Drawing.Point(337, 114);
            this.BTN_1000u.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_1000u.Name = "BTN_1000u";
            this.BTN_1000u.Size = new System.Drawing.Size(98, 39);
            this.BTN_1000u.TabIndex = 8;
            this.BTN_1000u.Text = "1000kr";
            this.BTN_1000u.UseVisualStyleBackColor = true;
            this.BTN_1000u.Visible = false;
            this.BTN_1000u.Click += new System.EventHandler(this.BTN_1000_Click);
            // 
            // BTN_1000i
            // 
            this.BTN_1000i.Location = new System.Drawing.Point(337, 299);
            this.BTN_1000i.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_1000i.Name = "BTN_1000i";
            this.BTN_1000i.Size = new System.Drawing.Size(98, 39);
            this.BTN_1000i.TabIndex = 12;
            this.BTN_1000i.Text = "1000kr";
            this.BTN_1000i.UseVisualStyleBackColor = true;
            this.BTN_1000i.Visible = false;
            this.BTN_1000i.Click += new System.EventHandler(this.BTN_1000i_Click);
            // 
            // BTN_500i
            // 
            this.BTN_500i.Location = new System.Drawing.Point(233, 299);
            this.BTN_500i.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_500i.Name = "BTN_500i";
            this.BTN_500i.Size = new System.Drawing.Size(98, 39);
            this.BTN_500i.TabIndex = 11;
            this.BTN_500i.Text = "500kr";
            this.BTN_500i.UseVisualStyleBackColor = true;
            this.BTN_500i.Visible = false;
            this.BTN_500i.Click += new System.EventHandler(this.BTN_500i_Click);
            // 
            // BTN_200i
            // 
            this.BTN_200i.Location = new System.Drawing.Point(129, 299);
            this.BTN_200i.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_200i.Name = "BTN_200i";
            this.BTN_200i.Size = new System.Drawing.Size(98, 39);
            this.BTN_200i.TabIndex = 10;
            this.BTN_200i.Text = "200kr";
            this.BTN_200i.UseVisualStyleBackColor = true;
            this.BTN_200i.Visible = false;
            this.BTN_200i.Click += new System.EventHandler(this.BTN_200i_Click);
            // 
            // BTN_100i
            // 
            this.BTN_100i.Location = new System.Drawing.Point(25, 299);
            this.BTN_100i.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_100i.Name = "BTN_100i";
            this.BTN_100i.Size = new System.Drawing.Size(98, 39);
            this.BTN_100i.TabIndex = 9;
            this.BTN_100i.Text = "100kr";
            this.BTN_100i.UseVisualStyleBackColor = true;
            this.BTN_100i.Visible = false;
            this.BTN_100i.Click += new System.EventHandler(this.BTN_100i_Click);
            // 
            // BTN_ferdig
            // 
            this.BTN_ferdig.Location = new System.Drawing.Point(441, 299);
            this.BTN_ferdig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_ferdig.Name = "BTN_ferdig";
            this.BTN_ferdig.Size = new System.Drawing.Size(98, 39);
            this.BTN_ferdig.TabIndex = 13;
            this.BTN_ferdig.Text = "Ferdig";
            this.BTN_ferdig.UseVisualStyleBackColor = true;
            this.BTN_ferdig.Visible = false;
            this.BTN_ferdig.Click += new System.EventHandler(this.BTN_ferdig_Click);
            // 
            // BTN_avbryt
            // 
            this.BTN_avbryt.Location = new System.Drawing.Point(441, 114);
            this.BTN_avbryt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_avbryt.Name = "BTN_avbryt";
            this.BTN_avbryt.Size = new System.Drawing.Size(98, 39);
            this.BTN_avbryt.TabIndex = 14;
            this.BTN_avbryt.Text = "Avbryt";
            this.BTN_avbryt.UseVisualStyleBackColor = true;
            this.BTN_avbryt.Visible = false;
            this.BTN_avbryt.Click += new System.EventHandler(this.BTN_avbryt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Velkommen Kari Nordmann";
            // 
            // MinibankUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_avbryt);
            this.Controls.Add(this.BTN_ferdig);
            this.Controls.Add(this.BTN_1000i);
            this.Controls.Add(this.BTN_500i);
            this.Controls.Add(this.BTN_200i);
            this.Controls.Add(this.BTN_100i);
            this.Controls.Add(this.BTN_1000u);
            this.Controls.Add(this.BTN_500u);
            this.Controls.Add(this.BTN_200u);
            this.Controls.Add(this.BTN_100u);
            this.Controls.Add(this.TB_info);
            this.Controls.Add(this.BTN_loggut);
            this.Controls.Add(this.BTN_saldo);
            this.Controls.Add(this.BTN_uttak);
            this.Controls.Add(this.BTN_innskudd);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MinibankUI";
            this.Text = "Minibank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_innskudd;
        private System.Windows.Forms.Button BTN_uttak;
        private System.Windows.Forms.Button BTN_saldo;
        private System.Windows.Forms.Button BTN_loggut;
        private System.Windows.Forms.TextBox TB_info;
        private System.Windows.Forms.Button BTN_100u;
        private System.Windows.Forms.Button BTN_200u;
        private System.Windows.Forms.Button BTN_500u;
        private System.Windows.Forms.Button BTN_1000u;
        private System.Windows.Forms.Button BTN_1000i;
        private System.Windows.Forms.Button BTN_500i;
        private System.Windows.Forms.Button BTN_200i;
        private System.Windows.Forms.Button BTN_100i;
        private System.Windows.Forms.Button BTN_ferdig;
        private System.Windows.Forms.Button BTN_avbryt;
        private System.Windows.Forms.Label label1;
    }
}