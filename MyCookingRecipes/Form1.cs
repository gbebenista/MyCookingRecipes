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


        private void dataGridViewListaPrzepisow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    Przepisy selected = db.PobierzPrzepis((int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value);
                    labelNazwaPrzepisu.Text = selected.NazwaPotrawy;
                    labelCzasPrzygotowania.Text = selected.CzasPrzygotowania.ToString();
                    labelIloscPorcji.Text = selected.IloscPorcji.ToString();
                    labelNazwaPrzepisu.Text = selected.NazwaPotrawy;
                    labelCzasPrzygotowania.Text = selected.CzasPrzygotowania.ToString();
                    labelIloscPorcji.Text = selected.IloscPorcji.ToString();
                    
                    listBoxSkladnikiWPrzepisie.DataSource = selected.SkladnikiWPrzepisie.Select(x => new { x.Skladnik.NazwaSkladnika }).ToList();
                    listBoxSkladnikiWPrzepisie.DisplayMember = "NazwaSkladnika";

                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania pojedynczego przepisu.");
            }

        }

        private void groupBoxSzczegolyPrzepisu_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewListaPrzepisow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zarzadzajToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewListaPrzepisow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PrzepisSzczegolyOkno przepisSzczegolyOkno = new PrzepisSzczegolyOkno();
            przepisSzczegolyOkno.Show();
        }
    }
}
