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
    public partial class PrzepisyOkno : Form
    {
        public PrzepisyOkno()
        {
            InitializeComponent();
        }

        public void LadujPrzepisy()
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewPrzepisyOknoLista.DataSource = db.PobierzPrzepisy();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania danych do okna przepisów");
            }
        }


        private void PrzepisyOkno_Load(object sender, EventArgs e)
        {
            LadujPrzepisy();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodajModyfikujPrzepisOkno dodajModyfikujPrzepisOkno = new DodajModyfikujPrzepisOkno();
            dodajModyfikujPrzepisOkno.Show();
        }

        private void buttonSzukajPrzepis_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    dataGridViewPrzepisyOknoLista.DataSource = db.WyszukajPrzepisy(textBoxSzukajPrzepis.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas wyszukiwania przepisów");
            }
        }

        private void buttonModyfikujPrzepis_Click(object sender, EventArgs e)
        {
            DodajModyfikujPrzepisOkno dodajModyfikujPrzepisOkno = new DodajModyfikujPrzepisOkno();
            dodajModyfikujPrzepisOkno.Show();
        }

        private void buttonUsunPrzepis_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania przepisu");
            }
        }
    }
}
