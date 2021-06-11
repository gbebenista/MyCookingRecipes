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
    public partial class KrokiPrzepisuOkno : Form
    {
        public int? PrzepisId { get; set; }
        public Przepisy PrzepisOtrzymany { get; set; }

        public KrokiPrzepisuOkno(int? przepisid, Przepisy przepis)
        {
            InitializeComponent();
            PrzepisId = przepisid;
            PrzepisOtrzymany = przepis;
        }

        private void dataGridViewListaKrokowPrzepisu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
            buttonZamknij.DialogResult = DialogResult.OK;
        }

        private void buttonUsunKrokiPrzepisu_Click(object sender, EventArgs e)
        {
            try
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    db.Remove(db.KrokiPrzygotowaniaPrzepisow.Where(kpp => kpp.KrokiPrzygotowaniaPrzepisuId == (int)dataGridViewListaKrokowPrzepisu.CurrentRow.Cells[0].Value).First());
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas usuwania kroków przygotowania przepisu");
            }
        }

        private void buttonDodajKrokPrzepisu_Click(object sender, EventArgs e)
        {
            try
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    if (textBoxOpisKrokuPrzepisu.Text == "") return;
                    switch (PrzepisId)
                    {
                        case null:
                            KrokiPrzygotowaniaPrzepisu nowyKrokPrzygotowaniaPrzepisu = new KrokiPrzygotowaniaPrzepisu
                            {
                                Opis = textBoxOpisKrokuPrzepisu.Text,
                                KolejnoscWPrzepisie = (int)numericUpDownKolejnoscWPrzepisie.Value,
                                Przepisy = PrzepisOtrzymany  
                            };
                            if (db.KrokiPrzygotowaniaPrzepisow.Where(er => er.Przepisy == null && er.KolejnoscWPrzepisie == nowyKrokPrzygotowaniaPrzepisu.KolejnoscWPrzepisie).Any())
                            {
                                MessageBox.Show("Wybrana kolejność w przepisie jest już dodana");
                                break;
                            };
                            db.Add(nowyKrokPrzygotowaniaPrzepisu);
                            db.SaveChanges();
                            MessageBox.Show("Dodano krok przygotowania przepisu");
                            break;
                        default:
                            KrokiPrzygotowaniaPrzepisu nowyKrokPrzygotowaniaPrzepisuE = new KrokiPrzygotowaniaPrzepisu
                            {
                                Opis = textBoxOpisKrokuPrzepisu.Text,
                                KolejnoscWPrzepisie = (int)numericUpDownKolejnoscWPrzepisie.Value,
                                Przepisy = db.Przepisy.Where(p => p.PrzepisyId == PrzepisId).First()
                            };
                            if (db.KrokiPrzygotowaniaPrzepisow.Where(er => er.Przepisy.PrzepisyId == nowyKrokPrzygotowaniaPrzepisuE.Przepisy.PrzepisyId && er.KolejnoscWPrzepisie == nowyKrokPrzygotowaniaPrzepisuE.KolejnoscWPrzepisie).Any())
                            {
                                MessageBox.Show("Wybrana kolejność w przepisie jest już dodana");
                                break;
                            };
                            db.Add(nowyKrokPrzygotowaniaPrzepisuE);
                            db.SaveChanges();
                            MessageBox.Show("Dodano krok przygotowania przepisu");
                            break;
                        
                    }
                    LadujKrokiPrzepisu();

                    DodajModyfikujPrzepisOkno dodajModyfikujPrzepisOkno = (DodajModyfikujPrzepisOkno)Application.OpenForms["DodajModyfikujPrzepisOkno"];
                    dodajModyfikujPrzepisOkno.LadujKrokiPrzepisu();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania kroku przygotowania przepisu.");
            }
        }

        public void LadujKrokiPrzepisu()
        {
            try
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewListaKrokowPrzepisu.DataSource = db.KrokiPrzygotowaniaPrzepisow.Where(kpp => kpp.Przepisy.PrzepisyId == PrzepisId).ToList();
        
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem z wyświetleniem kroków przepisu");
            }
        }

        private void KrokiPrzepisuOkno_Load(object sender, EventArgs e)
        {
            LadujKrokiPrzepisu();
        }
    }
}
