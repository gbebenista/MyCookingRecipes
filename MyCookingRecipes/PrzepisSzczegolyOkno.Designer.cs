namespace MyCookingRecipes
{
    partial class PrzepisSzczegolyOkno
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
            this.groupBoxSzegolyPrzepisu = new System.Windows.Forms.GroupBox();
            this.buttonZamknijOkno = new System.Windows.Forms.Button();
            this.buttonUsunPrzepis = new System.Windows.Forms.Button();
            this.buttonModyfikujPrzepis = new System.Windows.Forms.Button();
            this.groupBoxKrokiPrzepisu = new System.Windows.Forms.GroupBox();
            this.groupBoxListaSkladnikow = new System.Windows.Forms.GroupBox();
            this.labelUlubioneTytul = new System.Windows.Forms.Label();
            this.labelIloscPorcjiTytul = new System.Windows.Forms.Label();
            this.labelCzyUlubione = new System.Windows.Forms.Label();
            this.labelCzasPrzygotowaniaTytul = new System.Windows.Forms.Label();
            this.labelIloscPorcji = new System.Windows.Forms.Label();
            this.labelCzasPrzygotowania = new System.Windows.Forms.Label();
            this.labelNazwaPrzepisu = new System.Windows.Forms.Label();
            this.listViewListaSkladnikow = new System.Windows.Forms.ListView();
            this.listViewKrokiPrzepisu = new System.Windows.Forms.ListView();
            this.groupBoxSzegolyPrzepisu.SuspendLayout();
            this.groupBoxKrokiPrzepisu.SuspendLayout();
            this.groupBoxListaSkladnikow.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSzegolyPrzepisu
            // 
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.buttonZamknijOkno);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.buttonUsunPrzepis);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.buttonModyfikujPrzepis);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.groupBoxKrokiPrzepisu);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.groupBoxListaSkladnikow);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.labelUlubioneTytul);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.labelIloscPorcjiTytul);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.labelCzyUlubione);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.labelCzasPrzygotowaniaTytul);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.labelIloscPorcji);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.labelCzasPrzygotowania);
            this.groupBoxSzegolyPrzepisu.Controls.Add(this.labelNazwaPrzepisu);
            this.groupBoxSzegolyPrzepisu.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSzegolyPrzepisu.Name = "groupBoxSzegolyPrzepisu";
            this.groupBoxSzegolyPrzepisu.Size = new System.Drawing.Size(550, 576);
            this.groupBoxSzegolyPrzepisu.TabIndex = 1;
            this.groupBoxSzegolyPrzepisu.TabStop = false;
            this.groupBoxSzegolyPrzepisu.Text = "Szczegóły przepisu";
            // 
            // buttonZamknijOkno
            // 
            this.buttonZamknijOkno.Location = new System.Drawing.Point(337, 77);
            this.buttonZamknijOkno.Name = "buttonZamknijOkno";
            this.buttonZamknijOkno.Size = new System.Drawing.Size(201, 23);
            this.buttonZamknijOkno.TabIndex = 6;
            this.buttonZamknijOkno.Text = "Wyjdź";
            this.buttonZamknijOkno.UseVisualStyleBackColor = true;
            this.buttonZamknijOkno.Click += new System.EventHandler(this.buttonZamknijOkno_Click);
            // 
            // buttonUsunPrzepis
            // 
            this.buttonUsunPrzepis.Location = new System.Drawing.Point(337, 48);
            this.buttonUsunPrzepis.Name = "buttonUsunPrzepis";
            this.buttonUsunPrzepis.Size = new System.Drawing.Size(201, 23);
            this.buttonUsunPrzepis.TabIndex = 6;
            this.buttonUsunPrzepis.Text = "Usuń przepis";
            this.buttonUsunPrzepis.UseVisualStyleBackColor = true;
            this.buttonUsunPrzepis.Click += new System.EventHandler(this.buttonUsunPrzepis_Click);
            // 
            // buttonModyfikujPrzepis
            // 
            this.buttonModyfikujPrzepis.Location = new System.Drawing.Point(337, 19);
            this.buttonModyfikujPrzepis.Name = "buttonModyfikujPrzepis";
            this.buttonModyfikujPrzepis.Size = new System.Drawing.Size(201, 23);
            this.buttonModyfikujPrzepis.TabIndex = 6;
            this.buttonModyfikujPrzepis.Text = "Modyfikuj przepis";
            this.buttonModyfikujPrzepis.UseVisualStyleBackColor = true;
            this.buttonModyfikujPrzepis.Click += new System.EventHandler(this.buttonModyfikujPrzepis_Click);
            // 
            // groupBoxKrokiPrzepisu
            // 
            this.groupBoxKrokiPrzepisu.Controls.Add(this.listViewKrokiPrzepisu);
            this.groupBoxKrokiPrzepisu.Location = new System.Drawing.Point(6, 343);
            this.groupBoxKrokiPrzepisu.Name = "groupBoxKrokiPrzepisu";
            this.groupBoxKrokiPrzepisu.Size = new System.Drawing.Size(538, 227);
            this.groupBoxKrokiPrzepisu.TabIndex = 5;
            this.groupBoxKrokiPrzepisu.TabStop = false;
            this.groupBoxKrokiPrzepisu.Text = "Kroki przygotowania przepisu";
            // 
            // groupBoxListaSkladnikow
            // 
            this.groupBoxListaSkladnikow.Controls.Add(this.listViewListaSkladnikow);
            this.groupBoxListaSkladnikow.Location = new System.Drawing.Point(6, 135);
            this.groupBoxListaSkladnikow.Name = "groupBoxListaSkladnikow";
            this.groupBoxListaSkladnikow.Size = new System.Drawing.Size(538, 202);
            this.groupBoxListaSkladnikow.TabIndex = 4;
            this.groupBoxListaSkladnikow.TabStop = false;
            this.groupBoxListaSkladnikow.Text = "Lista składników";
            // 
            // labelUlubioneTytul
            // 
            this.labelUlubioneTytul.AutoSize = true;
            this.labelUlubioneTytul.Location = new System.Drawing.Point(220, 62);
            this.labelUlubioneTytul.Name = "labelUlubioneTytul";
            this.labelUlubioneTytul.Size = new System.Drawing.Size(49, 13);
            this.labelUlubioneTytul.TabIndex = 2;
            this.labelUlubioneTytul.Text = "Ulubione";
            // 
            // labelIloscPorcjiTytul
            // 
            this.labelIloscPorcjiTytul.AutoSize = true;
            this.labelIloscPorcjiTytul.Location = new System.Drawing.Point(140, 62);
            this.labelIloscPorcjiTytul.Name = "labelIloscPorcjiTytul";
            this.labelIloscPorcjiTytul.Size = new System.Drawing.Size(79, 13);
            this.labelIloscPorcjiTytul.TabIndex = 2;
            this.labelIloscPorcjiTytul.Text = "Ilość porcji [szt]";
            // 
            // labelCzyUlubione
            // 
            this.labelCzyUlubione.AutoSize = true;
            this.labelCzyUlubione.Location = new System.Drawing.Point(220, 84);
            this.labelCzyUlubione.Name = "labelCzyUlubione";
            this.labelCzyUlubione.Size = new System.Drawing.Size(35, 13);
            this.labelCzyUlubione.TabIndex = 1;
            this.labelCzyUlubione.Text = "label1";
            // 
            // labelCzasPrzygotowaniaTytul
            // 
            this.labelCzasPrzygotowaniaTytul.AutoSize = true;
            this.labelCzasPrzygotowaniaTytul.Location = new System.Drawing.Point(16, 62);
            this.labelCzasPrzygotowaniaTytul.Name = "labelCzasPrzygotowaniaTytul";
            this.labelCzasPrzygotowaniaTytul.Size = new System.Drawing.Size(126, 13);
            this.labelCzasPrzygotowaniaTytul.TabIndex = 2;
            this.labelCzasPrzygotowaniaTytul.Text = "Czas przygotowania [min]";
            // 
            // labelIloscPorcji
            // 
            this.labelIloscPorcji.AutoSize = true;
            this.labelIloscPorcji.Location = new System.Drawing.Point(140, 84);
            this.labelIloscPorcji.Name = "labelIloscPorcji";
            this.labelIloscPorcji.Size = new System.Drawing.Size(35, 13);
            this.labelIloscPorcji.TabIndex = 1;
            this.labelIloscPorcji.Text = "label1";
            // 
            // labelCzasPrzygotowania
            // 
            this.labelCzasPrzygotowania.AutoSize = true;
            this.labelCzasPrzygotowania.Location = new System.Drawing.Point(16, 84);
            this.labelCzasPrzygotowania.Name = "labelCzasPrzygotowania";
            this.labelCzasPrzygotowania.Size = new System.Drawing.Size(35, 13);
            this.labelCzasPrzygotowania.TabIndex = 1;
            this.labelCzasPrzygotowania.Text = "label1";
            // 
            // labelNazwaPrzepisu
            // 
            this.labelNazwaPrzepisu.AutoSize = true;
            this.labelNazwaPrzepisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwaPrzepisu.Location = new System.Drawing.Point(14, 27);
            this.labelNazwaPrzepisu.Name = "labelNazwaPrzepisu";
            this.labelNazwaPrzepisu.Size = new System.Drawing.Size(70, 25);
            this.labelNazwaPrzepisu.TabIndex = 1;
            this.labelNazwaPrzepisu.Text = "label1";
            // 
            // listViewListaSkladnikow
            // 
            this.listViewListaSkladnikow.Location = new System.Drawing.Point(6, 20);
            this.listViewListaSkladnikow.Name = "listViewListaSkladnikow";
            this.listViewListaSkladnikow.Size = new System.Drawing.Size(526, 176);
            this.listViewListaSkladnikow.TabIndex = 0;
            this.listViewListaSkladnikow.UseCompatibleStateImageBehavior = false;
            // 
            // listViewKrokiPrzepisu
            // 
            this.listViewKrokiPrzepisu.Location = new System.Drawing.Point(6, 19);
            this.listViewKrokiPrzepisu.Name = "listViewKrokiPrzepisu";
            this.listViewKrokiPrzepisu.Size = new System.Drawing.Size(526, 202);
            this.listViewKrokiPrzepisu.TabIndex = 0;
            this.listViewKrokiPrzepisu.UseCompatibleStateImageBehavior = false;
            // 
            // PrzepisSzczegolyOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 601);
            this.Controls.Add(this.groupBoxSzegolyPrzepisu);
            this.Name = "PrzepisSzczegolyOkno";
            this.Text = "PrzepisSzczegolyOkno";
            this.Load += new System.EventHandler(this.PrzepisSzczegolyOkno_Load);
            this.groupBoxSzegolyPrzepisu.ResumeLayout(false);
            this.groupBoxSzegolyPrzepisu.PerformLayout();
            this.groupBoxKrokiPrzepisu.ResumeLayout(false);
            this.groupBoxListaSkladnikow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSzegolyPrzepisu;
        private System.Windows.Forms.Label labelIloscPorcjiTytul;
        private System.Windows.Forms.Label labelCzasPrzygotowaniaTytul;
        private System.Windows.Forms.Label labelNazwaPrzepisu;
        private System.Windows.Forms.Label labelIloscPorcji;
        private System.Windows.Forms.Label labelCzasPrzygotowania;
        private System.Windows.Forms.Label labelUlubioneTytul;
        private System.Windows.Forms.Label labelCzyUlubione;
        private System.Windows.Forms.GroupBox groupBoxKrokiPrzepisu;
        private System.Windows.Forms.GroupBox groupBoxListaSkladnikow;
        private System.Windows.Forms.Button buttonZamknijOkno;
        private System.Windows.Forms.Button buttonUsunPrzepis;
        private System.Windows.Forms.Button buttonModyfikujPrzepis;
        private System.Windows.Forms.ListView listViewKrokiPrzepisu;
        private System.Windows.Forms.ListView listViewListaSkladnikow;
    }
}