namespace MyCookingRecipes
{
    partial class SkladnikiNaPotrawyOkno
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
            this.dataGridViewListaPrzepisow = new System.Windows.Forms.DataGridView();
            this.textBoxSzukaj = new System.Windows.Forms.TextBox();
            this.groupBoxSkladnikiNaPotrawy = new System.Windows.Forms.GroupBox();
            this.dataGridViewListaSkladnikow = new System.Windows.Forms.DataGridView();
            this.buttonZnajdzSkladniki = new System.Windows.Forms.Button();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.groupBoxListaPrzepisow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPrzepisow)).BeginInit();
            this.groupBoxSkladnikiNaPotrawy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSkladnikow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListaPrzepisow
            // 
            this.groupBoxListaPrzepisow.Controls.Add(this.dataGridViewListaPrzepisow);
            this.groupBoxListaPrzepisow.Controls.Add(this.textBoxSzukaj);
            this.groupBoxListaPrzepisow.Location = new System.Drawing.Point(13, 13);
            this.groupBoxListaPrzepisow.Name = "groupBoxListaPrzepisow";
            this.groupBoxListaPrzepisow.Size = new System.Drawing.Size(433, 425);
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
            this.dataGridViewListaPrzepisow.Location = new System.Drawing.Point(7, 47);
            this.dataGridViewListaPrzepisow.Name = "dataGridViewListaPrzepisow";
            this.dataGridViewListaPrzepisow.ReadOnly = true;
            this.dataGridViewListaPrzepisow.RowHeadersVisible = false;
            this.dataGridViewListaPrzepisow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaPrzepisow.Size = new System.Drawing.Size(420, 372);
            this.dataGridViewListaPrzepisow.TabIndex = 1;
            // 
            // textBoxSzukaj
            // 
            this.textBoxSzukaj.Location = new System.Drawing.Point(7, 20);
            this.textBoxSzukaj.Name = "textBoxSzukaj";
            this.textBoxSzukaj.Size = new System.Drawing.Size(420, 20);
            this.textBoxSzukaj.TabIndex = 0;
            this.textBoxSzukaj.TextChanged += new System.EventHandler(this.textBoxSzukaj_TextChanged);
            // 
            // groupBoxSkladnikiNaPotrawy
            // 
            this.groupBoxSkladnikiNaPotrawy.Controls.Add(this.dataGridViewListaSkladnikow);
            this.groupBoxSkladnikiNaPotrawy.Controls.Add(this.buttonZnajdzSkladniki);
            this.groupBoxSkladnikiNaPotrawy.Location = new System.Drawing.Point(452, 13);
            this.groupBoxSkladnikiNaPotrawy.Name = "groupBoxSkladnikiNaPotrawy";
            this.groupBoxSkladnikiNaPotrawy.Size = new System.Drawing.Size(395, 386);
            this.groupBoxSkladnikiNaPotrawy.TabIndex = 1;
            this.groupBoxSkladnikiNaPotrawy.TabStop = false;
            this.groupBoxSkladnikiNaPotrawy.Text = "Składniki na potrawy";
            // 
            // dataGridViewListaSkladnikow
            // 
            this.dataGridViewListaSkladnikow.AllowUserToAddRows = false;
            this.dataGridViewListaSkladnikow.AllowUserToDeleteRows = false;
            this.dataGridViewListaSkladnikow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaSkladnikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaSkladnikow.Location = new System.Drawing.Point(7, 50);
            this.dataGridViewListaSkladnikow.MultiSelect = false;
            this.dataGridViewListaSkladnikow.Name = "dataGridViewListaSkladnikow";
            this.dataGridViewListaSkladnikow.ReadOnly = true;
            this.dataGridViewListaSkladnikow.RowHeadersVisible = false;
            this.dataGridViewListaSkladnikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaSkladnikow.Size = new System.Drawing.Size(382, 330);
            this.dataGridViewListaSkladnikow.TabIndex = 1;
            this.dataGridViewListaSkladnikow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaSkladnikow_CellContentClick);
            // 
            // buttonZnajdzSkladniki
            // 
            this.buttonZnajdzSkladniki.Location = new System.Drawing.Point(6, 20);
            this.buttonZnajdzSkladniki.Name = "buttonZnajdzSkladniki";
            this.buttonZnajdzSkladniki.Size = new System.Drawing.Size(183, 23);
            this.buttonZnajdzSkladniki.TabIndex = 0;
            this.buttonZnajdzSkladniki.Text = "Wyszukaj składniki na potrawy";
            this.buttonZnajdzSkladniki.UseVisualStyleBackColor = true;
            this.buttonZnajdzSkladniki.Click += new System.EventHandler(this.buttonZnajdzSkladniki_Click);
            // 
            // buttonPDF
            // 
            this.buttonPDF.Location = new System.Drawing.Point(452, 405);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(211, 33);
            this.buttonPDF.TabIndex = 2;
            this.buttonPDF.Text = "Wygeneruj PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(669, 405);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(178, 33);
            this.buttonZamknij.TabIndex = 3;
            this.buttonZamknij.Text = "Wyjdź";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // SkladnikiNaPotrawyOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.groupBoxSkladnikiNaPotrawy);
            this.Controls.Add(this.groupBoxListaPrzepisow);
            this.Name = "SkladnikiNaPotrawyOkno";
            this.Text = "SklanikiNaPotrawyOkno";
            this.Load += new System.EventHandler(this.SkladnikiNaPotrawyOkno_Load);
            this.groupBoxListaPrzepisow.ResumeLayout(false);
            this.groupBoxListaPrzepisow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPrzepisow)).EndInit();
            this.groupBoxSkladnikiNaPotrawy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSkladnikow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListaPrzepisow;
        private System.Windows.Forms.DataGridView dataGridViewListaPrzepisow;
        private System.Windows.Forms.TextBox textBoxSzukaj;
        private System.Windows.Forms.GroupBox groupBoxSkladnikiNaPotrawy;
        private System.Windows.Forms.DataGridView dataGridViewListaSkladnikow;
        private System.Windows.Forms.Button buttonZnajdzSkladniki;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.Button buttonZamknij;
    }
}