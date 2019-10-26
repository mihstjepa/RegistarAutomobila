namespace RegistarAutomobila.Forme.Ažuriranje
{
    partial class FrmAzuriranjeKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAzuriranjeKorisnika));
            this.btnNatrag = new System.Windows.Forms.Button();
            this.txtBoxSifra = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.groupBoxAzuriranjeKorisnika = new System.Windows.Forms.GroupBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblUloga = new System.Windows.Forms.Label();
            this.comboBoxOdabirUloge = new System.Windows.Forms.ComboBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.lblKorime = new System.Windows.Forms.Label();
            this.txtBoxKorime = new System.Windows.Forms.TextBox();
            this.groupBoxAzuriranjeKorisnika.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNatrag.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNatrag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnNatrag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatrag.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.Black;
            this.btnNatrag.Location = new System.Drawing.Point(13, 13);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(4);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(145, 57);
            this.btnNatrag.TabIndex = 69;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // txtBoxSifra
            // 
            this.txtBoxSifra.Enabled = false;
            this.txtBoxSifra.Location = new System.Drawing.Point(540, 101);
            this.txtBoxSifra.Name = "txtBoxSifra";
            this.txtBoxSifra.Size = new System.Drawing.Size(291, 36);
            this.txtBoxSifra.TabIndex = 67;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(655, 67);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(61, 29);
            this.lblSifra.TabIndex = 66;
            this.lblSifra.Text = "Šifra";
            // 
            // groupBoxAzuriranjeKorisnika
            // 
            this.groupBoxAzuriranjeKorisnika.Controls.Add(this.lblUloga);
            this.groupBoxAzuriranjeKorisnika.Controls.Add(this.btnSpremi);
            this.groupBoxAzuriranjeKorisnika.Controls.Add(this.comboBoxOdabirUloge);
            this.groupBoxAzuriranjeKorisnika.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxAzuriranjeKorisnika.Location = new System.Drawing.Point(484, 13);
            this.groupBoxAzuriranjeKorisnika.Name = "groupBoxAzuriranjeKorisnika";
            this.groupBoxAzuriranjeKorisnika.Size = new System.Drawing.Size(420, 587);
            this.groupBoxAzuriranjeKorisnika.TabIndex = 68;
            this.groupBoxAzuriranjeKorisnika.TabStop = false;
            this.groupBoxAzuriranjeKorisnika.Text = "Unesite nove podatke";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSpremi.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSpremi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSpremi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.Black;
            this.btnSpremi.Location = new System.Drawing.Point(53, 519);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(295, 54);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Location = new System.Drawing.Point(164, 429);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(73, 29);
            this.lblUloga.TabIndex = 81;
            this.lblUloga.Text = "Uloga";
            // 
            // comboBoxOdabirUloge
            // 
            this.comboBoxOdabirUloge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOdabirUloge.FormattingEnabled = true;
            this.comboBoxOdabirUloge.Location = new System.Drawing.Point(53, 463);
            this.comboBoxOdabirUloge.Name = "comboBoxOdabirUloge";
            this.comboBoxOdabirUloge.Size = new System.Drawing.Size(294, 37);
            this.comboBoxOdabirUloge.TabIndex = 80;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(639, 367);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(92, 29);
            this.lblLozinka.TabIndex = 77;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Location = new System.Drawing.Point(538, 401);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(294, 36);
            this.txtBoxLozinka.TabIndex = 76;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(637, 292);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(97, 29);
            this.lblPrezime.TabIndex = 75;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(538, 326);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(294, 36);
            this.txtBoxPrezime.TabIndex = 74;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(658, 217);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(55, 29);
            this.lblIme.TabIndex = 73;
            this.lblIme.Text = "Ime";
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(538, 251);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(294, 36);
            this.txtBoxIme.TabIndex = 72;
            // 
            // lblKorime
            // 
            this.lblKorime.AutoSize = true;
            this.lblKorime.Location = new System.Drawing.Point(603, 142);
            this.lblKorime.Name = "lblKorime";
            this.lblKorime.Size = new System.Drawing.Size(165, 29);
            this.lblKorime.TabIndex = 71;
            this.lblKorime.Text = "Korisničko ime";
            // 
            // txtBoxKorime
            // 
            this.txtBoxKorime.Location = new System.Drawing.Point(538, 176);
            this.txtBoxKorime.Name = "txtBoxKorime";
            this.txtBoxKorime.Size = new System.Drawing.Size(294, 36);
            this.txtBoxKorime.TabIndex = 70;
            // 
            // FrmAzuriranjeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1820, 949);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtBoxLozinka);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtBoxIme);
            this.Controls.Add(this.lblKorime);
            this.Controls.Add(this.txtBoxKorime);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtBoxSifra);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.groupBoxAzuriranjeKorisnika);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAzuriranjeKorisnika";
            this.Text = "Ažuriranje postojećeg korisnika";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxAzuriranjeKorisnika.ResumeLayout(false);
            this.groupBoxAzuriranjeKorisnika.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.TextBox txtBoxSifra;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.GroupBox groupBoxAzuriranjeKorisnika;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.ComboBox comboBoxOdabirUloge;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Label lblKorime;
        private System.Windows.Forms.TextBox txtBoxKorime;
    }
}