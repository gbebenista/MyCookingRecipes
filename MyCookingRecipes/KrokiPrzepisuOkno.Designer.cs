namespace MyCookingRecipes
{
    partial class KrokiPrzepisuOkno
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
            this.dataGridViewListaKrokowPrzepisu = new System.Windows.Forms.DataGridView();
            this.groupBoxListaKrokowPrzepisu = new System.Windows.Forms.GroupBox();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.buttonUsunKrokiPrzepisu = new System.Windows.Forms.Button();
            this.groupBoxDodajKrokPrzepisu = new System.Windows.Forms.GroupBox();
            this.buttonDodajKrokPrzepisu = new System.Windows.Forms.Button();
            this.numericUpDownKolejnoscWPrzepisie = new System.Windows.Forms.NumericUpDown();
            this.labelKolejnoscWPrzepisie = new System.Windows.Forms.Label();
            this.labelOpisKrokuPrzepisu = new System.Windows.Forms.Label();
            this.textBoxOpisKrokuPrzepisu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaKrokowPrzepisu)).BeginInit();
            this.groupBoxListaKrokowPrzepisu.SuspendLayout();
            this.groupBoxDodajKrokPrzepisu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolejnoscWPrzepisie)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaKrokowPrzepisu
            // 
            this.dataGridViewListaKrokowPrzepisu.AllowUserToAddRows = false;
            this.dataGridViewListaKrokowPrzepisu.AllowUserToDeleteRows = false;
            this.dataGridViewListaKrokowPrzepisu.AllowUserToResizeColumns = false;
            this.dataGridViewListaKrokowPrzepisu.AllowUserToResizeRows = false;
            this.dataGridViewListaKrokowPrzepisu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaKrokowPrzepisu.Location = new System.Drawing.Point(7, 46);
            this.dataGridViewListaKrokowPrzepisu.Name = "dataGridViewListaKrokowPrzepisu";
            this.dataGridViewListaKrokowPrzepisu.ReadOnly = true;
            this.dataGridViewListaKrokowPrzepisu.RowHeadersVisible = false;
            this.dataGridViewListaKrokowPrzepisu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaKrokowPrzepisu.Size = new System.Drawing.Size(683, 234);
            this.dataGridViewListaKrokowPrzepisu.TabIndex = 0;
            // 
            // groupBoxListaKrokowPrzepisu
            // 
            this.groupBoxListaKrokowPrzepisu.Controls.Add(this.buttonZamknij);
            this.groupBoxListaKrokowPrzepisu.Controls.Add(this.buttonUsunKrokiPrzepisu);
            this.groupBoxListaKrokowPrzepisu.Controls.Add(this.dataGridViewListaKrokowPrzepisu);
            this.groupBoxListaKrokowPrzepisu.Location = new System.Drawing.Point(13, 13);
            this.groupBoxListaKrokowPrzepisu.Name = "groupBoxListaKrokowPrzepisu";
            this.groupBoxListaKrokowPrzepisu.Size = new System.Drawing.Size(695, 286);
            this.groupBoxListaKrokowPrzepisu.TabIndex = 1;
            this.groupBoxListaKrokowPrzepisu.TabStop = false;
            this.groupBoxListaKrokowPrzepisu.Text = "Lista kroków przepisu";
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(452, 17);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(237, 23);
            this.buttonZamknij.TabIndex = 2;
            this.buttonZamknij.Text = "Wyjdź";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            // 
            // buttonUsunKrokiPrzepisu
            // 
            this.buttonUsunKrokiPrzepisu.Location = new System.Drawing.Point(6, 17);
            this.buttonUsunKrokiPrzepisu.Name = "buttonUsunKrokiPrzepisu";
            this.buttonUsunKrokiPrzepisu.Size = new System.Drawing.Size(250, 23);
            this.buttonUsunKrokiPrzepisu.TabIndex = 1;
            this.buttonUsunKrokiPrzepisu.Text = "Usuń zaznaczone kroki przepisu..";
            this.buttonUsunKrokiPrzepisu.UseVisualStyleBackColor = true;
            // 
            // groupBoxDodajKrokPrzepisu
            // 
            this.groupBoxDodajKrokPrzepisu.Controls.Add(this.buttonDodajKrokPrzepisu);
            this.groupBoxDodajKrokPrzepisu.Controls.Add(this.numericUpDownKolejnoscWPrzepisie);
            this.groupBoxDodajKrokPrzepisu.Controls.Add(this.labelKolejnoscWPrzepisie);
            this.groupBoxDodajKrokPrzepisu.Controls.Add(this.labelOpisKrokuPrzepisu);
            this.groupBoxDodajKrokPrzepisu.Controls.Add(this.textBoxOpisKrokuPrzepisu);
            this.groupBoxDodajKrokPrzepisu.Location = new System.Drawing.Point(13, 306);
            this.groupBoxDodajKrokPrzepisu.Name = "groupBoxDodajKrokPrzepisu";
            this.groupBoxDodajKrokPrzepisu.Size = new System.Drawing.Size(695, 132);
            this.groupBoxDodajKrokPrzepisu.TabIndex = 2;
            this.groupBoxDodajKrokPrzepisu.TabStop = false;
            this.groupBoxDodajKrokPrzepisu.Text = "Dodaj kolejny krok przepisu";
            // 
            // buttonDodajKrokPrzepisu
            // 
            this.buttonDodajKrokPrzepisu.Location = new System.Drawing.Point(519, 65);
            this.buttonDodajKrokPrzepisu.Name = "buttonDodajKrokPrzepisu";
            this.buttonDodajKrokPrzepisu.Size = new System.Drawing.Size(170, 61);
            this.buttonDodajKrokPrzepisu.TabIndex = 4;
            this.buttonDodajKrokPrzepisu.Text = "Dodaj krok przepisu";
            this.buttonDodajKrokPrzepisu.UseVisualStyleBackColor = true;
            // 
            // numericUpDownKolejnoscWPrzepisie
            // 
            this.numericUpDownKolejnoscWPrzepisie.Location = new System.Drawing.Point(519, 39);
            this.numericUpDownKolejnoscWPrzepisie.Name = "numericUpDownKolejnoscWPrzepisie";
            this.numericUpDownKolejnoscWPrzepisie.Size = new System.Drawing.Size(170, 20);
            this.numericUpDownKolejnoscWPrzepisie.TabIndex = 3;
            // 
            // labelKolejnoscWPrzepisie
            // 
            this.labelKolejnoscWPrzepisie.AutoSize = true;
            this.labelKolejnoscWPrzepisie.Location = new System.Drawing.Point(516, 23);
            this.labelKolejnoscWPrzepisie.Name = "labelKolejnoscWPrzepisie";
            this.labelKolejnoscWPrzepisie.Size = new System.Drawing.Size(108, 13);
            this.labelKolejnoscWPrzepisie.TabIndex = 2;
            this.labelKolejnoscWPrzepisie.Text = "Kolejność w przepisie";
            // 
            // labelOpisKrokuPrzepisu
            // 
            this.labelOpisKrokuPrzepisu.AutoSize = true;
            this.labelOpisKrokuPrzepisu.Location = new System.Drawing.Point(6, 23);
            this.labelOpisKrokuPrzepisu.Name = "labelOpisKrokuPrzepisu";
            this.labelOpisKrokuPrzepisu.Size = new System.Drawing.Size(100, 13);
            this.labelOpisKrokuPrzepisu.TabIndex = 1;
            this.labelOpisKrokuPrzepisu.Text = "Opis kroku przepisu";
            // 
            // textBoxOpisKrokuPrzepisu
            // 
            this.textBoxOpisKrokuPrzepisu.Location = new System.Drawing.Point(7, 39);
            this.textBoxOpisKrokuPrzepisu.Multiline = true;
            this.textBoxOpisKrokuPrzepisu.Name = "textBoxOpisKrokuPrzepisu";
            this.textBoxOpisKrokuPrzepisu.Size = new System.Drawing.Size(506, 87);
            this.textBoxOpisKrokuPrzepisu.TabIndex = 0;
            // 
            // KrokiPrzepisuOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.groupBoxDodajKrokPrzepisu);
            this.Controls.Add(this.groupBoxListaKrokowPrzepisu);
            this.Name = "KrokiPrzepisuOkno";
            this.Text = "KrokiPrzepisuOkno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaKrokowPrzepisu)).EndInit();
            this.groupBoxListaKrokowPrzepisu.ResumeLayout(false);
            this.groupBoxDodajKrokPrzepisu.ResumeLayout(false);
            this.groupBoxDodajKrokPrzepisu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolejnoscWPrzepisie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaKrokowPrzepisu;
        private System.Windows.Forms.GroupBox groupBoxListaKrokowPrzepisu;
        private System.Windows.Forms.GroupBox groupBoxDodajKrokPrzepisu;
        private System.Windows.Forms.TextBox textBoxOpisKrokuPrzepisu;
        private System.Windows.Forms.Button buttonUsunKrokiPrzepisu;
        private System.Windows.Forms.Button buttonDodajKrokPrzepisu;
        private System.Windows.Forms.NumericUpDown numericUpDownKolejnoscWPrzepisie;
        private System.Windows.Forms.Label labelKolejnoscWPrzepisie;
        private System.Windows.Forms.Label labelOpisKrokuPrzepisu;
        private System.Windows.Forms.Button buttonZamknij;
    }
}