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
            this.dataGridViewPrzepisyOknoLista = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBoxListaPrzepisow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrzepisyOknoLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListaPrzepisow
            // 
            this.groupBoxListaPrzepisow.Controls.Add(this.button1);
            this.groupBoxListaPrzepisow.Controls.Add(this.textBox1);
            this.groupBoxListaPrzepisow.Controls.Add(this.dataGridViewPrzepisyOknoLista);
            this.groupBoxListaPrzepisow.Location = new System.Drawing.Point(8, 38);
            this.groupBoxListaPrzepisow.Name = "groupBoxListaPrzepisow";
            this.groupBoxListaPrzepisow.Size = new System.Drawing.Size(586, 395);
            this.groupBoxListaPrzepisow.TabIndex = 0;
            this.groupBoxListaPrzepisow.TabStop = false;
            this.groupBoxListaPrzepisow.Text = "Lista przepisów";
            // 
            // dataGridViewPrzepisyOknoLista
            // 
            this.dataGridViewPrzepisyOknoLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrzepisyOknoLista.Location = new System.Drawing.Point(7, 48);
            this.dataGridViewPrzepisyOknoLista.Name = "dataGridViewPrzepisyOknoLista";
            this.dataGridViewPrzepisyOknoLista.Size = new System.Drawing.Size(573, 337);
            this.dataGridViewPrzepisyOknoLista.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj nowy przepis";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modyfikuj zaznaczony przepis";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Usuń zaznaczony przepis";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PrzepisyOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 445);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxListaPrzepisow);
            this.Name = "PrzepisyOkno";
            this.Text = "PrzepisyOkno";
            this.groupBoxListaPrzepisow.ResumeLayout(false);
            this.groupBoxListaPrzepisow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrzepisyOknoLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListaPrzepisow;
        private System.Windows.Forms.DataGridView dataGridViewPrzepisyOknoLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}