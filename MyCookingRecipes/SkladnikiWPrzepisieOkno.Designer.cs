namespace MyCookingRecipes
{
    partial class SkladnikiWPrzepisieOkno
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
            this.dataGridViewSkladniki = new System.Windows.Forms.DataGridView();
            this.groupBoxListaSkladnikow = new System.Windows.Forms.GroupBox();
            this.textBoxSzukajSkladniki = new System.Windows.Forms.TextBox();
            this.groupBoxDodajSkladnikWPrzepisie = new System.Windows.Forms.GroupBox();
            this.labelRodzajIlosciNazwa = new System.Windows.Forms.Label();
            this.labelRodzajIlosci = new System.Windows.Forms.Label();
            this.buttonDodajDoPrzepisu = new System.Windows.Forms.Button();
            this.numericUpDownIlosc = new System.Windows.Forms.NumericUpDown();
            this.labelIlosc = new System.Windows.Forms.Label();
            this.labelWybranySkladnikNazwa = new System.Windows.Forms.Label();
            this.labelWybranySkladnik = new System.Windows.Forms.Label();
            this.buttonSkladnikiOkno = new System.Windows.Forms.Button();
            this.buttonWyjdz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkladniki)).BeginInit();
            this.groupBoxListaSkladnikow.SuspendLayout();
            this.groupBoxDodajSkladnikWPrzepisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIlosc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSkladniki
            // 
            this.dataGridViewSkladniki.AllowUserToAddRows = false;
            this.dataGridViewSkladniki.AllowUserToDeleteRows = false;
            this.dataGridViewSkladniki.AllowUserToResizeColumns = false;
            this.dataGridViewSkladniki.AllowUserToResizeRows = false;
            this.dataGridViewSkladniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSkladniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkladniki.Location = new System.Drawing.Point(6, 46);
            this.dataGridViewSkladniki.MultiSelect = false;
            this.dataGridViewSkladniki.Name = "dataGridViewSkladniki";
            this.dataGridViewSkladniki.ReadOnly = true;
            this.dataGridViewSkladniki.RowHeadersVisible = false;
            this.dataGridViewSkladniki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSkladniki.Size = new System.Drawing.Size(398, 261);
            this.dataGridViewSkladniki.TabIndex = 0;
            this.dataGridViewSkladniki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSkladniki_CellClick);
            this.dataGridViewSkladniki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSkladnikiWPrzepisie_CellContentClick);
            // 
            // groupBoxListaSkladnikow
            // 
            this.groupBoxListaSkladnikow.Controls.Add(this.textBoxSzukajSkladniki);
            this.groupBoxListaSkladnikow.Controls.Add(this.dataGridViewSkladniki);
            this.groupBoxListaSkladnikow.Location = new System.Drawing.Point(13, 13);
            this.groupBoxListaSkladnikow.Name = "groupBoxListaSkladnikow";
            this.groupBoxListaSkladnikow.Size = new System.Drawing.Size(410, 318);
            this.groupBoxListaSkladnikow.TabIndex = 1;
            this.groupBoxListaSkladnikow.TabStop = false;
            this.groupBoxListaSkladnikow.Text = "Lista składników";
            // 
            // textBoxSzukajSkladniki
            // 
            this.textBoxSzukajSkladniki.Location = new System.Drawing.Point(7, 20);
            this.textBoxSzukajSkladniki.Name = "textBoxSzukajSkladniki";
            this.textBoxSzukajSkladniki.Size = new System.Drawing.Size(397, 20);
            this.textBoxSzukajSkladniki.TabIndex = 1;
            this.textBoxSzukajSkladniki.TextChanged += new System.EventHandler(this.textBoxSzukajSkladniki_TextChanged);
            // 
            // groupBoxDodajSkladnikWPrzepisie
            // 
            this.groupBoxDodajSkladnikWPrzepisie.Controls.Add(this.labelRodzajIlosciNazwa);
            this.groupBoxDodajSkladnikWPrzepisie.Controls.Add(this.labelRodzajIlosci);
            this.groupBoxDodajSkladnikWPrzepisie.Controls.Add(this.buttonDodajDoPrzepisu);
            this.groupBoxDodajSkladnikWPrzepisie.Controls.Add(this.numericUpDownIlosc);
            this.groupBoxDodajSkladnikWPrzepisie.Controls.Add(this.labelIlosc);
            this.groupBoxDodajSkladnikWPrzepisie.Controls.Add(this.labelWybranySkladnikNazwa);
            this.groupBoxDodajSkladnikWPrzepisie.Controls.Add(this.labelWybranySkladnik);
            this.groupBoxDodajSkladnikWPrzepisie.Location = new System.Drawing.Point(430, 13);
            this.groupBoxDodajSkladnikWPrzepisie.Name = "groupBoxDodajSkladnikWPrzepisie";
            this.groupBoxDodajSkladnikWPrzepisie.Size = new System.Drawing.Size(244, 235);
            this.groupBoxDodajSkladnikWPrzepisie.TabIndex = 2;
            this.groupBoxDodajSkladnikWPrzepisie.TabStop = false;
            this.groupBoxDodajSkladnikWPrzepisie.Text = "Dodawanie składnika do przepisu";
            // 
            // labelRodzajIlosciNazwa
            // 
            this.labelRodzajIlosciNazwa.AutoSize = true;
            this.labelRodzajIlosciNazwa.Location = new System.Drawing.Point(13, 88);
            this.labelRodzajIlosciNazwa.Name = "labelRodzajIlosciNazwa";
            this.labelRodzajIlosciNazwa.Size = new System.Drawing.Size(35, 13);
            this.labelRodzajIlosciNazwa.TabIndex = 6;
            this.labelRodzajIlosciNazwa.Text = "label5";
            // 
            // labelRodzajIlosci
            // 
            this.labelRodzajIlosci.AutoSize = true;
            this.labelRodzajIlosci.Location = new System.Drawing.Point(13, 75);
            this.labelRodzajIlosci.Name = "labelRodzajIlosci";
            this.labelRodzajIlosci.Size = new System.Drawing.Size(116, 13);
            this.labelRodzajIlosci.TabIndex = 5;
            this.labelRodzajIlosci.Text = "Rodzaj ilości składnika";
            // 
            // buttonDodajDoPrzepisu
            // 
            this.buttonDodajDoPrzepisu.Location = new System.Drawing.Point(6, 188);
            this.buttonDodajDoPrzepisu.Name = "buttonDodajDoPrzepisu";
            this.buttonDodajDoPrzepisu.Size = new System.Drawing.Size(232, 41);
            this.buttonDodajDoPrzepisu.TabIndex = 4;
            this.buttonDodajDoPrzepisu.Text = "Dodaj do przepisu";
            this.buttonDodajDoPrzepisu.UseVisualStyleBackColor = true;
            this.buttonDodajDoPrzepisu.Click += new System.EventHandler(this.buttonDodajDoPrzepisu_Click);
            // 
            // numericUpDownIlosc
            // 
            this.numericUpDownIlosc.Location = new System.Drawing.Point(13, 149);
            this.numericUpDownIlosc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIlosc.Name = "numericUpDownIlosc";
            this.numericUpDownIlosc.Size = new System.Drawing.Size(165, 20);
            this.numericUpDownIlosc.TabIndex = 3;
            this.numericUpDownIlosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelIlosc
            // 
            this.labelIlosc.AutoSize = true;
            this.labelIlosc.Location = new System.Drawing.Point(13, 133);
            this.labelIlosc.Name = "labelIlosc";
            this.labelIlosc.Size = new System.Drawing.Size(165, 13);
            this.labelIlosc.TabIndex = 2;
            this.labelIlosc.Text = "Ilość [wg rodzaju ilości składnika]";
            // 
            // labelWybranySkladnikNazwa
            // 
            this.labelWybranySkladnikNazwa.AutoSize = true;
            this.labelWybranySkladnikNazwa.Location = new System.Drawing.Point(13, 40);
            this.labelWybranySkladnikNazwa.Name = "labelWybranySkladnikNazwa";
            this.labelWybranySkladnikNazwa.Size = new System.Drawing.Size(35, 13);
            this.labelWybranySkladnikNazwa.TabIndex = 1;
            this.labelWybranySkladnikNazwa.Text = "label2";
            // 
            // labelWybranySkladnik
            // 
            this.labelWybranySkladnik.AutoSize = true;
            this.labelWybranySkladnik.Location = new System.Drawing.Point(13, 27);
            this.labelWybranySkladnik.Name = "labelWybranySkladnik";
            this.labelWybranySkladnik.Size = new System.Drawing.Size(93, 13);
            this.labelWybranySkladnik.TabIndex = 0;
            this.labelWybranySkladnik.Text = "Wybrany składnik";
            // 
            // buttonSkladnikiOkno
            // 
            this.buttonSkladnikiOkno.Location = new System.Drawing.Point(430, 254);
            this.buttonSkladnikiOkno.Name = "buttonSkladnikiOkno";
            this.buttonSkladnikiOkno.Size = new System.Drawing.Size(244, 35);
            this.buttonSkladnikiOkno.TabIndex = 3;
            this.buttonSkladnikiOkno.Text = "Zarządzaj składnikami";
            this.buttonSkladnikiOkno.UseVisualStyleBackColor = true;
            this.buttonSkladnikiOkno.Click += new System.EventHandler(this.buttonSkladnikiOkno_Click);
            // 
            // buttonWyjdz
            // 
            this.buttonWyjdz.Location = new System.Drawing.Point(430, 295);
            this.buttonWyjdz.Name = "buttonWyjdz";
            this.buttonWyjdz.Size = new System.Drawing.Size(244, 36);
            this.buttonWyjdz.TabIndex = 4;
            this.buttonWyjdz.Text = "Wyjdź";
            this.buttonWyjdz.UseVisualStyleBackColor = true;
            this.buttonWyjdz.Click += new System.EventHandler(this.buttonWyjdz_Click);
            // 
            // SkladnikiWPrzepisieOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 345);
            this.Controls.Add(this.buttonWyjdz);
            this.Controls.Add(this.buttonSkladnikiOkno);
            this.Controls.Add(this.groupBoxDodajSkladnikWPrzepisie);
            this.Controls.Add(this.groupBoxListaSkladnikow);
            this.Name = "SkladnikiWPrzepisieOkno";
            this.Text = "SkladnikiWPrzepisieOkno";
            this.Load += new System.EventHandler(this.SkladnikiWPrzepisieOkno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkladniki)).EndInit();
            this.groupBoxListaSkladnikow.ResumeLayout(false);
            this.groupBoxListaSkladnikow.PerformLayout();
            this.groupBoxDodajSkladnikWPrzepisie.ResumeLayout(false);
            this.groupBoxDodajSkladnikWPrzepisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIlosc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSkladniki;
        private System.Windows.Forms.GroupBox groupBoxListaSkladnikow;
        private System.Windows.Forms.TextBox textBoxSzukajSkladniki;
        private System.Windows.Forms.GroupBox groupBoxDodajSkladnikWPrzepisie;
        private System.Windows.Forms.Label labelRodzajIlosciNazwa;
        private System.Windows.Forms.Label labelRodzajIlosci;
        private System.Windows.Forms.Button buttonDodajDoPrzepisu;
        private System.Windows.Forms.NumericUpDown numericUpDownIlosc;
        private System.Windows.Forms.Label labelIlosc;
        private System.Windows.Forms.Label labelWybranySkladnikNazwa;
        private System.Windows.Forms.Label labelWybranySkladnik;
        private System.Windows.Forms.Button buttonSkladnikiOkno;
        private System.Windows.Forms.Button buttonWyjdz;
    }
}