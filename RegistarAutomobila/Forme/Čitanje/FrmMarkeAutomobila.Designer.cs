namespace RegistarAutomobila.Forme
{
    partial class FrmMarkeAutomobila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarkeAutomobila));
            this.labelNaslov = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dgvSveMarke = new System.Windows.Forms.DataGridView();
            this.btnNoviUnos = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnOsvjeziPrikaz = new System.Windows.Forms.Button();
            this.groupBoxTrazilica = new System.Windows.Forms.GroupBox();
            this.lblKljucnaRijec = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtBoxKljucnaRijec = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveMarke)).BeginInit();
            this.groupBoxTrazilica.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslov.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelNaslov.Location = new System.Drawing.Point(419, 11);
            this.labelNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(746, 121);
            this.labelNaslov.TabIndex = 2;
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
            this.btnNatrag.Location = new System.Drawing.Point(14, 11);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(4);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(145, 57);
            this.btnNatrag.TabIndex = 5;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // dgvSveMarke
            // 
            this.dgvSveMarke.AllowUserToAddRows = false;
            this.dgvSveMarke.AllowUserToDeleteRows = false;
            this.dgvSveMarke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSveMarke.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvSveMarke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveMarke.Location = new System.Drawing.Point(350, 234);
            this.dgvSveMarke.MultiSelect = false;
            this.dgvSveMarke.Name = "dgvSveMarke";
            this.dgvSveMarke.RowTemplate.Height = 28;
            this.dgvSveMarke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSveMarke.Size = new System.Drawing.Size(636, 263);
            this.dgvSveMarke.TabIndex = 7;
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
            this.btnNoviUnos.Location = new System.Drawing.Point(350, 504);
            this.btnNoviUnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoviUnos.Name = "btnNoviUnos";
            this.btnNoviUnos.Size = new System.Drawing.Size(127, 39);
            this.btnNoviUnos.TabIndex = 8;
            this.btnNoviUnos.Text = "Novi unos";
            this.btnNoviUnos.UseVisualStyleBackColor = false;
            this.btnNoviUnos.Click += new System.EventHandler(this.btnNoviUnos_Click);
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
            this.btnObriši.Location = new System.Drawing.Point(859, 504);
            this.btnObriši.Margin = new System.Windows.Forms.Padding(4);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(127, 39);
            this.btnObriši.TabIndex = 9;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = false;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
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
            this.btnAzuriraj.Location = new System.Drawing.Point(724, 504);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(127, 39);
            this.btnAzuriraj.TabIndex = 10;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnOsvjeziPrikaz
            // 
            this.btnOsvjeziPrikaz.BackColor = System.Drawing.Color.AliceBlue;
            this.btnOsvjeziPrikaz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOsvjeziPrikaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnOsvjeziPrikaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOsvjeziPrikaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjeziPrikaz.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjeziPrikaz.ForeColor = System.Drawing.Color.Black;
            this.btnOsvjeziPrikaz.Location = new System.Drawing.Point(350, 192);
            this.btnOsvjeziPrikaz.Margin = new System.Windows.Forms.Padding(4);
            this.btnOsvjeziPrikaz.Name = "btnOsvjeziPrikaz";
            this.btnOsvjeziPrikaz.Size = new System.Drawing.Size(144, 36);
            this.btnOsvjeziPrikaz.TabIndex = 31;
            this.btnOsvjeziPrikaz.Text = "Osvježi prikaz";
            this.btnOsvjeziPrikaz.UseVisualStyleBackColor = false;
            this.btnOsvjeziPrikaz.Click += new System.EventHandler(this.btnOsvjeziPrikaz_Click);
            // 
            // groupBoxTrazilica
            // 
            this.groupBoxTrazilica.Controls.Add(this.lblKljucnaRijec);
            this.groupBoxTrazilica.Controls.Add(this.comboBoxFilter);
            this.groupBoxTrazilica.Controls.Add(this.lblFilter);
            this.groupBoxTrazilica.Controls.Add(this.btnTrazi);
            this.groupBoxTrazilica.Controls.Add(this.txtBoxKljucnaRijec);
            this.groupBoxTrazilica.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxTrazilica.Location = new System.Drawing.Point(591, 114);
            this.groupBoxTrazilica.Name = "groupBoxTrazilica";
            this.groupBoxTrazilica.Size = new System.Drawing.Size(395, 114);
            this.groupBoxTrazilica.TabIndex = 30;
            this.groupBoxTrazilica.TabStop = false;
            this.groupBoxTrazilica.Text = "Tražilica";
            // 
            // lblKljucnaRijec
            // 
            this.lblKljucnaRijec.AutoSize = true;
            this.lblKljucnaRijec.ForeColor = System.Drawing.Color.Black;
            this.lblKljucnaRijec.Location = new System.Drawing.Point(3, 76);
            this.lblKljucnaRijec.Name = "lblKljucnaRijec";
            this.lblKljucnaRijec.Size = new System.Drawing.Size(150, 29);
            this.lblKljucnaRijec.TabIndex = 29;
            this.lblKljucnaRijec.Text = "Ključna riječ:";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Sve",
            "Naziv",
            "Država"});
            this.comboBoxFilter.Location = new System.Drawing.Point(105, 30);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(148, 37);
            this.comboBoxFilter.TabIndex = 26;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.ForeColor = System.Drawing.Color.Black;
            this.lblFilter.Location = new System.Drawing.Point(55, 33);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(74, 29);
            this.lblFilter.TabIndex = 28;
            this.lblFilter.Text = "Filter:";
            // 
            // btnTrazi
            // 
            this.btnTrazi.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTrazi.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTrazi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnTrazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrazi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.ForeColor = System.Drawing.Color.Black;
            this.btnTrazi.Location = new System.Drawing.Point(261, 73);
            this.btnTrazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(127, 28);
            this.btnTrazi.TabIndex = 24;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtBoxKljucnaRijec
            // 
            this.txtBoxKljucnaRijec.Location = new System.Drawing.Point(105, 73);
            this.txtBoxKljucnaRijec.Name = "txtBoxKljucnaRijec";
            this.txtBoxKljucnaRijec.Size = new System.Drawing.Size(149, 36);
            this.txtBoxKljucnaRijec.TabIndex = 23;
            // 
            // FrmMarkeAutomobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1820, 949);
            this.Controls.Add(this.btnOsvjeziPrikaz);
            this.Controls.Add(this.groupBoxTrazilica);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnNoviUnos);
            this.Controls.Add(this.dgvSveMarke);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.labelNaslov);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMarkeAutomobila";
            this.Text = "Marke automobila";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveMarke)).EndInit();
            this.groupBoxTrazilica.ResumeLayout(false);
            this.groupBoxTrazilica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridView dgvSveMarke;
        private System.Windows.Forms.Button btnNoviUnos;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnOsvjeziPrikaz;
        private System.Windows.Forms.GroupBox groupBoxTrazilica;
        private System.Windows.Forms.Label lblKljucnaRijec;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtBoxKljucnaRijec;
    }
}