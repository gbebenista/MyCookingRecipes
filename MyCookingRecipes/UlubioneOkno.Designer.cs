namespace MyCookingRecipes
{
    partial class UlubioneOkno
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
            this.groupBoxUlubione = new System.Windows.Forms.GroupBox();
            this.dataGridViewListaUlubione = new System.Windows.Forms.DataGridView();
            this.textBoxSzukaj = new System.Windows.Forms.TextBox();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.groupBoxUlubioneLista = new System.Windows.Forms.GroupBox();
            this.buttonDodajUlubiony = new System.Windows.Forms.Button();
            this.buttonUsunUlubiony = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.groupBoxUlubione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUlubione)).BeginInit();
            this.groupBoxUlubioneLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUlubione
            // 
            this.groupBoxUlubione.Controls.Add(this.buttonZamknij);
            this.groupBoxUlubione.Controls.Add(this.buttonUsunUlubiony);
            this.groupBoxUlubione.Controls.Add(this.buttonDodajUlubiony);
            this.groupBoxUlubione.Controls.Add(this.groupBoxUlubioneLista);
            this.groupBoxUlubione.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUlubione.Name = "groupBoxUlubione";
            this.groupBoxUlubione.Size = new System.Drawing.Size(497, 381);
            this.groupBoxUlubione.TabIndex = 0;
            this.groupBoxUlubione.TabStop = false;
            this.groupBoxUlubione.Text = "Ulubione przepisy";
            // 
            // dataGridViewListaUlubione
            // 
            this.dataGridViewListaUlubione.AllowUserToAddRows = false;
            this.dataGridViewListaUlubione.AllowUserToDeleteRows = false;
            this.dataGridViewListaUlubione.AllowUserToResizeColumns = false;
            this.dataGridViewListaUlubione.AllowUserToResizeRows = false;
            this.dataGridViewListaUlubione.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaUlubione.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaUlubione.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewListaUlubione.Name = "dataGridViewListaUlubione";
            this.dataGridViewListaUlubione.ReadOnly = true;
            this.dataGridViewListaUlubione.RowHeadersVisible = false;
            this.dataGridViewListaUlubione.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaUlubione.Size = new System.Drawing.Size(476, 267);
            this.dataGridViewListaUlubione.TabIndex = 0;
            // 
            // textBoxSzukaj
            // 
            this.textBoxSzukaj.Location = new System.Drawing.Point(6, 19);
            this.textBoxSzukaj.Name = "textBoxSzukaj";
            this.textBoxSzukaj.Size = new System.Drawing.Size(344, 20);
            this.textBoxSzukaj.TabIndex = 1;
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Location = new System.Drawing.Point(356, 19);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(123, 20);
            this.buttonSzukaj.TabIndex = 2;
            this.buttonSzukaj.Text = "Szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // groupBoxUlubioneLista
            // 
            this.groupBoxUlubioneLista.Controls.Add(this.textBoxSzukaj);
            this.groupBoxUlubioneLista.Controls.Add(this.buttonSzukaj);
            this.groupBoxUlubioneLista.Controls.Add(this.dataGridViewListaUlubione);
            this.groupBoxUlubioneLista.Location = new System.Drawing.Point(6, 57);
            this.groupBoxUlubioneLista.Name = "groupBoxUlubioneLista";
            this.groupBoxUlubioneLista.Size = new System.Drawing.Size(485, 318);
            this.groupBoxUlubioneLista.TabIndex = 3;
            this.groupBoxUlubioneLista.TabStop = false;
            this.groupBoxUlubioneLista.Text = "Lista ulubionych przepisów";
            // 
            // buttonDodajUlubiony
            // 
            this.buttonDodajUlubiony.Location = new System.Drawing.Point(12, 28);
            this.buttonDodajUlubiony.Name = "buttonDodajUlubiony";
            this.buttonDodajUlubiony.Size = new System.Drawing.Size(156, 23);
            this.buttonDodajUlubiony.TabIndex = 4;
            this.buttonDodajUlubiony.Text = "Dodaj do ulubionych..";
            this.buttonDodajUlubiony.UseVisualStyleBackColor = true;
            this.buttonDodajUlubiony.Click += new System.EventHandler(this.buttonDodajUlubiony_Click);
            // 
            // buttonUsunUlubiony
            // 
            this.buttonUsunUlubiony.Location = new System.Drawing.Point(174, 28);
            this.buttonUsunUlubiony.Name = "buttonUsunUlubiony";
            this.buttonUsunUlubiony.Size = new System.Drawing.Size(164, 23);
            this.buttonUsunUlubiony.TabIndex = 4;
            this.buttonUsunUlubiony.Text = "Usuń z ulubionych..";
            this.buttonUsunUlubiony.UseVisualStyleBackColor = true;
            this.buttonUsunUlubiony.Click += new System.EventHandler(this.buttonUsunUlubiony_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(344, 28);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(147, 23);
            this.buttonZamknij.TabIndex = 4;
            this.buttonZamknij.Text = "Wyjdź";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // UlubioneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 406);
            this.Controls.Add(this.groupBoxUlubione);
            this.Name = "UlubioneOkno";
            this.Text = "UlubioneOkno";
            this.Load += new System.EventHandler(this.UlubioneOkno_Load);
            this.groupBoxUlubione.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUlubione)).EndInit();
            this.groupBoxUlubioneLista.ResumeLayout(false);
            this.groupBoxUlubioneLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUlubione;
        private System.Windows.Forms.DataGridView dataGridViewListaUlubione;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Button buttonUsunUlubiony;
        private System.Windows.Forms.Button buttonDodajUlubiony;
        private System.Windows.Forms.GroupBox groupBoxUlubioneLista;
        private System.Windows.Forms.TextBox textBoxSzukaj;
        private System.Windows.Forms.Button buttonSzukaj;
    }
}