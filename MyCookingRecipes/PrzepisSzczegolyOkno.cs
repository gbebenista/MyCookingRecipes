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
                using(DatabaseContext db = new DatabaseContext())
                {
                    Przepisy przepis = db.PobierzPrzepisZKrokami(PrzepisId);

                    labelNazwaPrzepisu.Text = przepis.NazwaPotrawy;
                    labelCzasPrzygotowania.Text = przepis.CzasPrzygotowania.ToString();
                    labelIloscPorcji.Text = przepis.IloscPorcji.ToString();

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

        }
    }
}
