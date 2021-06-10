using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace MyCookingRecipes
{
    public partial class PrzepisSzczegolyOkno : Form
    {
        private static System.Timers.Timer aTimer;
        private const int  liczbaSekund = 60;
        public void DodajDoDateWykonania()
        {
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 1000 * liczbaSekund;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;

            Console.WriteLine("Stoper Wyłączony");

        }

        public int PrzepisId { get; set; }

        public PrzepisSzczegolyOkno(int przepisid)
        {
            InitializeComponent();
            this.PrzepisId = przepisid;
            DodajDoDateWykonania();
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

                    //listViewListaSkladnikow.Items.AddRange(przepis.SkladnikiWPrzepisie.Select(p => new { p.Skladnik.NazwaSkladnika }).ToList());
                    //listViewKrokiPrzepisu.Items.AddRange(przepis.KrokiPrzygotowaniaPrzepisow.Select(k => new { k.Opis }).ToList());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas ładowania szczegółów przepisu");
            }
        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Dodano do wykonanych : ", e.SignalTime);
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.Add(new DataWybraniaPrzepisu
                    {

                        Przepisy = db.Przepisy.Find(PrzepisId),
                        DataWybrania = DateTime.Today
                    });
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił problem podczas dodawania do listy wykonanych.", ex.InnerException.ToString());
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

                        db.UsunPrzepis(PrzepisId);

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
