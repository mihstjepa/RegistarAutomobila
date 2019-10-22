namespace RegistarAutomobila.Forme.Dodavanje
{
    partial class FrmDodajModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajModel));
            this.lblDrzava = new System.Windows.Forms.Label();
            this.txtBoxDrzava = new System.Windows.Forms.TextBox();
            this.lblNazivModela = new System.Windows.Forms.Label();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.groupBoxUnosModela = new System.Windows.Forms.GroupBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.groupBoxUnosModela.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDrzava
            // 
            this.lblDrzava.AutoSize = true;
            this.lblDrzava.Location = new System.Drawing.Point(459, 302);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(193, 29);
            this.lblDrzava.TabIndex = 28;
            this.lblDrzava.Text = "Država porijekla:";
            // 
            // txtBoxDrzava
            // 
            this.txtBoxDrzava.Location = new System.Drawing.Point(596, 299);
            this.txtBoxDrzava.Name = "txtBoxDrzava";
            this.txtBoxDrzava.Size = new System.Drawing.Size(294, 36);
            this.txtBoxDrzava.TabIndex = 27;
            // 
            // lblNazivModela
            // 
            this.lblNazivModela.AutoSize = true;
            this.lblNazivModela.Location = new System.Drawing.Point(537, 249);
            this.lblNazivModela.Name = "lblNazivModela";
            this.lblNazivModela.Size = new System.Drawing.Size(78, 29);
            this.lblNazivModela.TabIndex = 26;
            this.lblNazivModela.Text = "Naziv:";
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Location = new System.Drawing.Point(596, 246);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(294, 36);
            this.txtBoxNaziv.TabIndex = 25;
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
            this.btnNatrag.TabIndex = 24;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslov.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelNaslov.Location = new System.Drawing.Point(418, 13);
            this.labelNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(746, 121);
            this.labelNaslov.TabIndex = 23;
            this.labelNaslov.Text = "Inpro Automobili";
            // 
            // groupBoxUnosModela
            // 
            this.groupBoxUnosModela.Controls.Add(this.btnSpremi);
            this.groupBoxUnosModela.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxUnosModela.Location = new System.Drawing.Point(419, 199);
            this.groupBoxUnosModela.Name = "groupBoxUnosModela";
            this.groupBoxUnosModela.Size = new System.Drawing.Size(518, 255);
            this.groupBoxUnosModela.TabIndex = 29;
            this.groupBoxUnosModela.TabStop = false;
            this.groupBoxUnosModela.Text = "Unos novog modela";
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
            this.btnSpremi.Location = new System.Drawing.Point(208, 172);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(127, 39);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FrmDodajModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1820, 949);
            this.Controls.Add(this.lblDrzava);
            this.Controls.Add(this.txtBoxDrzava);
            this.Controls.Add(this.lblNazivModela);
            this.Controls.Add(this.txtBoxNaziv);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.groupBoxUnosModela);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDodajModel";
            this.Text = "FrmDodajModel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxUnosModela.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.TextBox txtBoxDrzava;
        private System.Windows.Forms.Label lblNazivModela;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.GroupBox groupBoxUnosModela;
        private System.Windows.Forms.Button btnSpremi;
    }
}