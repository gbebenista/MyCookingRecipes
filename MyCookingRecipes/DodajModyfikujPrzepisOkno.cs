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
        int? PrzepisId { get; set; }

        public DodajModyfikujPrzepisOkno(int? id)
        {
            InitializeComponent();
            PrzepisId = id;
        }

        private void buttonDodajSkladnik_Click(object sender, EventArgs e)
        {
            SkladnikiWPrzepisieOkno skladnikiWPrzepisieOkno = new SkladnikiWPrzepisieOkno();
            skladnikiWPrzepisieOkno.ShowDialog();
        }

        private void buttonDodajKrok_Click(object sender, EventArgs e)
        {
            KrokiPrzepisuOkno krokiPrzepisuOkno = new KrokiPrzepisuOkno();
            krokiPrzepisuOkno.ShowDialog();
        }

        private void buttonDodajPrzepis_Click(object sender, EventArgs e)
        {

        }
    }
}
