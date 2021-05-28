namespace MyCookingRecipes
{
    partial class Form1
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
            this.dataGridViewPrzepisy = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przepisyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przepisyZarzadzajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.składnikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skladnikiZarzadzajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSzczegolyPrzepisu = new System.Windows.Forms.GroupBox();
            this.labelCzasPrzygotowaniaTytul = new System.Windows.Forms.Label();
            this.labelNazwaPrzepisu = new System.Windows.Forms.Label();
            this.labelNazwaPrzepisuTytul = new System.Windows.Forms.Label();
            this.labelCzasPrzygotowania = new System.Windows.Forms.Label();
            this.labelIloscPorcjiTytul = new System.Windows.Forms.Label();
            this.labelIloscPorcji = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelListBoxTytul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrzepisy)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSzczegolyPrzepisu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrzepisy
            // 
            this.dataGridViewPrzepisy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrzepisy.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewPrzepisy.Name = "dataGridViewPrzepisy";
            this.dataGridViewPrzepisy.Size = new System.Drawing.Size(546, 417);
            this.dataGridViewPrzepisy.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacjaToolStripMenuItem,
            this.przepisyToolStripMenuItem,
            this.składnikiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikacjaToolStripMenuItem
            // 
            this.aplikacjaToolStripMenuItem.Name = "aplikacjaToolStripMenuItem";
            this.aplikacjaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aplikacjaToolStripMenuItem.Text = "Aplikacja";
            // 
            // przepisyToolStripMenuItem
            // 
            this.przepisyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przepisyZarzadzajToolStripMenuItem});
            this.przepisyToolStripMenuItem.Name = "przepisyToolStripMenuItem";
            this.przepisyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.przepisyToolStripMenuItem.Text = "Przepisy";
            // 
            // przepisyZarzadzajToolStripMenuItem
            // 
            this.przepisyZarzadzajToolStripMenuItem.Name = "przepisyZarzadzajToolStripMenuItem";
            this.przepisyZarzadzajToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.przepisyZarzadzajToolStripMenuItem.Text = "Zarządzaj..";
            this.przepisyZarzadzajToolStripMenuItem.Click += new System.EventHandler(this.dodajUsuńToolStripMenuItem1_Click);
            // 
            // składnikiToolStripMenuItem
            // 
            this.składnikiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skladnikiZarzadzajToolStripMenuItem});
            this.składnikiToolStripMenuItem.Name = "składnikiToolStripMenuItem";
            this.składnikiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.składnikiToolStripMenuItem.Text = "Składniki";
            // 
            // skladnikiZarzadzajToolStripMenuItem
            // 
            this.skladnikiZarzadzajToolStripMenuItem.Name = "skladnikiZarzadzajToolStripMenuItem";
            this.skladnikiZarzadzajToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.skladnikiZarzadzajToolStripMenuItem.Text = "Zarządzaj..";
            this.skladnikiZarzadzajToolStripMenuItem.Click += new System.EventHandler(this.dodajUsuńToolStripMenuItem_Click);
            // 
            // groupBoxSzczegolyPrzepisu
            // 
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelListBoxTytul);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.listBox1);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelIloscPorcji);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelIloscPorcjiTytul);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelCzasPrzygotowania);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelCzasPrzygotowaniaTytul);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelNazwaPrzepisu);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelNazwaPrzepisuTytul);
            this.groupBoxSzczegolyPrzepisu.Location = new System.Drawing.Point(565, 65);
            this.groupBoxSzczegolyPrzepisu.Name = "groupBoxSzczegolyPrzepisu";
            this.groupBoxSzczegolyPrzepisu.Size = new System.Drawing.Size(373, 323);
            this.groupBoxSzczegolyPrzepisu.TabIndex = 3;
            this.groupBoxSzczegolyPrzepisu.TabStop = false;
            this.groupBoxSzczegolyPrzepisu.Text = "Szczegóły Przepisu";
            // 
            // labelCzasPrzygotowaniaTytul
            // 
            this.labelCzasPrzygotowaniaTytul.AutoSize = true;
            this.labelCzasPrzygotowaniaTytul.Location = new System.Drawing.Point(112, 16);
            this.labelCzasPrzygotowaniaTytul.Name = "labelCzasPrzygotowaniaTytul";
            this.labelCzasPrzygotowaniaTytul.Size = new System.Drawing.Size(127, 13);
            this.labelCzasPrzygotowaniaTytul.TabIndex = 2;
            this.labelCzasPrzygotowaniaTytul.Text = "Czas Przygotowania [min]";
            // 
            // labelNazwaPrzepisu
            // 
            this.labelNazwaPrzepisu.AutoSize = true;
            this.labelNazwaPrzepisu.Location = new System.Drawing.Point(7, 33);
            this.labelNazwaPrzepisu.Name = "labelNazwaPrzepisu";
            this.labelNazwaPrzepisu.Size = new System.Drawing.Size(35, 13);
            this.labelNazwaPrzepisu.TabIndex = 1;
            this.labelNazwaPrzepisu.Text = "label1";
            // 
            // labelNazwaPrzepisuTytul
            // 
            this.labelNazwaPrzepisuTytul.AutoSize = true;
            this.labelNazwaPrzepisuTytul.Location = new System.Drawing.Point(6, 16);
            this.labelNazwaPrzepisuTytul.Name = "labelNazwaPrzepisuTytul";
            this.labelNazwaPrzepisuTytul.Size = new System.Drawing.Size(83, 13);
            this.labelNazwaPrzepisuTytul.TabIndex = 0;
            this.labelNazwaPrzepisuTytul.Text = "Nazwa Przepisu";
            // 
            // labelCzasPrzygotowania
            // 
            this.labelCzasPrzygotowania.AutoSize = true;
            this.labelCzasPrzygotowania.Location = new System.Drawing.Point(112, 33);
            this.labelCzasPrzygotowania.Name = "labelCzasPrzygotowania";
            this.labelCzasPrzygotowania.Size = new System.Drawing.Size(35, 13);
            this.labelCzasPrzygotowania.TabIndex = 3;
            this.labelCzasPrzygotowania.Text = "label1";
            // 
            // labelIloscPorcjiTytul
            // 
            this.labelIloscPorcjiTytul.AutoSize = true;
            this.labelIloscPorcjiTytul.Location = new System.Drawing.Point(266, 15);
            this.labelIloscPorcjiTytul.Name = "labelIloscPorcjiTytul";
            this.labelIloscPorcjiTytul.Size = new System.Drawing.Size(57, 13);
            this.labelIloscPorcjiTytul.TabIndex = 4;
            this.labelIloscPorcjiTytul.Text = "Ilość porcji";
            // 
            // labelIloscPorcji
            // 
            this.labelIloscPorcji.AutoSize = true;
            this.labelIloscPorcji.Location = new System.Drawing.Point(269, 33);
            this.labelIloscPorcji.Name = "labelIloscPorcji";
            this.labelIloscPorcji.Size = new System.Drawing.Size(35, 13);
            this.labelIloscPorcji.TabIndex = 5;
            this.labelIloscPorcji.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 225);
            this.listBox1.TabIndex = 6;
            // 
            // labelListBoxTytul
            // 
            this.labelListBoxTytul.AutoSize = true;
            this.labelListBoxTytul.Location = new System.Drawing.Point(10, 69);
            this.labelListBoxTytul.Name = "labelListBoxTytul";
            this.labelListBoxTytul.Size = new System.Drawing.Size(55, 13);
            this.labelListBoxTytul.TabIndex = 7;
            this.labelListBoxTytul.Text = "Składniki:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 494);
            this.Controls.Add(this.groupBoxSzczegolyPrzepisu);
            this.Controls.Add(this.dataGridViewPrzepisy);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrzepisy)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSzczegolyPrzepisu.ResumeLayout(false);
            this.groupBoxSzczegolyPrzepisu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrzepisy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przepisyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przepisyZarzadzajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem składnikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skladnikiZarzadzajToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxSzczegolyPrzepisu;
        private System.Windows.Forms.Label labelCzasPrzygotowaniaTytul;
        private System.Windows.Forms.Label labelNazwaPrzepisu;
        private System.Windows.Forms.Label labelNazwaPrzepisuTytul;
        private System.Windows.Forms.Label labelIloscPorcji;
        private System.Windows.Forms.Label labelIloscPorcjiTytul;
        private System.Windows.Forms.Label labelCzasPrzygotowania;
        private System.Windows.Forms.Label labelListBoxTytul;
        private System.Windows.Forms.ListBox listBox1;
    }
}

