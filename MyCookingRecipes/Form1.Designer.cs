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
            this.dataGridViewListaPrzepisow = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przepisyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUsuńToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.składnikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUsuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPrzepisow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListaPrzepisow
            // 
            this.dataGridViewListaPrzepisow.AllowUserToAddRows = false;
            this.dataGridViewListaPrzepisow.AllowUserToDeleteRows = false;
            this.dataGridViewListaPrzepisow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPrzepisow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewListaPrzepisow.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewListaPrzepisow.MultiSelect = false;
            this.dataGridViewListaPrzepisow.Name = "dataGridViewListaPrzepisow";
            this.dataGridViewListaPrzepisow.ReadOnly = true;
            this.dataGridViewListaPrzepisow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaPrzepisow.Size = new System.Drawing.Size(546, 417);
            this.dataGridViewListaPrzepisow.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(564, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(373, 278);
            this.dataGridView2.TabIndex = 1;
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
            this.dodajUsuńToolStripMenuItem1,
            this.usuńToolStripMenuItem});
            this.przepisyToolStripMenuItem.Name = "przepisyToolStripMenuItem";
            this.przepisyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.przepisyToolStripMenuItem.Text = "Przepisy";
            // 
            // dodajUsuńToolStripMenuItem1
            // 
            this.dodajUsuńToolStripMenuItem1.Name = "dodajUsuńToolStripMenuItem1";
            this.dodajUsuńToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.dodajUsuńToolStripMenuItem1.Text = "Dodaj..";
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.usuńToolStripMenuItem.Text = "Usuń..";
            // 
            // składnikiToolStripMenuItem
            // 
            this.składnikiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUsuńToolStripMenuItem});
            this.składnikiToolStripMenuItem.Name = "składnikiToolStripMenuItem";
            this.składnikiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.składnikiToolStripMenuItem.Text = "Składniki";
            // 
            // dodajUsuńToolStripMenuItem
            // 
            this.dodajUsuńToolStripMenuItem.Name = "dodajUsuńToolStripMenuItem";
            this.dodajUsuńToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajUsuńToolStripMenuItem.Text = "Przegaladaj..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 494);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridViewListaPrzepisow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPrzepisow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaPrzepisow;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przepisyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUsuńToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem składnikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUsuńToolStripMenuItem;
    }
}

