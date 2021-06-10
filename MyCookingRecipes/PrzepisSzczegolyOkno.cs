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
    public partial class PrzepisSzczegolyOkno : Form
    {
        public int PrzepisId { get; set; }

        public PrzepisSzczegolyOkno(int przepisid)
        {
            InitializeComponent();
            this.PrzepisId = przepisid;
        }

        private void PrzepisSzczegolyOkno_Load(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    Przepisy przepis = db.PobierzPrzepisZKrokami(PrzepisId);

                    labelNazwaPrzepisu.Text = przepis.NazwaPotrawy;
                    labelCzasPrzygotowania.Text = przepis.CzasPrzygotowania.ToString();
                    labelIloscPorcji.Text = przepis.IloscPorcji.ToString();

                    if (db.Ulubione.Where(u => u.Przepis.PrzepisyId == PrzepisId).Any()) labelCzyUlubione.Text = "Tak";
                    else labelCzyUlubione.Text = "Nie";

                    listBoxListaSkladnikow.DataSource = przepis.SkladnikiWPrzepisie.Select(p => new { p.Skladnik.NazwaSkladnika }).ToList();
                    listBoxListaSkladnikow.DisplayMember = "NazwaSkladnika";
                    listBoxKrokiPrzepisu.DataSource = przepis.KrokiPrzygotowaniaPrzepisow.Select(k => new { k.Opis }).ToList();
                    listBoxKrokiPrzepisu.DisplayMember = "Opis";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas ładowania szczegółów przepisu");
            }
        }

        private void buttonZamknijOkno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModyfikujPrzepis_Click(object sender, EventArgs e)
        {
            DodajModyfikujPrzepisOkno dodajModyfikujPrzepisOkno = new DodajModyfikujPrzepisOkno(PrzepisId);
            dodajModyfikujPrzepisOkno.ShowDialog();
        }

        private void buttonUsunPrzepis_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć ten przepis?", "Usuwanie przepisu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //nie działa
                        db.Ulubione.Remove(db.Ulubione.Where(u => u.Przepis.PrzepisyId == PrzepisId).First());
                        db.DataWybraniaPrzepisow.RemoveRange(db.DataWybraniaPrzepisow.Where(dwp => dwp.Przepisy.PrzepisyId == PrzepisId));
                        db.KrokiPrzygotowaniaPrzepisow.RemoveRange(db.KrokiPrzygotowaniaPrzepisow.Where(kpp => kpp.Przepisy.PrzepisyId == PrzepisId));
                        db.SkladnikiWPrzepisach.RemoveRange(db.SkladnikiWPrzepisach.Where(swp => swp.Przepis.PrzepisyId == PrzepisId));
                        db.Przepisy.Remove(db.Przepisy.Where(p => p.PrzepisyId == PrzepisId).First());
                        db.SaveChanges();

                        MessageBox.Show("Usunięto przepis. Okno zostanie zamknięte.");

                        Form1 glowneokno = (Form1)Application.OpenForms["Form1"];
                        glowneokno.LoadDefaultDataGridView();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił problem podczas usuwania przepisu.", ex.InnerException.ToString());
            }
        }
    }
}
