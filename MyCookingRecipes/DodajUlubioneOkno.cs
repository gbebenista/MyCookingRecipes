﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyCookingRecipes
{
    public partial class DodajUlubioneOkno : Form
    {
        public DodajUlubioneOkno()
        {
            InitializeComponent();
        }

        public void LoadToDataGridView()
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewListaPrzepisow.DataSource = db.Przepisy.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas ładowania listy przepisów.");
            }
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewListaPrzepisow.DataSource = db.Przepisy.Where(p => p.NazwaPotrawy.Contains(textBoxSzukaj.Text)).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas ładowania listy przepisów z zakresu wyszukiwania.");
            }
        }

        private void DodajUlubioneOkno_Load(object sender, EventArgs e)
        {
            LoadToDataGridView();
        }

        private void buttonPrzepisy_Click(object sender, EventArgs e)
        {
            PrzepisyOkno przepisyOkno = new PrzepisyOkno();
            przepisyOkno.ShowDialog();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    Ulubione przepisdoulubionych = new Ulubione
                    {
                        CzySystemDodal = false,
                        Przepis = db.Przepisy.Find(dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value)
                    };
                    db.Add(przepisdoulubionych);
                    db.SaveChanges();

                    UlubioneOkno ulubioneokno = (UlubioneOkno)Application.OpenForms["UlubioneOkno"];

                    ulubioneokno.LoadDefaultDataGridView();

                    MessageBox.Show(String.Format("Dodano do ulubionych przepis {0}", przepisdoulubionych.Przepis.NazwaPotrawy));
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem z dodaniem przepisu do ulubionych. Proszę spróbować ponownie");
            }
        }

        private void dataGridViewListaPrzepisow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }
    }
}
