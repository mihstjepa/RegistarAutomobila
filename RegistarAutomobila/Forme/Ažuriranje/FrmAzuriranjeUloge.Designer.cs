namespace RegistarAutomobila.Forme.Ažuriranje
{
    partial class FrmAzuriranjeUloge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAzuriranjeUloge));
            this.btnNatrag = new System.Windows.Forms.Button();
            this.txtBoxSifra = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.groupBoxAzuriranjeUloga = new System.Windows.Forms.GroupBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.groupBoxAzuriranjeUloga.SuspendLayout();
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
            this.btnNatrag.TabIndex = 21;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // txtBoxSifra
            // 
            this.txtBoxSifra.Enabled = false;
            this.txtBoxSifra.Location = new System.Drawing.Point(526, 134);
            this.txtBoxSifra.Name = "txtBoxSifra";
            this.txtBoxSifra.Size = new System.Drawing.Size(238, 36);
            this.txtBoxSifra.TabIndex = 19;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(615, 101);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(61, 29);
            this.lblSifra.TabIndex = 18;
            this.lblSifra.Text = "Šifra";
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Location = new System.Drawing.Point(526, 207);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(238, 36);
            this.txtBoxNaziv.TabIndex = 16;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(610, 174);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(70, 29);
            this.lblNaziv.TabIndex = 14;
            this.lblNaziv.Text = "Naziv";
            // 
            // groupBoxAzuriranjeUloga
            // 
            this.groupBoxAzuriranjeUloga.Controls.Add(this.btnSpremi);
            this.groupBoxAzuriranjeUloga.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxAzuriranjeUloga.Location = new System.Drawing.Point(437, 64);
            this.groupBoxAzuriranjeUloga.Name = "groupBoxAzuriranjeUloga";
            this.groupBoxAzuriranjeUloga.Size = new System.Drawing.Size(420, 325);
            this.groupBoxAzuriranjeUloga.TabIndex = 20;
            this.groupBoxAzuriranjeUloga.TabStop = false;
            this.groupBoxAzuriranjeUloga.Text = "Unesite nove podatke";
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
            this.btnSpremi.Location = new System.Drawing.Point(89, 247);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(238, 54);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FrmAzuriranjeUloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1820, 949);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtBoxSifra);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.txtBoxNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.groupBoxAzuriranjeUloga);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAzuriranjeUloge";
            this.Text = "Ažuriranje uloga";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxAzuriranjeUloga.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.TextBox txtBoxSifra;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.GroupBox groupBoxAzuriranjeUloga;
        private System.Windows.Forms.Button btnSpremi;
    }
}