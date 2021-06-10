﻿using System;

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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewListaPrzepisow = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przepisyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przepisyZarzadzajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.składnikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skladnikiZarzadzajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulubioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarzadzajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSzczegolyPrzepisu = new System.Windows.Forms.GroupBox();
            this.labelListBoxTytul = new System.Windows.Forms.Label();
            this.listBoxSkladnikiWPrzepisie = new System.Windows.Forms.ListBox();
            this.labelIloscPorcji = new System.Windows.Forms.Label();
            this.labelIloscPorcjiTytul = new System.Windows.Forms.Label();
            this.labelCzasPrzygotowania = new System.Windows.Forms.Label();
            this.labelCzasPrzygotowaniaTytul = new System.Windows.Forms.Label();
            this.labelNazwaPrzepisu = new System.Windows.Forms.Label();
            this.labelNazwaPrzepisuTytul = new System.Windows.Forms.Label();
            this.buttonListaSkladnikow = new System.Windows.Forms.Button();
            this.textBoxSzukaj = new System.Windows.Forms.TextBox();
            this.checkBoxUlubione = new System.Windows.Forms.CheckBox();
            this.contextMenuStripPrzepisy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modyfikujPrzepisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunPrzepisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUsunDoUlubionychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPrzepisow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSzczegolyPrzepisu.SuspendLayout();
            this.contextMenuStripPrzepisy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListaPrzepisow
            // 
            this.dataGridViewListaPrzepisow.AllowUserToAddRows = false;
            this.dataGridViewListaPrzepisow.AllowUserToDeleteRows = false;
            this.dataGridViewListaPrzepisow.AllowUserToResizeColumns = false;
            this.dataGridViewListaPrzepisow.AllowUserToResizeRows = false;
            this.dataGridViewListaPrzepisow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaPrzepisow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPrzepisow.ContextMenuStrip = this.contextMenuStripPrzepisy;
            this.dataGridViewListaPrzepisow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewListaPrzepisow.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewListaPrzepisow.MultiSelect = false;
            this.dataGridViewListaPrzepisow.Name = "dataGridViewListaPrzepisow";
            this.dataGridViewListaPrzepisow.ReadOnly = true;
            this.dataGridViewListaPrzepisow.RowHeadersVisible = false;
            this.dataGridViewListaPrzepisow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaPrzepisow.Size = new System.Drawing.Size(546, 384);
            this.dataGridViewListaPrzepisow.TabIndex = 0;
            this.dataGridViewListaPrzepisow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaPrzepisow_CellClick);
            this.dataGridViewListaPrzepisow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaPrzepisow_CellDoubleClick);            this.dataGridViewListaPrzepisow.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dataGridViewListaPrzepisow_RowContextMenuStripNeeded);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacjaToolStripMenuItem,
            this.przepisyToolStripMenuItem,
            this.składnikiToolStripMenuItem,
            this.ulubioneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikacjaToolStripMenuItem
            // 
            this.aplikacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyjdźToolStripMenuItem});
            this.aplikacjaToolStripMenuItem.Name = "aplikacjaToolStripMenuItem";
            this.aplikacjaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aplikacjaToolStripMenuItem.Text = "Aplikacja";
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
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
            // ulubioneToolStripMenuItem
            // 
            this.ulubioneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zarzadzajToolStripMenuItem});
            this.ulubioneToolStripMenuItem.Name = "ulubioneToolStripMenuItem";
            this.ulubioneToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ulubioneToolStripMenuItem.Text = "Ulubione";
            // 
            // zarzadzajToolStripMenuItem
            // 
            this.zarzadzajToolStripMenuItem.Name = "zarzadzajToolStripMenuItem";
            this.zarzadzajToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zarzadzajToolStripMenuItem.Text = "Zarzadzaj..";
            this.zarzadzajToolStripMenuItem.Click += new System.EventHandler(this.zarzadzajToolStripMenuItem_Click);
            // 
            // groupBoxSzczegolyPrzepisu
            // 
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelListBoxTytul);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.listBoxSkladnikiWPrzepisie);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelIloscPorcji);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelIloscPorcjiTytul);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelCzasPrzygotowania);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelCzasPrzygotowaniaTytul);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelNazwaPrzepisu);
            this.groupBoxSzczegolyPrzepisu.Controls.Add(this.labelNazwaPrzepisuTytul);
            this.groupBoxSzczegolyPrzepisu.Location = new System.Drawing.Point(565, 27);
            this.groupBoxSzczegolyPrzepisu.Name = "groupBoxSzczegolyPrzepisu";
            this.groupBoxSzczegolyPrzepisu.Size = new System.Drawing.Size(373, 347);
            this.groupBoxSzczegolyPrzepisu.TabIndex = 3;
            this.groupBoxSzczegolyPrzepisu.TabStop = false;
            this.groupBoxSzczegolyPrzepisu.Text = "Szczegóły przepisu";
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
            // listBoxSkladnikiWPrzepisie
            // 
            this.listBoxSkladnikiWPrzepisie.FormattingEnabled = true;
            this.listBoxSkladnikiWPrzepisie.Location = new System.Drawing.Point(10, 88);
            this.listBoxSkladnikiWPrzepisie.Name = "listBoxSkladnikiWPrzepisie";
            this.listBoxSkladnikiWPrzepisie.Size = new System.Drawing.Size(357, 251);
            this.listBoxSkladnikiWPrzepisie.TabIndex = 6;
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
            // labelIloscPorcjiTytul
            // 
            this.labelIloscPorcjiTytul.AutoSize = true;
            this.labelIloscPorcjiTytul.Location = new System.Drawing.Point(266, 15);
            this.labelIloscPorcjiTytul.Name = "labelIloscPorcjiTytul";
            this.labelIloscPorcjiTytul.Size = new System.Drawing.Size(57, 13);
            this.labelIloscPorcjiTytul.TabIndex = 4;
            this.labelIloscPorcjiTytul.Text = "Ilość porcji";
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
            // buttonListaSkladnikow
            // 
            this.buttonListaSkladnikow.Location = new System.Drawing.Point(565, 380);
            this.buttonListaSkladnikow.Name = "buttonListaSkladnikow";
            this.buttonListaSkladnikow.Size = new System.Drawing.Size(373, 64);
            this.buttonListaSkladnikow.TabIndex = 5;
            this.buttonListaSkladnikow.Text = "Przygotuj listę składników na potrawy";
            this.buttonListaSkladnikow.UseVisualStyleBackColor = true;
            this.buttonListaSkladnikow.Click += new System.EventHandler(this.buttonListaSkladnikow_Click);
            // 
            // textBoxSzukaj
            // 
            this.textBoxSzukaj.Location = new System.Drawing.Point(13, 34);
            this.textBoxSzukaj.Name = "textBoxSzukaj";
            this.textBoxSzukaj.Size = new System.Drawing.Size(471, 20);
            this.textBoxSzukaj.TabIndex = 6;
            this.textBoxSzukaj.TextChanged += new System.EventHandler(this.textBoxSzukaj_TextChanged);
            // 
            // checkBoxUlubione
            // 
            this.checkBoxUlubione.AutoSize = true;
            this.checkBoxUlubione.Location = new System.Drawing.Point(490, 36);
            this.checkBoxUlubione.Name = "checkBoxUlubione";
            this.checkBoxUlubione.Size = new System.Drawing.Size(68, 17);
            this.checkBoxUlubione.TabIndex = 8;
            this.checkBoxUlubione.Text = "Ulubione";
            this.checkBoxUlubione.UseVisualStyleBackColor = true;
            this.checkBoxUlubione.CheckedChanged += new System.EventHandler(this.checkBoxUlubione_CheckedChanged);
            // 
            // contextMenuStripPrzepisy
            // 
            this.contextMenuStripPrzepisy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modyfikujPrzepisToolStripMenuItem,
            this.usunPrzepisToolStripMenuItem,
            this.dodajUsunDoUlubionychToolStripMenuItem});
            this.contextMenuStripPrzepisy.Name = "contextMenuStripPrzepisy";
            this.contextMenuStripPrzepisy.Size = new System.Drawing.Size(186, 92);
            // 
            // modyfikujPrzepisToolStripMenuItem
            // 
            this.modyfikujPrzepisToolStripMenuItem.Name = "modyfikujPrzepisToolStripMenuItem";
            this.modyfikujPrzepisToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.modyfikujPrzepisToolStripMenuItem.Text = "Modyfikuj przepis";
            this.modyfikujPrzepisToolStripMenuItem.Click += new System.EventHandler(this.modyfikujPrzepisToolStripMenuItem_Click);
            // 
            // usunPrzepisToolStripMenuItem
            // 
            this.usunPrzepisToolStripMenuItem.Name = "usunPrzepisToolStripMenuItem";
            this.usunPrzepisToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.usunPrzepisToolStripMenuItem.Text = "Usun przepis";
            this.usunPrzepisToolStripMenuItem.Click += new System.EventHandler(this.usunPrzepisToolStripMenuItem_Click);
            // 
            // dodajUsunDoUlubionychToolStripMenuItem
            // 
            this.dodajUsunDoUlubionychToolStripMenuItem.Name = "dodajUsunDoUlubionychToolStripMenuItem";
            this.dodajUsunDoUlubionychToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dodajUsunDoUlubionychToolStripMenuItem.Text = "Dodaj do ulubionych";
            this.dodajUsunDoUlubionychToolStripMenuItem.Click += new System.EventHandler(this.dodajUsunDoUlubionychToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 456);
            this.Controls.Add(this.checkBoxUlubione);
            this.Controls.Add(this.textBoxSzukaj);
            this.Controls.Add(this.buttonListaSkladnikow);
            this.Controls.Add(this.dataGridViewListaPrzepisow);
            this.Controls.Add(this.groupBoxSzczegolyPrzepisu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPrzepisow)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSzczegolyPrzepisu.ResumeLayout(false);
            this.groupBoxSzczegolyPrzepisu.PerformLayout();
            this.contextMenuStripPrzepisy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaPrzepisow;
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
        private System.Windows.Forms.ListBox listBoxSkladnikiWPrzepisie;
        private System.Windows.Forms.ToolStripMenuItem ulubioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarzadzajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.Button buttonListaSkladnikow;
        private System.Windows.Forms.TextBox textBoxSzukaj;
        private System.Windows.Forms.CheckBox checkBoxUlubione;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPrzepisy;
        private System.Windows.Forms.ToolStripMenuItem modyfikujPrzepisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunPrzepisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUsunDoUlubionychToolStripMenuItem;
    }
}

