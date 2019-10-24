namespace RegistarAutomobila.Forme.Dodavanje
{
    partial class FrmDodajKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajKorisnika));
            this.lblKorime = new System.Windows.Forms.Label();
            this.txtBoxKorime = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.groupBoxUnosKorisnika = new System.Windows.Forms.GroupBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.lblPotvrdiLozinku = new System.Windows.Forms.Label();
            this.txtBoxPotvrdaLozinke = new System.Windows.Forms.TextBox();
            this.comboBoxOdabirUloge = new System.Windows.Forms.ComboBox();
            this.lblUloga = new System.Windows.Forms.Label();
            this.groupBoxUnosKorisnika.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKorime
            // 
            this.lblKorime.AutoSize = true;
            this.lblKorime.Location = new System.Drawing.Point(404, 139);
            this.lblKorime.Name = "lblKorime";
            this.lblKorime.Size = new System.Drawing.Size(165, 29);
            this.lblKorime.TabIndex = 33;
            this.lblKorime.Text = "Korisničko ime";
            // 
            // txtBoxKorime
            // 
            this.txtBoxKorime.Location = new System.Drawing.Point(531, 136);
            this.txtBoxKorime.Name = "txtBoxKorime";
            this.txtBoxKorime.Size = new System.Drawing.Size(294, 36);
            this.txtBoxKorime.TabIndex = 32;
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
            this.btnNatrag.TabIndex = 31;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslov.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelNaslov.Location = new System.Drawing.Point(391, 13);
            this.labelNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(746, 121);
            this.labelNaslov.TabIndex = 30;
            this.labelNaslov.Text = "Inpro Automobili";
            // 
            // groupBoxUnosKorisnika
            // 
            this.groupBoxUnosKorisnika.Controls.Add(this.btnSpremi);
            this.groupBoxUnosKorisnika.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxUnosKorisnika.Location = new System.Drawing.Point(384, 97);
            this.groupBoxUnosKorisnika.Name = "groupBoxUnosKorisnika";
            this.groupBoxUnosKorisnika.Size = new System.Drawing.Size(527, 475);
            this.groupBoxUnosKorisnika.TabIndex = 34;
            this.groupBoxUnosKorisnika.TabStop = false;
            this.groupBoxUnosKorisnika.Text = "Unos novog korisnika";
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
            this.btnSpremi.Location = new System.Drawing.Point(147, 414);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(294, 54);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(481, 201);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(55, 29);
            this.lblIme.TabIndex = 36;
            this.lblIme.Text = "Ime";
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(531, 198);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(294, 36);
            this.txtBoxIme.TabIndex = 35;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(453, 263);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(97, 29);
            this.lblPrezime.TabIndex = 38;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(531, 260);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(294, 36);
            this.txtBoxPrezime.TabIndex = 37;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(453, 325);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(92, 29);
            this.lblLozinka.TabIndex = 40;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Location = new System.Drawing.Point(531, 322);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.PasswordChar = '*';
            this.txtBoxLozinka.Size = new System.Drawing.Size(294, 36);
            this.txtBoxLozinka.TabIndex = 39;
            // 
            // lblPotvrdiLozinku
            // 
            this.lblPotvrdiLozinku.AutoSize = true;
            this.lblPotvrdiLozinku.Location = new System.Drawing.Point(404, 387);
            this.lblPotvrdiLozinku.Name = "lblPotvrdiLozinku";
            this.lblPotvrdiLozinku.Size = new System.Drawing.Size(165, 29);
            this.lblPotvrdiLozinku.TabIndex = 42;
            this.lblPotvrdiLozinku.Text = "PotvrdiLozinku";
            // 
            // txtBoxPotvrdaLozinke
            // 
            this.txtBoxPotvrdaLozinke.Location = new System.Drawing.Point(531, 384);
            this.txtBoxPotvrdaLozinke.Name = "txtBoxPotvrdaLozinke";
            this.txtBoxPotvrdaLozinke.PasswordChar = '*';
            this.txtBoxPotvrdaLozinke.Size = new System.Drawing.Size(294, 36);
            this.txtBoxPotvrdaLozinke.TabIndex = 41;
            // 
            // comboBoxOdabirUloge
            // 
            this.comboBoxOdabirUloge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOdabirUloge.FormattingEnabled = true;
            this.comboBoxOdabirUloge.Location = new System.Drawing.Point(531, 446);
            this.comboBoxOdabirUloge.Name = "comboBoxOdabirUloge";
            this.comboBoxOdabirUloge.Size = new System.Drawing.Size(294, 37);
            this.comboBoxOdabirUloge.TabIndex = 43;
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Location = new System.Drawing.Point(463, 449);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(73, 29);
            this.lblUloga.TabIndex = 44;
            this.lblUloga.Text = "Uloga";
            // 
            // FrmDodajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1820, 949);
            this.Controls.Add(this.lblUloga);
            this.Controls.Add(this.comboBoxOdabirUloge);
            this.Controls.Add(this.lblPotvrdiLozinku);
            this.Controls.Add(this.txtBoxPotvrdaLozinke);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtBoxLozinka);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtBoxIme);
            this.Controls.Add(this.lblKorime);
            this.Controls.Add(this.txtBoxKorime);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.groupBoxUnosKorisnika);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDodajKorisnika";
            this.Text = "Dodavanje novih korisnika";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxUnosKorisnika.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorime;
        private System.Windows.Forms.TextBox txtBoxKorime;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.GroupBox groupBoxUnosKorisnika;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.Label lblPotvrdiLozinku;
        private System.Windows.Forms.TextBox txtBoxPotvrdaLozinke;
        private System.Windows.Forms.ComboBox comboBoxOdabirUloge;
        private System.Windows.Forms.Label lblUloga;
    }
}