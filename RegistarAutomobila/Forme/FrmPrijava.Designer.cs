namespace RegistarAutomobila.Forme
{
    partial class FrmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrijava));
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.txtBoxKorime = new System.Windows.Forms.TextBox();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.lblKorime = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPrijaviSe.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrijaviSe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrijaviSe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrijaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijaviSe.ForeColor = System.Drawing.Color.Black;
            this.btnPrijaviSe.Location = new System.Drawing.Point(281, 372);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(215, 39);
            this.btnPrijaviSe.TabIndex = 3;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // txtBoxKorime
            // 
            this.txtBoxKorime.BackColor = System.Drawing.Color.White;
            this.txtBoxKorime.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxKorime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBoxKorime.Location = new System.Drawing.Point(281, 200);
            this.txtBoxKorime.Name = "txtBoxKorime";
            this.txtBoxKorime.Size = new System.Drawing.Size(215, 32);
            this.txtBoxKorime.TabIndex = 4;
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.BackColor = System.Drawing.Color.White;
            this.txtBoxLozinka.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLozinka.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBoxLozinka.Location = new System.Drawing.Point(281, 296);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.PasswordChar = '*';
            this.txtBoxLozinka.Size = new System.Drawing.Size(215, 32);
            this.txtBoxLozinka.TabIndex = 5;
            // 
            // lblKorime
            // 
            this.lblKorime.AutoSize = true;
            this.lblKorime.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblKorime.Location = new System.Drawing.Point(331, 173);
            this.lblKorime.Name = "lblKorime";
            this.lblKorime.Size = new System.Drawing.Size(165, 24);
            this.lblKorime.TabIndex = 6;
            this.lblKorime.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLozinka.Location = new System.Drawing.Point(355, 269);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(94, 24);
            this.lblLozinka.TabIndex = 7;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslov.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelNaslov.Location = new System.Drawing.Point(151, 9);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(746, 121);
            this.labelNaslov.TabIndex = 8;
            this.labelNaslov.Text = "Inpro Automobili";
            this.labelNaslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPrijava
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(780, 537);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorime);
            this.Controls.Add(this.txtBoxLozinka);
            this.Controls.Add(this.txtBoxKorime);
            this.Controls.Add(this.btnPrijaviSe);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(802, 593);
            this.MinimizeBox = false;
            this.Name = "FrmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.TextBox txtBoxKorime;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.Label lblKorime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label labelNaslov;
    }
}