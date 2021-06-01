﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCookingRecipes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                dataGridViewListaPrzepisow.DataSource = context.Przepisy.ToList();
            }
        }

        private void dodajUsuńToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrzepisyOkno przepisyOkno = new PrzepisyOkno();
            przepisyOkno.Show();
        }

        private void dodajUsuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkladnikiOkno skladnikiOkno = new SkladnikiOkno();
            skladnikiOkno.Show();
        }
    }
}
