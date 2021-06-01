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
                using(DatabaseContext db = new DatabaseContext())
                {
                    comboBoxRodzajeIlosciSkladnika.DataSource = db.PobierzRodzajeIlosciSkladnika();
                    dataGridViewListaSkladnikow.DataSource =  db.Skladniki.Join(
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
            catch(Exception ex)
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
                    Skladniki skladnik = new Skladniki();
                    skladnik.NazwaSkladnika = textBoxNazwaSkladnika.Text;
                    skladnik.RodzajIlosciSkladnika.RodzajIlosciSkladnikaId = (int)comboBoxRodzajeIlosciSkladnika.SelectedIndex + 1;
                    db.Add(skladnik);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił problem z dodaniem składnika. Proszę spróbować ponownie", ex.Message);
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
                    ).Where(skladnik => skladnik.NazwaSkladnika == textBoxNazwaSkladnika.Text).ToList();
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
                    DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone przepisy?", "Usuwanie przepisów", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        List<string> nazwyusunietychskladnikow = new List<string>();
                        foreach (DataGridViewRow row in dataGridViewListaSkladnikow.SelectedRows)
                        {
                            var skladnikwprzepisie = db.SkladnikiWPrzepisach.Where(swp => swp.Skladnik.SkladnikiId == (int)row.Cells[0].Value).Any();
                            // sprawdzić czy nie pusta baza
                            if (skladnikwprzepisie == false)
                            {
                                nazwyusunietychskladnikow.Add(row.Cells[1].Value.ToString());
                                db.Remove(db.Skladniki.Where(s => s.SkladnikiId == (int)row.Cells[0].Value).First());
                            }
                            
                        }
                        db.SaveChanges();
                        MessageBox.Show(String.Format("Usunięto następujące składniki:{0} \n Pozostałe składniki znajdują się w przepisach. W celu usunięcia składników należy usunąć najpierw powiązane z nimi przepisy.", String.Join(",", nazwyusunietychskladnikow)));
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
            
        }

        private void SkladnikiOkno_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void comboBoxRodzajeIlosciSkladnika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
