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
    public partial class DodajModyfikujPrzepisOkno : Form
    {
        public int? PrzepisId { get; set; }
        public Przepisy PrzepisDoPrzekazania { get; set; }

        public DodajModyfikujPrzepisOkno(int? id)
        {
            InitializeComponent();
            PrzepisId = id;
        }

        public void LadujSkladnikiWPrzepisie()
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewSkladniki.DataSource = db.SkladnikiWPrzepisach.Where(swp => swp.Przepis.PrzepisyId == PrzepisId).Select(swp => new { swp.SkladnikWPrzepisieId, swp.Skladnik.SkladnikiId, swp.Skladnik.NazwaSkladnika,  swp.Ilosc }).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas ładowania danych o składnikach w wybranym przepisie");
            }
        }

        public void LadujKrokiPrzepisu()
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewKrokiPrzygotowania.DataSource = db.KrokiPrzygotowaniaPrzepisow.Where(kpp => kpp.Przepisy.PrzepisyId == PrzepisId).Select(kpp => new { kpp.KrokiPrzygotowaniaPrzepisuId, kpp.Opis, kpp.KolejnoscWPrzepisie }).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas ładowania danych o krokach w wybranym przepisie");
            }
        }
        private void buttonDodajSkladnik_Click(object sender, EventArgs e)
        {
            SkladnikiWPrzepisieOkno skladnikiWPrzepisieOkno = new SkladnikiWPrzepisieOkno(PrzepisId, PrzepisDoPrzekazania);
            skladnikiWPrzepisieOkno.ShowDialog();
        }

        private void buttonDodajKrok_Click(object sender, EventArgs e)
        {
            KrokiPrzepisuOkno krokiPrzepisuOkno = new KrokiPrzepisuOkno(PrzepisId, PrzepisDoPrzekazania);
            krokiPrzepisuOkno.ShowDialog();
        }

        private void buttonDodajPrzepis_Click(object sender, EventArgs e)
        {
            try
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    switch (PrzepisId)
                    {
                        case null:
                            
                            Przepisy nowyprzepis = new Przepisy {
                                NazwaPotrawy = textBoxNazwaPrzepisu.Text,
                                CzasPrzygotowania = (int)numericUpDownCzasPrzygotowania.Value,
                                IloscPorcji = (int)numericUpDownIloscPorcji.Value,
                                
                            };
                            PrzepisDoPrzekazania = nowyprzepis;
                            db.Add(nowyprzepis);
                            foreach(DataGridViewRow row in dataGridViewSkladniki.Rows)
                            {
                                SkladnikWPrzepisie skladnikWPrzepisie = new SkladnikWPrzepisie
                                {
                                    Ilosc = (decimal)row.Cells[3].Value,
                                    Przepis = nowyprzepis,
                                    Skladnik = db.Skladniki.Include(s => s.RodzajIlosciSkladnika).Where(s => s.SkladnikiId == (int)row.Cells[1].Value).First()
                                };
                                db.Add(skladnikWPrzepisie);
                            }
                            foreach(DataGridViewRow row in dataGridViewKrokiPrzygotowania.Rows)
                            {
                                KrokiPrzygotowaniaPrzepisu krokiPrzygotowaniaPrzepisu = new KrokiPrzygotowaniaPrzepisu
                                {
                                    Opis = row.Cells[1].Value.ToString(),
                                    KolejnoscWPrzepisie = (int)row.Cells[2].Value,
                                    Przepisy = nowyprzepis
                                };
                                db.Add(krokiPrzygotowaniaPrzepisu);
                            }
                            if (checkBoxDodajDoUlubionych.Checked)
                            {
                                Ulubione nowyulubiony = new Ulubione
                                {
                                    Przepis = nowyprzepis,
                                    CzySystemDodal = false
                                };
                                db.Add(nowyulubiony);
                            }
                            
                            db.SaveChanges();
                           
                            break;
                        default:
                            Przepisy edytowanyprzepis = db.Przepisy.Where(p => p.PrzepisyId == PrzepisId).First();
                            if (edytowanyprzepis.NazwaPotrawy != textBoxNazwaPrzepisu.Text) edytowanyprzepis.NazwaPotrawy = textBoxNazwaPrzepisu.Text;
                            if (edytowanyprzepis.IloscPorcji != numericUpDownIloscPorcji.Value) edytowanyprzepis.IloscPorcji = (int)numericUpDownIloscPorcji.Value;
                            if (edytowanyprzepis.CzasPrzygotowania != numericUpDownCzasPrzygotowania.Value) edytowanyprzepis.CzasPrzygotowania = (int)numericUpDownCzasPrzygotowania.Value;
                            db.SaveChanges();
                            if (checkBoxDodajDoUlubionych.Checked) db.Add(edytowanyprzepis);
                            db.SaveChanges();
                            MessageBox.Show("Pomyślnie edytowano przepis");
                            break;
                            
                    }
                    PrzepisyOkno przepisyOkno = (PrzepisyOkno)Application.OpenForms["PrzepisyOkno"];
                    przepisyOkno.LadujPrzepisy();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania/edycji przepisu.", ex.InnerException.ToString());
            }
        }

        private void dataGridViewSkladniki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }

        private void dataGridViewKrokiPrzygotowania_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }

        private void DodajModyfikujPrzepisOkno_Load(object sender, EventArgs e)
        {
            if (PrzepisId != null)
            {
                groupBoxDodajPrzepis.Text = "Edytuj przepis";
                buttonDodajPrzepis.Text = "Zakończ edycję";

                using (DatabaseContext db = new DatabaseContext())
                {
                    Przepisy przepis = db.Przepisy.Where(p => p.PrzepisyId == PrzepisId).First();
                    checkBoxDodajDoUlubionych.Enabled = !db.Ulubione.Where(u => u.Przepis.PrzepisyId == PrzepisId).Any();
                    textBoxNazwaPrzepisu.Text = przepis.NazwaPotrawy;
                    numericUpDownCzasPrzygotowania.Value = przepis.CzasPrzygotowania;
                    numericUpDownIloscPorcji.Value = (decimal)przepis.IloscPorcji;
                    LadujKrokiPrzepisu();
                    LadujSkladnikiWPrzepisie();
                }
            }
        }

        private void dataGridViewKrokiPrzygotowania_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridViewKrokiPrzygotowania.CurrentRow.Cells[1].Value.ToString());
        }

        private void dataGridViewSkladniki_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridViewSkladniki.Rows.Count > 1) buttonUsunSkladnik.Enabled = true;
            else buttonUsunSkladnik.Enabled = false;
        }

        private void dataGridViewKrokiPrzygotowania_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridViewKrokiPrzygotowania.Rows.Count > 1) buttonUsunKrok.Enabled = true;
            else buttonUsunKrok.Enabled = false;
        }

        private void buttonUsunSkladnik_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.Remove(db.SkladnikiWPrzepisach.Where(swp => swp.SkladnikWPrzepisieId == (int)dataGridViewSkladniki.CurrentRow.Cells[0].Value).First());
                    db.SaveChanges();
                    LadujSkladnikiWPrzepisie();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas usuwania składnika z przepisu.");
            }
        }

        private void buttonUsunKrok_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.Remove(db.KrokiPrzygotowaniaPrzepisow.Where(kpp => kpp.KrokiPrzygotowaniaPrzepisuId == (int)dataGridViewKrokiPrzygotowania.CurrentRow.Cells[0].Value).First());
                    db.SaveChanges();
                    LadujKrokiPrzepisu();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas usuwania kroku przygotowania przepisu.");
            }
        }

        private void textBoxNazwaPrzepisu_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNazwaPrzepisu.Text == "") buttonDodajPrzepis.Enabled = false;
            else buttonDodajPrzepis.Enabled = true;
        }
    }
}
