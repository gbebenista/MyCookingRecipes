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
    public partial class SkladnikiWPrzepisieOkno : Form
    {
        public int? PrzepisId { get; set; }

        public Przepisy PrzepisOtrzymany { get; set; }
        public SkladnikiWPrzepisieOkno(int? przepisid, Przepisy przepis)
        {
            InitializeComponent();
            PrzepisId = przepisid;
            PrzepisOtrzymany = przepis;
        }

        private void dataGridViewSkladnikiWPrzepisie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }

        public void LadujSkladniki()
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewSkladniki.DataSource = db.Skladniki.Join(
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
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem z załadowaniem składników.");
            }
        }

        private void textBoxSzukajSkladniki_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewSkladniki.DataSource = db.Skladniki.Join(
                    db.RodzajIlosciSkladnikow,
                    skladnik => skladnik.RodzajIlosciSkladnika.RodzajIlosciSkladnikaId,
                    rodzajskladnika => rodzajskladnika.RodzajIlosciSkladnikaId,
                    (skladnik, rodzajskladnika) => new {
                        skladnik.SkladnikiId,
                        skladnik.NazwaSkladnika,
                        rodzajskladnika.Liczebność
                    }
                    ).Where(skladnik => skladnik.NazwaSkladnika.Contains(textBoxSzukajSkladniki.Text)).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem z załadowaniem wyszukanych składników w przepisie.");
            }
        }

        private void buttonWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSkladnikiOkno_Click(object sender, EventArgs e)
        {
            SkladnikiOkno skladnikiOkno = new SkladnikiOkno();
            skladnikiOkno.ShowDialog();
            if (skladnikiOkno.DialogResult == DialogResult.OK) LadujSkladniki();
        }

        private void SkladnikiWPrzepisieOkno_Load(object sender, EventArgs e)
        {
            LadujSkladniki();
        }

        private void dataGridViewSkladniki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            labelWybranySkladnikNazwa.Text = dataGridViewSkladniki.CurrentRow.Cells[1].Value.ToString();
            labelRodzajIlosciNazwa.Text = dataGridViewSkladniki.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonDodajDoPrzepisu_Click(object sender, EventArgs e)
        {
            try
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    DodajModyfikujPrzepisOkno dodajModyfikujPrzepisOkno = (DodajModyfikujPrzepisOkno)Application.OpenForms["DodajModyfikujPrzepisOkno"];

                    switch (PrzepisId)
                    {
                        case null:
                            SkladnikWPrzepisie nowySkladnikWPrzepisie = new SkladnikWPrzepisie
                            {
                                Ilosc = numericUpDownIlosc.Value,
                                Skladnik = db.Skladniki.Where(s => s.SkladnikiId == (int)dataGridViewSkladniki.CurrentRow.Cells[0].Value).First(),
                                Przepis = PrzepisOtrzymany 
                            };
                            db.Add(nowySkladnikWPrzepisie);
                            db.SaveChanges();
                            break;
                        default:
                            SkladnikWPrzepisie nowySkladnikWPrzepisieE = new SkladnikWPrzepisie
                            {
                                Ilosc = numericUpDownIlosc.Value,
                                Skladnik = db.Skladniki.Where(s => s.SkladnikiId == (int)dataGridViewSkladniki.CurrentRow.Cells[0].Value).First(),
                                Przepis = db.Przepisy.Where(p => p.PrzepisyId == PrzepisId).First()
                            };
                            db.Add(nowySkladnikWPrzepisieE);
                            db.SaveChanges();
                            break;
                    }
                    MessageBox.Show("Dodano składnik do przepisu");
                    dodajModyfikujPrzepisOkno.LadujSkladnikiWPrzepisie();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem z dodawaniem ");
            }

        }
    }
}
