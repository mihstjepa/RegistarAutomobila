namespace RegistarAutomobila.Forme
{
    partial class FrmModeliAutomobila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModeliAutomobila));
            this.labelNaslov = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnNoviUnos = new System.Windows.Forms.Button();
            this.dgvSveMarke = new System.Windows.Forms.DataGridView();
            this.lblPregledSvihModela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveMarke)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslov.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelNaslov.Location = new System.Drawing.Point(420, 9);
            this.labelNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(746, 121);
            this.labelNaslov.TabIndex = 3;
            this.labelNaslov.Text = "Inpro Automobili";
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
            this.btnNatrag.Location = new System.Drawing.Point(13, 9);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(4);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(145, 57);
            this.btnNatrag.TabIndex = 6;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAzuriraj.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAzuriraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAzuriraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzuriraj.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.ForeColor = System.Drawing.Color.Black;
            this.btnAzuriraj.Location = new System.Drawing.Point(796, 448);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(127, 39);
            this.btnAzuriraj.TabIndex = 15;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.BackColor = System.Drawing.Color.AliceBlue;
            this.btnObriši.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnObriši.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnObriši.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnObriši.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObriši.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObriši.ForeColor = System.Drawing.Color.Black;
            this.btnObriši.Location = new System.Drawing.Point(931, 448);
            this.btnObriši.Margin = new System.Windows.Forms.Padding(4);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(127, 39);
            this.btnObriši.TabIndex = 14;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = false;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnNoviUnos
            // 
            this.btnNoviUnos.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNoviUnos.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNoviUnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnNoviUnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnNoviUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviUnos.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviUnos.ForeColor = System.Drawing.Color.Black;
            this.btnNoviUnos.Location = new System.Drawing.Point(287, 448);
            this.btnNoviUnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoviUnos.Name = "btnNoviUnos";
            this.btnNoviUnos.Size = new System.Drawing.Size(127, 39);
            this.btnNoviUnos.TabIndex = 13;
            this.btnNoviUnos.Text = "Novi unos";
            this.btnNoviUnos.UseVisualStyleBackColor = false;
            this.btnNoviUnos.Click += new System.EventHandler(this.btnNoviUnos_Click);
            // 
            // dgvSveMarke
            // 
            this.dgvSveMarke.AllowUserToAddRows = false;
            this.dgvSveMarke.AllowUserToDeleteRows = false;
            this.dgvSveMarke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSveMarke.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvSveMarke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveMarke.Location = new System.Drawing.Point(287, 178);
            this.dgvSveMarke.Name = "dgvSveMarke";
            this.dgvSveMarke.RowTemplate.Height = 28;
            this.dgvSveMarke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSveMarke.Size = new System.Drawing.Size(771, 263);
            this.dgvSveMarke.TabIndex = 12;
            // 
            // lblPregledSvihModela
            // 
            this.lblPregledSvihModela.AutoSize = true;
            this.lblPregledSvihModela.Location = new System.Drawing.Point(282, 146);
            this.lblPregledSvihModela.Name = "lblPregledSvihModela";
            this.lblPregledSvihModela.Size = new System.Drawing.Size(226, 29);
            this.lblPregledSvihModela.TabIndex = 11;
            this.lblPregledSvihModela.Text = "Pregled svih modela";
            // 
            // FrmModeliAutomobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1820, 949);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnNoviUnos);
            this.Controls.Add(this.dgvSveMarke);
            this.Controls.Add(this.lblPregledSvihModela);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.labelNaslov);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmModeliAutomobila";
            this.Text = "Modeli automobila";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveMarke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnNoviUnos;
        private System.Windows.Forms.DataGridView dgvSveMarke;
        private System.Windows.Forms.Label lblPregledSvihModela;
    }
}