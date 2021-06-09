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
    public partial class SkladnikiOkno : Form
    {
        public SkladnikiOkno()
        {
            InitializeComponent();
        }

        private void SkladnikiOkno_Load(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    comboBoxRodzajeIlosciSkladnika.DataSource = db.PobierzRodzajeIlosciSkladnika();
                    comboBoxRodzajeIlosciSkladnika.DisplayMember = "Liczebność";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił problem z załadowaniem danych składników. Proszę spróbować ponownie", ex.Message);
            }
            LoadDefaultDataGridView();
        }

        public void LoadDefaultDataGridView()
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    
                    dataGridViewListaSkladnikow.DataSource = db.Skladniki.Join(
                    db.RodzajIlosciSkladnikow,
                    skladnik => skladnik.RodzajIlosciSkladnika.RodzajIlosciSkladnikaId,
                    rodzajskladnika => rodzajskladnika.RodzajIlosciSkladnikaId,
                    (skladnik, rodzajskladnika) => new {
                        skladnik.SkladnikiId,
                        skladnik.NazwaSkladnika,
                        rodzajskladnika.Liczebność
                    }
                    ).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił problem z załadowaniem danych składników. Proszę spróbować ponownie", ex.Message);
            }
        }

        private void buttonDodajSkladnik_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    Skladniki skladnik = new Skladniki
                    {
                        NazwaSkladnika = textBoxNazwaSkladnika.Text,
                        RodzajIlosciSkladnika = db.RodzajIlosciSkladnikow.Find(((RodzajIlosciSkladnika)comboBoxRodzajeIlosciSkladnika.SelectedItem).RodzajIlosciSkladnikaId)
                    };
                    db.Add(skladnik);
                    db.SaveChanges();
                    LoadDefaultDataGridView();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił problem z dodaniem składnika. Proszę spróbować ponownie"+ex.InnerException.ToString());
            }
        }

        private void buttonWyszukajSkladnik_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewListaSkladnikow.DataSource = db.Skladniki.Join(
                    db.RodzajIlosciSkladnikow,
                    skladnik => skladnik.RodzajIlosciSkladnika.RodzajIlosciSkladnikaId,
                    rodzajskladnika => rodzajskladnika.RodzajIlosciSkladnikaId,
                    (skladnik, rodzajskladnika) => new {
                        skladnik.SkladnikiId,
                        skladnik.NazwaSkladnika,
                        rodzajskladnika.Liczebność
                    }
                    ).Where(skladnik => skladnik.NazwaSkladnika.Contains(textBoxWyszukajSkladnik.Text)).ToList();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił problem z załadowaniem danych składników. Proszę spróbować ponownie", ex.Message);
            }
        }

        private void buttonUsunSkladniki_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    if (dataGridViewListaSkladnikow.SelectedRows.Count == 0) return;
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone przepisy?", "Usuwanie przepisów", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {


                            List<string> nazwyusunietychskladnikow = new List<string>();

                            foreach (DataGridViewRow row in dataGridViewListaSkladnikow.SelectedRows)
                            {
                                var skladnikwprzepisie = db.SkladnikiWPrzepisach.Where(swp => swp.Skladnik.SkladnikiId == (int)row.Cells[0].Value).Any();
                                if (skladnikwprzepisie == false)
                                {
                                    nazwyusunietychskladnikow.Add(row.Cells[1].Value.ToString());
                                    db.Remove(db.Skladniki.Where(s => s.SkladnikiId == (int)row.Cells[0].Value).First());
                                }

                            }
                            db.SaveChanges();
                            LoadDefaultDataGridView();
                            MessageBox.Show(String.Format("Usunięto następujące składniki:\n {0}", String.Join("\n", nazwyusunietychskladnikow)));


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił problem z załadowaniem danych składników. Proszę spróbować ponownie", ex.Message);
            }
        }

        private void buttonZamknijOkno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SkladnikiOkno_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
