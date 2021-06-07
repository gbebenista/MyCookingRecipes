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
        public DodajModyfikujPrzepisOkno()
        {
            InitializeComponent();
        }

        private void buttonDodajSkladnik_Click(object sender, EventArgs e)
        {
            SkladnikiWPrzepisieOkno skladnikiWPrzepisieOkno = new SkladnikiWPrzepisieOkno();
            skladnikiWPrzepisieOkno.Show();
        }

        private void buttonDodajKrok_Click(object sender, EventArgs e)
        {
            KrokiPrzepisuOkno krokiPrzepisuOkno = new KrokiPrzepisuOkno();
            krokiPrzepisuOkno.Show();
        }

        private void buttonDodajPrzepis_Click(object sender, EventArgs e)
        {

        }
    }
}
