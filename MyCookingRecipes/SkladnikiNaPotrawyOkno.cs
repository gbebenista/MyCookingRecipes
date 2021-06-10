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
    public partial class SkladnikiNaPotrawyOkno : Form
    {
        public SkladnikiNaPotrawyOkno()
        {
            InitializeComponent();
        }

        public void LoadDefaultDataGridView()
        {
            try
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    dataGridViewListaPrzepisow.DataSource = context.Przepisy.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania przepisów do tabeli");
            }
        }

        private void dataGridViewListaSkladnikow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewListaSkladnikow.ClearSelection();
        }

        private void buttonZnajdzSkladniki_Click(object sender, EventArgs e)
        {
            try
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    //TO JEST NIE DO NAPISANIA

                    //dataGridViewListaSkladnikow.DataSource = db.SkladnikiWPrzepisach.Join(
                    //    db.Skladniki,
                    //    skladnikwprzepisie => skladnikwprzepisie.Skladnik.SkladnikiId,
                    //    skladnik => skladnik.SkladnikiId,
                    //    (skladnikwprzepisie, skladnik) => new {skladnikwprzepisie, skladnik}
                    //    ).Join(
                    //    db.Przepisy,
                    //    skladnikiwprzepisach => skladnikiwprzepisach.skladnikwprzepisie.Przepis.PrzepisyId,
                    //    przepis => przepis.PrzepisyId,
                    //    (skladnikiwprzepisach, przepis) => new {skladnikiwprzepisach, przepis}
                    //    ).Join(
                    //    db.RodzajIlosciSkladnikow,
                    //    rodzajilosciskladnikow => rodzajilosciskladnikow.skladnikiwprzepisach.skladnik.RodzajIlosciSkladnika.RodzajIlosciSkladnikaId,
                    //    skladniki => skladniki.RodzajIlosciSkladnikaId,
                    //    (rodzajilosciskladnikow, skladniki) => new {rodzajilosciskladnikow, skladniki}
                    //    )
                    //    .Where(p => p.rodzajilosciskladnikow.przepis.PrzepisyId == (int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value).GroupBy(swp => swp.rodzajilosciskladniko);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem ze stworzeniem listy składników.");
            }
        }

        private void textBoxSzukaj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    if (textBoxSzukaj.Text == "") dataGridViewListaPrzepisow.DataSource = db.Przepisy.ToList();
                    else dataGridViewListaPrzepisow.DataSource = db.Przepisy.Where(p => p.NazwaPotrawy.Contains(textBoxSzukaj.Text)).ToList();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas ładowania listy przepisów które znajdują się w ulubionych");
            }
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {

        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SkladnikiNaPotrawyOkno_Load(object sender, EventArgs e)
        {
            LoadDefaultDataGridView();
        }
    }
}
