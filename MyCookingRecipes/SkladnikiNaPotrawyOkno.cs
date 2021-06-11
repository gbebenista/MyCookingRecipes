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
                using (DatabaseContext db = new DatabaseContext())
                {
                    List<int> przepisyid = new List<int>();
                    foreach (DataGridViewRow row in dataGridViewListaPrzepisow.SelectedRows)
                    {
                        przepisyid.Add((int)row.Cells[0].Value);
                    }

                    var q = (from swk in db.SkladnikiWPrzepisach
                             join skl in db.Skladniki on swk.Skladnik.SkladnikiId equals skl.SkladnikiId
                             join pp in db.Przepisy on swk.Przepis.PrzepisyId equals pp.PrzepisyId
                             join ris in db.RodzajIlosciSkladnikow on swk.Skladnik.RodzajIlosciSkladnika.RodzajIlosciSkladnikaId equals ris.RodzajIlosciSkladnikaId
                             where przepisyid.Contains(swk.Przepis.PrzepisyId)
                             group swk by new { swk.Skladnik.NazwaSkladnika, ris.Liczebność } into g

                             select new
                             {

                                 g.Key.NazwaSkladnika,
                                 Ilosc = g.Sum(ii => ii.Ilosc),
                                 g.Key.Liczebność


                             }).ToList();
                    dataGridViewListaSkladnikow.DataSource = q;
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
            try
            {
                DataTable data = new DataTable();

                foreach (DataGridViewColumn col in dataGridViewListaSkladnikow.Columns)
                {
                    data.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dataGridViewListaSkladnikow.Rows)
                {
                    DataRow dRow = data.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    data.Rows.Add(dRow);
                }

                PDFGenerator.Generate(data, "lista zakupów");
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd przy generowaniu pliku PDF z listą zakupów.");
            }
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
