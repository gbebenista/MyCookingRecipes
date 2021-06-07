namespace MyCookingRecipes
{
    partial class SkladnikiOkno
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
            this.groupBoxListaSkladnikow = new System.Windows.Forms.GroupBox();
            this.buttonWyszukajSkladnik = new System.Windows.Forms.Button();
            this.dataGridViewListaSkladnikow = new System.Windows.Forms.DataGridView();
            this.textBoxWyszukajSkladnik = new System.Windows.Forms.TextBox();
            this.groupBoxDodajSkladnik = new System.Windows.Forms.GroupBox();
            this.labelRodzajIlosciSkladnika = new System.Windows.Forms.Label();
            this.comboBoxRodzajeIlosciSkladnika = new System.Windows.Forms.ComboBox();
            this.buttonDodajSkladnik = new System.Windows.Forms.Button();
            this.labelNazwaSkladnika = new System.Windows.Forms.Label();
            this.textBoxNazwaSkladnika = new System.Windows.Forms.TextBox();
            this.buttonUsunSkladniki = new System.Windows.Forms.Button();
            this.buttonZamknijOkno = new System.Windows.Forms.Button();
            this.groupBoxListaSkladnikow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSkladnikow)).BeginInit();
            this.groupBoxDodajSkladnik.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxListaSkladnikow
            // 
            this.groupBoxListaSkladnikow.Controls.Add(this.buttonWyszukajSkladnik);
            this.groupBoxListaSkladnikow.Controls.Add(this.dataGridViewListaSkladnikow);
            this.groupBoxListaSkladnikow.Controls.Add(this.textBoxWyszukajSkladnik);
            this.groupBoxListaSkladnikow.Location = new System.Drawing.Point(12, 12);
            this.groupBoxListaSkladnikow.Name = "groupBoxListaSkladnikow";
            this.groupBoxListaSkladnikow.Size = new System.Drawing.Size(491, 359);
            this.groupBoxListaSkladnikow.TabIndex = 0;
            this.groupBoxListaSkladnikow.TabStop = false;
            this.groupBoxListaSkladnikow.Text = "Lista składników";
            // 
            // buttonWyszukajSkladnik
            // 
            this.buttonWyszukajSkladnik.Location = new System.Drawing.Point(365, 19);
            this.buttonWyszukajSkladnik.Name = "buttonWyszukajSkladnik";
            this.buttonWyszukajSkladnik.Size = new System.Drawing.Size(120, 22);
            this.buttonWyszukajSkladnik.TabIndex = 2;
            this.buttonWyszukajSkladnik.Text = "Szukaj";
            this.buttonWyszukajSkladnik.UseVisualStyleBackColor = true;
            this.buttonWyszukajSkladnik.Click += new System.EventHandler(this.buttonWyszukajSkladnik_Click);
            // 
            // dataGridViewListaSkladnikow
            // 
            this.dataGridViewListaSkladnikow.AllowUserToAddRows = false;
            this.dataGridViewListaSkladnikow.AllowUserToDeleteRows = false;
            this.dataGridViewListaSkladnikow.AllowUserToResizeColumns = false;
            this.dataGridViewListaSkladnikow.AllowUserToResizeRows = false;
            this.dataGridViewListaSkladnikow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaSkladnikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaSkladnikow.Location = new System.Drawing.Point(7, 47);
            this.dataGridViewListaSkladnikow.Name = "dataGridViewListaSkladnikow";
            this.dataGridViewListaSkladnikow.ReadOnly = true;
            this.dataGridViewListaSkladnikow.RowHeadersVisible = false;
            this.dataGridViewListaSkladnikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaSkladnikow.Size = new System.Drawing.Size(478, 306);
            this.dataGridViewListaSkladnikow.TabIndex = 1;
            // 
            // textBoxWyszukajSkladnik
            // 
            this.textBoxWyszukajSkladnik.Location = new System.Drawing.Point(7, 20);
            this.textBoxWyszukajSkladnik.Name = "textBoxWyszukajSkladnik";
            this.textBoxWyszukajSkladnik.Size = new System.Drawing.Size(352, 20);
            this.textBoxWyszukajSkladnik.TabIndex = 0;
            // 
            // groupBoxDodajSkladnik
            // 
            this.groupBoxDodajSkladnik.Controls.Add(this.labelRodzajIlosciSkladnika);
            this.groupBoxDodajSkladnik.Controls.Add(this.comboBoxRodzajeIlosciSkladnika);
            this.groupBoxDodajSkladnik.Controls.Add(this.buttonDodajSkladnik);
            this.groupBoxDodajSkladnik.Controls.Add(this.labelNazwaSkladnika);
            this.groupBoxDodajSkladnik.Controls.Add(this.textBoxNazwaSkladnika);
            this.groupBoxDodajSkladnik.Location = new System.Drawing.Point(509, 12);
            this.groupBoxDodajSkladnik.Name = "groupBoxDodajSkladnik";
            this.groupBoxDodajSkladnik.Size = new System.Drawing.Size(279, 171);
            this.groupBoxDodajSkladnik.TabIndex = 1;
            this.groupBoxDodajSkladnik.TabStop = false;
            this.groupBoxDodajSkladnik.Text = "Dodaj składnik";
            // 
            // labelRodzajIlosciSkladnika
            // 
            this.labelRodzajIlosciSkladnika.AutoSize = true;
            this.labelRodzajIlosciSkladnika.Location = new System.Drawing.Point(7, 67);
            this.labelRodzajIlosciSkladnika.Name = "labelRodzajIlosciSkladnika";
            this.labelRodzajIlosciSkladnika.Size = new System.Drawing.Size(116, 13);
            this.labelRodzajIlosciSkladnika.TabIndex = 5;
            this.labelRodzajIlosciSkladnika.Text = "Rodzaj ilości składnika";
            // 
            // comboBoxRodzajeIlosciSkladnika
            // 
            this.comboBoxRodzajeIlosciSkladnika.FormattingEnabled = true;
            this.comboBoxRodzajeIlosciSkladnika.Location = new System.Drawing.Point(7, 86);
            this.comboBoxRodzajeIlosciSkladnika.Name = "comboBoxRodzajeIlosciSkladnika";
            this.comboBoxRodzajeIlosciSkladnika.Size = new System.Drawing.Size(174, 21);
            this.comboBoxRodzajeIlosciSkladnika.TabIndex = 4;
            // 
            // buttonDodajSkladnik
            // 
            this.buttonDodajSkladnik.Location = new System.Drawing.Point(6, 124);
            this.buttonDodajSkladnik.Name = "buttonDodajSkladnik";
            this.buttonDodajSkladnik.Size = new System.Drawing.Size(266, 38);
            this.buttonDodajSkladnik.TabIndex = 3;
            this.buttonDodajSkladnik.Text = "Dodaj składnik";
            this.buttonDodajSkladnik.UseVisualStyleBackColor = true;
            this.buttonDodajSkladnik.Click += new System.EventHandler(this.buttonDodajSkladnik_Click);
            // 
            // labelNazwaSkladnika
            // 
            this.labelNazwaSkladnika.AutoSize = true;
            this.labelNazwaSkladnika.Location = new System.Drawing.Point(6, 22);
            this.labelNazwaSkladnika.Name = "labelNazwaSkladnika";
            this.labelNazwaSkladnika.Size = new System.Drawing.Size(90, 13);
            this.labelNazwaSkladnika.TabIndex = 1;
            this.labelNazwaSkladnika.Text = "Nazwa składnika";
            // 
            // textBoxNazwaSkladnika
            // 
            this.textBoxNazwaSkladnika.Location = new System.Drawing.Point(7, 38);
            this.textBoxNazwaSkladnika.Name = "textBoxNazwaSkladnika";
            this.textBoxNazwaSkladnika.Size = new System.Drawing.Size(174, 20);
            this.textBoxNazwaSkladnika.TabIndex = 0;
            // 
            // buttonUsunSkladniki
            // 
            this.buttonUsunSkladniki.Location = new System.Drawing.Point(509, 282);
            this.buttonUsunSkladniki.Name = "buttonUsunSkladniki";
            this.buttonUsunSkladniki.Size = new System.Drawing.Size(279, 40);
            this.buttonUsunSkladniki.TabIndex = 2;
            this.buttonUsunSkladniki.Text = "Usuń zaznaczone składniki";
            this.buttonUsunSkladniki.UseVisualStyleBackColor = true;
            this.buttonUsunSkladniki.Click += new System.EventHandler(this.buttonUsunSkladniki_Click);
            // 
            // buttonZamknijOkno
            // 
            this.buttonZamknijOkno.Location = new System.Drawing.Point(509, 328);
            this.buttonZamknijOkno.Name = "buttonZamknijOkno";
            this.buttonZamknijOkno.Size = new System.Drawing.Size(279, 37);
            this.buttonZamknijOkno.TabIndex = 3;
            this.buttonZamknijOkno.Text = "Wyjdź";
            this.buttonZamknijOkno.UseVisualStyleBackColor = true;
            this.buttonZamknijOkno.Click += new System.EventHandler(this.buttonZamknijOkno_Click);
            // 
            // SkladnikiOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.buttonZamknijOkno);
            this.Controls.Add(this.buttonUsunSkladniki);
            this.Controls.Add(this.groupBoxDodajSkladnik);
            this.Controls.Add(this.groupBoxListaSkladnikow);
            this.Name = "SkladnikiOkno";
            this.Text = "SkladnikiOkno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SkladnikiOkno_FormClosing);
            this.Load += new System.EventHandler(this.SkladnikiOkno_Load);
            this.groupBoxListaSkladnikow.ResumeLayout(false);
            this.groupBoxListaSkladnikow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSkladnikow)).EndInit();
            this.groupBoxDodajSkladnik.ResumeLayout(false);
            this.groupBoxDodajSkladnik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListaSkladnikow;
        private System.Windows.Forms.DataGridView dataGridViewListaSkladnikow;
        private System.Windows.Forms.TextBox textBoxWyszukajSkladnik;
        private System.Windows.Forms.Button buttonWyszukajSkladnik;
        private System.Windows.Forms.GroupBox groupBoxDodajSkladnik;
        private System.Windows.Forms.Label labelNazwaSkladnika;
        private System.Windows.Forms.TextBox textBoxNazwaSkladnika;
        private System.Windows.Forms.Button buttonUsunSkladniki;
        private System.Windows.Forms.Button buttonZamknijOkno;
        private System.Windows.Forms.Button buttonDodajSkladnik;
        private System.Windows.Forms.Label labelRodzajIlosciSkladnika;
        private System.Windows.Forms.ComboBox comboBoxRodzajeIlosciSkladnika;
    }
}