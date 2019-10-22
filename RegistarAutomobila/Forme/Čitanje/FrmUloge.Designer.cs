namespace RegistarAutomobila.Forme
{
    partial class FrmUloge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUloge));
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnNoviUnos = new System.Windows.Forms.Button();
            this.dgvUloge = new System.Windows.Forms.DataGridView();
            this.lblPregledSvihUloga = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.labelNaslov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUloge)).BeginInit();
            this.SuspendLayout();
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
            this.btnAzuriraj.Location = new System.Drawing.Point(725, 452);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(127, 39);
            this.btnAzuriraj.TabIndex = 29;
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
            this.btnObriši.Location = new System.Drawing.Point(860, 452);
            this.btnObriši.Margin = new System.Windows.Forms.Padding(4);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(127, 39);
            this.btnObriši.TabIndex = 28;
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
            this.btnNoviUnos.Location = new System.Drawing.Point(351, 452);
            this.btnNoviUnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoviUnos.Name = "btnNoviUnos";
            this.btnNoviUnos.Size = new System.Drawing.Size(127, 39);
            this.btnNoviUnos.TabIndex = 27;
            this.btnNoviUnos.Text = "Novi unos";
            this.btnNoviUnos.UseVisualStyleBackColor = false;
            this.btnNoviUnos.Click += new System.EventHandler(this.btnNoviUnos_Click);
            // 
            // dgvUloge
            // 
            this.dgvUloge.AllowUserToAddRows = false;
            this.dgvUloge.AllowUserToDeleteRows = false;
            this.dgvUloge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUloge.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvUloge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUloge.Location = new System.Drawing.Point(351, 182);
            this.dgvUloge.MultiSelect = false;
            this.dgvUloge.Name = "dgvUloge";
            this.dgvUloge.RowTemplate.Height = 28;
            this.dgvUloge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUloge.Size = new System.Drawing.Size(636, 263);
            this.dgvUloge.TabIndex = 26;
            // 
            // lblPregledSvihUloga
            // 
            this.lblPregledSvihUloga.AutoSize = true;
            this.lblPregledSvihUloga.Location = new System.Drawing.Point(346, 150);
            this.lblPregledSvihUloga.Name = "lblPregledSvihUloga";
            this.lblPregledSvihUloga.Size = new System.Drawing.Size(206, 29);
            this.lblPregledSvihUloga.TabIndex = 25;
            this.lblPregledSvihUloga.Text = "Pregled svih uloga";
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
            this.labelNaslov.Location = new System.Drawing.Point(420, 13);
            this.labelNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(746, 121);
            this.labelNaslov.TabIndex = 23;
            this.labelNaslov.Text = "Inpro Automobili";
            // 
            // FrmUloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1820, 949);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnNoviUnos);
            this.Controls.Add(this.dgvUloge);
            this.Controls.Add(this.lblPregledSvihUloga);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.labelNaslov);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUloge";
            this.Text = "Upravljanje ulogama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvUloge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnNoviUnos;
        private System.Windows.Forms.DataGridView dgvUloge;
        private System.Windows.Forms.Label lblPregledSvihUloga;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label labelNaslov;
    }
}