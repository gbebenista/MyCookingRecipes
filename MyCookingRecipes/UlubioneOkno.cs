using Microsoft.EntityFrameworkCore;
using System;
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
    public partial class UlubioneOkno : Form
    {
        public UlubioneOkno()
        {
            InitializeComponent();
        }

        public void LoadDefaultDataGridView()
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewListaUlubione.DataSource = db.Ulubione.Include(p => p.Przepis).Select(p => new { p.UlubioneId, p.Przepis.NazwaPotrawy }).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas ładowania listy ulubionych przepisów.");
            }
        }

        private void UlubioneOkno_Load(object sender, EventArgs e)
        {
            LoadDefaultDataGridView();
        }

        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewListaUlubione.DataSource = db.Ulubione.Include(p => p.Przepis).Select(p => new { p.UlubioneId, p.Przepis.NazwaPotrawy }).Where(p => p.NazwaPotrawy.Contains(textBoxSzukaj.Text)).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas ładowania listy ulubionych przepisów z zakresu wyszukiwania.");
            }
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUsunUlubiony_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    if (dataGridViewListaUlubione.SelectedRows.Count == 0) return;
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone przepisy z ulubionych?", "Usuwanie przepisów z ulubionych", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {


                            List<string> nazwyusunietychulubionych = new List<string>();

                            foreach (DataGridViewRow row in dataGridViewListaUlubione.SelectedRows)
                            {
                                    nazwyusunietychulubionych.Add(row.Cells[1].Value.ToString());
                                    db.Remove(db.Ulubione.Where(u => u.UlubioneId == (int)row.Cells[0].Value).First());
                            }
                            db.SaveChanges();
                            LoadDefaultDataGridView();
                            MessageBox.Show(String.Format("Usunięto następujące przepisy:\n {0}", String.Join("\n", nazwyusunietychulubionych)));


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił problem z załadowaniem danych składników. Proszę spróbować ponownie", ex.Message);
            }
        }

        private void buttonDodajUlubiony_Click(object sender, EventArgs e)
        {
            DodajUlubioneOkno dodajUlubioneOkno = new DodajUlubioneOkno();
            dodajUlubioneOkno.ShowDialog();
        }

        private void dataGridViewListaUlubione_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }
    }
}
