namespace MyCookingRecipes
{
    partial class PrzepisyOkno
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
            this.groupBoxListaPrzepisow = new System.Windows.Forms.GroupBox();
            this.textBoxSzukajPrzepis = new System.Windows.Forms.TextBox();
            this.dataGridViewPrzepisyOknoLista = new System.Windows.Forms.DataGridView();
            this.buttonDodajNowyPrzepis = new System.Windows.Forms.Button();
            this.buttonModyfikujPrzepis = new System.Windows.Forms.Button();
            this.buttonUsunPrzepis = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.groupBoxListaPrzepisow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrzepisyOknoLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListaPrzepisow
            // 
            this.groupBoxListaPrzepisow.Controls.Add(this.textBoxSzukajPrzepis);
            this.groupBoxListaPrzepisow.Controls.Add(this.dataGridViewPrzepisyOknoLista);
            this.groupBoxListaPrzepisow.Location = new System.Drawing.Point(8, 38);
            this.groupBoxListaPrzepisow.Name = "groupBoxListaPrzepisow";
            this.groupBoxListaPrzepisow.Size = new System.Drawing.Size(586, 395);
            this.groupBoxListaPrzepisow.TabIndex = 0;
            this.groupBoxListaPrzepisow.TabStop = false;
            this.groupBoxListaPrzepisow.Text = "Lista przepisów";
            // 
            // textBoxSzukajPrzepis
            // 
            this.textBoxSzukajPrzepis.Location = new System.Drawing.Point(7, 22);
            this.textBoxSzukajPrzepis.Name = "textBoxSzukajPrzepis";
            this.textBoxSzukajPrzepis.Size = new System.Drawing.Size(573, 20);
            this.textBoxSzukajPrzepis.TabIndex = 1;
            this.textBoxSzukajPrzepis.TextChanged += new System.EventHandler(this.textBoxSzukajPrzepis_TextChanged);
            // 
            // dataGridViewPrzepisyOknoLista
            // 
            this.dataGridViewPrzepisyOknoLista.AllowUserToAddRows = false;
            this.dataGridViewPrzepisyOknoLista.AllowUserToDeleteRows = false;
            this.dataGridViewPrzepisyOknoLista.AllowUserToResizeColumns = false;
            this.dataGridViewPrzepisyOknoLista.AllowUserToResizeRows = false;
            this.dataGridViewPrzepisyOknoLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrzepisyOknoLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrzepisyOknoLista.Location = new System.Drawing.Point(7, 48);
            this.dataGridViewPrzepisyOknoLista.Name = "dataGridViewPrzepisyOknoLista";
            this.dataGridViewPrzepisyOknoLista.ReadOnly = true;
            this.dataGridViewPrzepisyOknoLista.RowHeadersVisible = false;
            this.dataGridViewPrzepisyOknoLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrzepisyOknoLista.Size = new System.Drawing.Size(573, 337);
            this.dataGridViewPrzepisyOknoLista.TabIndex = 0;
            this.dataGridViewPrzepisyOknoLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrzepisyOknoLista_CellContentClick);
            this.dataGridViewPrzepisyOknoLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrzepisyOknoLista_CellDoubleClick);
            // 
            // buttonDodajNowyPrzepis
            // 
            this.buttonDodajNowyPrzepis.Location = new System.Drawing.Point(8, 9);
            this.buttonDodajNowyPrzepis.Name = "buttonDodajNowyPrzepis";
            this.buttonDodajNowyPrzepis.Size = new System.Drawing.Size(140, 23);
            this.buttonDodajNowyPrzepis.TabIndex = 1;
            this.buttonDodajNowyPrzepis.Text = "Dodaj nowy przepis";
            this.buttonDodajNowyPrzepis.UseVisualStyleBackColor = true;
            this.buttonDodajNowyPrzepis.Click += new System.EventHandler(this.buttonDodajPrzepis_Click);
            // 
            // buttonModyfikujPrzepis
            // 
            this.buttonModyfikujPrzepis.Location = new System.Drawing.Point(154, 9);
            this.buttonModyfikujPrzepis.Name = "buttonModyfikujPrzepis";
            this.buttonModyfikujPrzepis.Size = new System.Drawing.Size(171, 23);
            this.buttonModyfikujPrzepis.TabIndex = 2;
            this.buttonModyfikujPrzepis.Text = "Modyfikuj zaznaczony przepis";
            this.buttonModyfikujPrzepis.UseVisualStyleBackColor = true;
            this.buttonModyfikujPrzepis.Click += new System.EventHandler(this.buttonModyfikujPrzepis_Click);
            // 
            // buttonUsunPrzepis
            // 
            this.buttonUsunPrzepis.Location = new System.Drawing.Point(331, 9);
            this.buttonUsunPrzepis.Name = "buttonUsunPrzepis";
            this.buttonUsunPrzepis.Size = new System.Drawing.Size(138, 23);
            this.buttonUsunPrzepis.TabIndex = 3;
            this.buttonUsunPrzepis.Text = "Usuń zaznaczony przepis";
            this.buttonUsunPrzepis.UseVisualStyleBackColor = true;
            this.buttonUsunPrzepis.Click += new System.EventHandler(this.buttonUsunPrzepis_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(475, 9);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(113, 23);
            this.buttonZamknij.TabIndex = 4;
            this.buttonZamknij.Text = "Wyjdź";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // PrzepisyOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 445);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.buttonUsunPrzepis);
            this.Controls.Add(this.buttonModyfikujPrzepis);
            this.Controls.Add(this.buttonDodajNowyPrzepis);
            this.Controls.Add(this.groupBoxListaPrzepisow);
            this.Name = "PrzepisyOkno";
            this.Text = "PrzepisyOkno";
            this.Load += new System.EventHandler(this.PrzepisyOkno_Load);
            this.groupBoxListaPrzepisow.ResumeLayout(false);
            this.groupBoxListaPrzepisow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrzepisyOknoLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListaPrzepisow;
        private System.Windows.Forms.DataGridView dataGridViewPrzepisyOknoLista;
        private System.Windows.Forms.TextBox textBoxSzukajPrzepis;
        private System.Windows.Forms.Button buttonDodajNowyPrzepis;
        private System.Windows.Forms.Button buttonModyfikujPrzepis;
        private System.Windows.Forms.Button buttonUsunPrzepis;
        private System.Windows.Forms.Button buttonZamknij;
    }
}