using System;
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


        private void buttonDodajPrzepis_Click(object sender, EventArgs e)
        {
            DodajModyfikujPrzepisOkno dodajModyfikujPrzepisOkno = new DodajModyfikujPrzepisOkno(null);
            dodajModyfikujPrzepisOkno.ShowDialog();
        }


        private void buttonModyfikujPrzepis_Click(object sender, EventArgs e)
        {
            DodajModyfikujPrzepisOkno dodajModyfikujPrzepisOkno = new DodajModyfikujPrzepisOkno((int?)dataGridViewPrzepisyOknoLista.CurrentRow.Cells[0].Value);
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

                        db.UsunPrzepis((int)dataGridViewPrzepisyOknoLista.CurrentRow.Cells[0].Value);

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

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
            buttonZamknij.DialogResult = DialogResult.OK;
        }

        private void dataGridViewPrzepisyOknoLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }

        private void textBoxSzukajPrzepis_TextChanged(object sender, EventArgs e)
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

        private void dataGridViewPrzepisyOknoLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DodajModyfikujPrzepisOkno dodajModyfikujPrzepisOkno = new DodajModyfikujPrzepisOkno((int?)dataGridViewPrzepisyOknoLista.CurrentRow.Cells[0].Value);
            dodajModyfikujPrzepisOkno.ShowDialog();
        }
    }
}
