namespace RegistarAutomobila.Forme.Dodavanje
{
    partial class FrmDodajUlogu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajUlogu));
            this.lblNazivUloge = new System.Windows.Forms.Label();
            this.txtBoxNazivUloge = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.groupBoxUnosUloge = new System.Windows.Forms.GroupBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.groupBoxUnosUloge.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNazivUloge
            // 
            this.lblNazivUloge.AutoSize = true;
            this.lblNazivUloge.Location = new System.Drawing.Point(471, 244);
            this.lblNazivUloge.Name = "lblNazivUloge";
            this.lblNazivUloge.Size = new System.Drawing.Size(78, 29);
            this.lblNazivUloge.TabIndex = 26;
            this.lblNazivUloge.Text = "Naziv:";
            // 
            // txtBoxNazivUloge
            // 
            this.txtBoxNazivUloge.Location = new System.Drawing.Point(530, 241);
            this.txtBoxNazivUloge.Name = "txtBoxNazivUloge";
            this.txtBoxNazivUloge.Size = new System.Drawing.Size(294, 36);
            this.txtBoxNazivUloge.TabIndex = 25;
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
            // groupBoxUnosUloge
            // 
            this.groupBoxUnosUloge.Controls.Add(this.btnSpremi);
            this.groupBoxUnosUloge.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxUnosUloge.Location = new System.Drawing.Point(410, 162);
            this.groupBoxUnosUloge.Name = "groupBoxUnosUloge";
            this.groupBoxUnosUloge.Size = new System.Drawing.Size(518, 234);
            this.groupBoxUnosUloge.TabIndex = 29;
            this.groupBoxUnosUloge.TabStop = false;
            this.groupBoxUnosUloge.Text = "Unos nove uloge";
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
            this.btnSpremi.Location = new System.Drawing.Point(193, 176);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(127, 39);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FrmDodajUlogu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1820, 949);
            this.Controls.Add(this.lblNazivUloge);
            this.Controls.Add(this.txtBoxNazivUloge);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.groupBoxUnosUloge);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDodajUlogu";
            this.Text = "Dodavanje nove uloge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxUnosUloge.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNazivUloge;
        private System.Windows.Forms.TextBox txtBoxNazivUloge;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.GroupBox groupBoxUnosUloge;
        private System.Windows.Forms.Button btnSpremi;
    }
}