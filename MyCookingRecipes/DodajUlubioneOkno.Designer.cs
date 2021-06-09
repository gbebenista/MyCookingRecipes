namespace MyCookingRecipes
{
    partial class DodajUlubioneOkno
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
            this.groupBoxDodajUlubione = new System.Windows.Forms.GroupBox();
            this.groupBoxListaPrzepisow = new System.Windows.Forms.GroupBox();
            this.dataGridViewListaPrzepisow = new System.Windows.Forms.DataGridView();
            this.textBoxSzukaj = new System.Windows.Forms.TextBox();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonPrzepisy = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.groupBoxDodajUlubione.SuspendLayout();
            this.groupBoxListaPrzepisow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPrzepisow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDodajUlubione
            // 
            this.groupBoxDodajUlubione.Controls.Add(this.buttonZamknij);
            this.groupBoxDodajUlubione.Controls.Add(this.buttonPrzepisy);
            this.groupBoxDodajUlubione.Controls.Add(this.buttonDodaj);
            this.groupBoxDodajUlubione.Controls.Add(this.groupBoxListaPrzepisow);
            this.groupBoxDodajUlubione.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDodajUlubione.Name = "groupBoxDodajUlubione";
            this.groupBoxDodajUlubione.Size = new System.Drawing.Size(543, 480);
            this.groupBoxDodajUlubione.TabIndex = 0;
            this.groupBoxDodajUlubione.TabStop = false;
            this.groupBoxDodajUlubione.Text = "Dodaj do ulubionych";
            // 
            // groupBoxListaPrzepisow
            // 
            this.groupBoxListaPrzepisow.Controls.Add(this.buttonSzukaj);
            this.groupBoxListaPrzepisow.Controls.Add(this.textBoxSzukaj);
            this.groupBoxListaPrzepisow.Controls.Add(this.dataGridViewListaPrzepisow);
            this.groupBoxListaPrzepisow.Location = new System.Drawing.Point(7, 63);
            this.groupBoxListaPrzepisow.Name = "groupBoxListaPrzepisow";
            this.groupBoxListaPrzepisow.Size = new System.Drawing.Size(530, 411);
            this.groupBoxListaPrzepisow.TabIndex = 0;
            this.groupBoxListaPrzepisow.TabStop = false;
            this.groupBoxListaPrzepisow.Text = "Lista przepisów";
            // 
            // dataGridViewListaPrzepisow
            // 
            this.dataGridViewListaPrzepisow.AllowUserToAddRows = false;
            this.dataGridViewListaPrzepisow.AllowUserToDeleteRows = false;
            this.dataGridViewListaPrzepisow.AllowUserToResizeColumns = false;
            this.dataGridViewListaPrzepisow.AllowUserToResizeRows = false;
            this.dataGridViewListaPrzepisow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaPrzepisow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPrzepisow.Location = new System.Drawing.Point(7, 54);
            this.dataGridViewListaPrzepisow.MultiSelect = false;
            this.dataGridViewListaPrzepisow.Name = "dataGridViewListaPrzepisow";
            this.dataGridViewListaPrzepisow.ReadOnly = true;
            this.dataGridViewListaPrzepisow.RowHeadersVisible = false;
            this.dataGridViewListaPrzepisow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaPrzepisow.Size = new System.Drawing.Size(517, 351);
            this.dataGridViewListaPrzepisow.TabIndex = 0;
            // 
            // textBoxSzukaj
            // 
            this.textBoxSzukaj.Location = new System.Drawing.Point(7, 28);
            this.textBoxSzukaj.Name = "textBoxSzukaj";
            this.textBoxSzukaj.Size = new System.Drawing.Size(370, 20);
            this.textBoxSzukaj.TabIndex = 1;
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Location = new System.Drawing.Point(383, 28);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(141, 20);
            this.buttonSzukaj.TabIndex = 2;
            this.buttonSzukaj.Text = "Szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(6, 19);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(187, 38);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj przepis do ulubionych";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonPrzepisy
            // 
            this.buttonPrzepisy.Location = new System.Drawing.Point(200, 19);
            this.buttonPrzepisy.Name = "buttonPrzepisy";
            this.buttonPrzepisy.Size = new System.Drawing.Size(172, 38);
            this.buttonPrzepisy.TabIndex = 2;
            this.buttonPrzepisy.Text = "Przejdź do przepisów";
            this.buttonPrzepisy.UseVisualStyleBackColor = true;
            this.buttonPrzepisy.Click += new System.EventHandler(this.buttonPrzepisy_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(378, 19);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(159, 38);
            this.buttonZamknij.TabIndex = 3;
            this.buttonZamknij.Text = "Wyjdź";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // DodajUlubioneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 504);
            this.Controls.Add(this.groupBoxDodajUlubione);
            this.Name = "DodajUlubioneOkno";
            this.Text = "DodajUlubioneOkno";
            this.Load += new System.EventHandler(this.DodajUlubioneOkno_Load);
            this.groupBoxDodajUlubione.ResumeLayout(false);
            this.groupBoxListaPrzepisow.ResumeLayout(false);
            this.groupBoxListaPrzepisow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPrzepisow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDodajUlubione;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Button buttonPrzepisy;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.GroupBox groupBoxListaPrzepisow;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.TextBox textBoxSzukaj;
        private System.Windows.Forms.DataGridView dataGridViewListaPrzepisow;
    }
}