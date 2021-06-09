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
        public SkladnikiWPrzepisieOkno()
        {
            InitializeComponent();
        }

        private void dataGridViewSkladnikiWPrzepisie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }
    }
}
