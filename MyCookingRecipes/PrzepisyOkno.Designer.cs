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
            this.buttonSzukajPrzepis = new System.Windows.Forms.Button();
            this.textBoxSzukajPrzepis = new System.Windows.Forms.TextBox();
            this.dataGridViewPrzepisyOknoLista = new System.Windows.Forms.DataGridView();
            this.buttonDodajNowyPrzepis = new System.Windows.Forms.Button();
            this.buttonModyfikujPrzepis = new System.Windows.Forms.Button();
            this.buttonUsunPrzepis = new System.Windows.Forms.Button();
            this.groupBoxListaPrzepisow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrzepisyOknoLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListaPrzepisow
            // 
            this.groupBoxListaPrzepisow.Controls.Add(this.buttonSzukajPrzepis);
            this.groupBoxListaPrzepisow.Controls.Add(this.textBoxSzukajPrzepis);
            this.groupBoxListaPrzepisow.Controls.Add(this.dataGridViewPrzepisyOknoLista);
            this.groupBoxListaPrzepisow.Location = new System.Drawing.Point(8, 38);
            this.groupBoxListaPrzepisow.Name = "groupBoxListaPrzepisow";
            this.groupBoxListaPrzepisow.Size = new System.Drawing.Size(586, 395);
            this.groupBoxListaPrzepisow.TabIndex = 0;
            this.groupBoxListaPrzepisow.TabStop = false;
            this.groupBoxListaPrzepisow.Text = "Lista przepisów";
            // 
            // buttonSzukajPrzepis
            // 
            this.buttonSzukajPrzepis.Location = new System.Drawing.Point(421, 20);
            this.buttonSzukajPrzepis.Name = "buttonSzukajPrzepis";
            this.buttonSzukajPrzepis.Size = new System.Drawing.Size(159, 23);
            this.buttonSzukajPrzepis.TabIndex = 2;
            this.buttonSzukajPrzepis.Text = "Szukaj";
            this.buttonSzukajPrzepis.UseVisualStyleBackColor = true;
            this.buttonSzukajPrzepis.Click += new System.EventHandler(this.buttonSzukajPrzepis_Click);
            // 
            // textBoxSzukajPrzepis
            // 
            this.textBoxSzukajPrzepis.Location = new System.Drawing.Point(7, 22);
            this.textBoxSzukajPrzepis.Name = "textBoxSzukajPrzepis";
            this.textBoxSzukajPrzepis.Size = new System.Drawing.Size(408, 20);
            this.textBoxSzukajPrzepis.TabIndex = 1;
            // 
            // dataGridViewPrzepisyOknoLista
            // 
            this.dataGridViewPrzepisyOknoLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrzepisyOknoLista.Location = new System.Drawing.Point(7, 48);
            this.dataGridViewPrzepisyOknoLista.Name = "dataGridViewPrzepisyOknoLista";
            this.dataGridViewPrzepisyOknoLista.Size = new System.Drawing.Size(573, 337);
            this.dataGridViewPrzepisyOknoLista.TabIndex = 0;
            // 
            // buttonDodajNowyPrzepis
            // 
            this.buttonDodajNowyPrzepis.Location = new System.Drawing.Point(8, 9);
            this.buttonDodajNowyPrzepis.Name = "buttonDodajNowyPrzepis";
            this.buttonDodajNowyPrzepis.Size = new System.Drawing.Size(197, 23);
            this.buttonDodajNowyPrzepis.TabIndex = 1;
            this.buttonDodajNowyPrzepis.Text = "Dodaj nowy przepis";
            this.buttonDodajNowyPrzepis.UseVisualStyleBackColor = true;
            this.buttonDodajNowyPrzepis.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonModyfikujPrzepis
            // 
            this.buttonModyfikujPrzepis.Location = new System.Drawing.Point(211, 9);
            this.buttonModyfikujPrzepis.Name = "buttonModyfikujPrzepis";
            this.buttonModyfikujPrzepis.Size = new System.Drawing.Size(201, 23);
            this.buttonModyfikujPrzepis.TabIndex = 2;
            this.buttonModyfikujPrzepis.Text = "Modyfikuj zaznaczony przepis";
            this.buttonModyfikujPrzepis.UseVisualStyleBackColor = true;
            this.buttonModyfikujPrzepis.Click += new System.EventHandler(this.buttonModyfikujPrzepis_Click);
            // 
            // buttonUsunPrzepis
            // 
            this.buttonUsunPrzepis.Location = new System.Drawing.Point(418, 9);
            this.buttonUsunPrzepis.Name = "buttonUsunPrzepis";
            this.buttonUsunPrzepis.Size = new System.Drawing.Size(176, 23);
            this.buttonUsunPrzepis.TabIndex = 3;
            this.buttonUsunPrzepis.Text = "Usuń zaznaczony przepis";
            this.buttonUsunPrzepis.UseVisualStyleBackColor = true;
            this.buttonUsunPrzepis.Click += new System.EventHandler(this.buttonUsunPrzepis_Click);
            // 
            // PrzepisyOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 445);
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
        private System.Windows.Forms.Button buttonSzukajPrzepis;
        private System.Windows.Forms.TextBox textBoxSzukajPrzepis;
        private System.Windows.Forms.Button buttonDodajNowyPrzepis;
        private System.Windows.Forms.Button buttonModyfikujPrzepis;
        private System.Windows.Forms.Button buttonUsunPrzepis;
    }
}