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

        private void dataGridViewListaKrokowPrzepisu_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridViewListaKrokowPrzepisu.Rows.Count > 1) buttonUsunKrokiPrzepisu.Enabled = true;
            else buttonUsunKrokiPrzepisu.Enabled = false;
        }

        private void buttonDodajKrokPrzepisu_Click(object sender, EventArgs e)
        {
            try
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    switch (PrzepisId)
                    {
                        case null:
                            KrokiPrzygotowaniaPrzepisu nowyKrokPrzygotowaniaPrzepisu = new KrokiPrzygotowaniaPrzepisu
                            {
                                Opis = textBoxOpisKrokuPrzepisu.Text,
                                KolejnoscWPrzepisie = (int)numericUpDownKolejnoscWPrzepisie.Value,
                                Przepisy = PrzepisOtrzymany  
                            };
                            db.Add(nowyKrokPrzygotowaniaPrzepisu);
                            db.SaveChanges();
                            break;
                        default:
                            KrokiPrzygotowaniaPrzepisu nowyKrokPrzygotowaniaPrzepisuE = new KrokiPrzygotowaniaPrzepisu
                            {
                                Opis = textBoxOpisKrokuPrzepisu.Text,
                                KolejnoscWPrzepisie = (int)numericUpDownKolejnoscWPrzepisie.Value,
                                Przepisy = db.Przepisy.Where(p => p.PrzepisyId == PrzepisId).First()
                            };
                            db.Add(nowyKrokPrzygotowaniaPrzepisuE);
                            db.SaveChanges();
                            break;
                        
                    }
                    MessageBox.Show("Dodano krok przygotowania przepisu");
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
                    numericUpDownKolejnoscWPrzepisie.Minimum = db.KrokiPrzygotowaniaPrzepisow.Max(kpp => kpp.KolejnoscWPrzepisie);
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
