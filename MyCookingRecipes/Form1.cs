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
    public partial class Form1 : Form
    {

        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem modyfikujPrzepis = new ToolStripMenuItem();
        private ToolStripMenuItem usunPrzepis = new ToolStripMenuItem();
        private ToolStripMenuItem dodajUsunUlubione = new ToolStripMenuItem();

        public Form1()
        {
            InitializeComponent();


        }
        public void LoadDefaultDataGridView()
        {
            try
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    dataGridViewListaPrzepisow.DataSource = context.Przepisy.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania przepisów do tabeli");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDefaultDataGridView();
        }

        private void dodajUsuńToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrzepisyOkno przepisyOkno = new PrzepisyOkno();
            przepisyOkno.ShowDialog();
        }

        private void dodajUsuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkladnikiOkno skladnikiOkno = new SkladnikiOkno();
            skladnikiOkno.ShowDialog();
        }


        private void dataGridViewListaPrzepisow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                using (DatabaseContext db = new DatabaseContext())
                {
                    Przepisy selected = db.PobierzPrzepis((int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value);

                    labelNazwaPrzepisu.Text = selected.NazwaPotrawy;
                    labelCzasPrzygotowania.Text = selected.CzasPrzygotowania.ToString();
                    labelIloscPorcji.Text = selected.IloscPorcji.ToString();
                    listBoxSkladnikiWPrzepisie.DataSource = selected.SkladnikiWPrzepisie.Select(x => new { x.Skladnik.NazwaSkladnika }).ToList();
                    listBoxSkladnikiWPrzepisie.DisplayMember = "NazwaSkladnika";

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania pojedynczego przepisu.");
            }

        }

        private void groupBoxSzczegolyPrzepisu_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewListaPrzepisow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zarzadzajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UlubioneOkno ulubioneOkno = new UlubioneOkno();
            ulubioneOkno.ShowDialog();
        }

        private void dataGridViewListaPrzepisow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            PrzepisSzczegolyOkno przepisSzczegolyOkno = new PrzepisSzczegolyOkno((int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value);
            przepisSzczegolyOkno.ShowDialog();
        }

        private void buttonListaSkladnikow_Click(object sender, EventArgs e)
        {
            SkladnikiNaPotrawyOkno skladnikiNaPotrawyOkno = new SkladnikiNaPotrawyOkno();
            skladnikiNaPotrawyOkno.ShowDialog();
        }

        private void dataGridViewListaPrzepisow_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {

            using (DatabaseContext db = new DatabaseContext())
            {
                bool czyprzepisjestulubiony = db.Ulubione.Where(u => u.Przepis.PrzepisyId == (int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value).Any();

                contextMenuStrip = new ContextMenuStrip();
                modyfikujPrzepis.Text = "Modyfikuj przepis";
                usunPrzepis.Text = "Usuń przepis";
                if (czyprzepisjestulubiony)
                {
                    dodajUsunUlubione.Text = "Usun z ulubionych";
                    dodajUsunUlubione.Checked = true;
                }
                else
                {
                    dodajUsunUlubione.Text = "Dodaj do ulubionych";
                    dodajUsunUlubione.Checked = false;

                }

                contextMenuStrip.Items.Add(modyfikujPrzepis);
                contextMenuStrip.Items.Add(usunPrzepis);
                contextMenuStrip.Items.Add(dodajUsunUlubione);

            }
            e.ContextMenuStrip = contextMenuStrip;
        }


        public void LoadSearchAndFavourities()
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    if (textBoxSzukaj.Text == "")
                    {
                        if (checkBoxUlubione.Checked) dataGridViewListaPrzepisow.DataSource = db.Przepisy.Join(
                        db.Ulubione,
                        przepis => przepis.PrzepisyId,
                        przepiswulubionych => przepiswulubionych.Przepis.PrzepisyId,
                        (przepis, przepiswulubionych) => new
                        {
                            przepis.PrzepisyId,
                            przepis.NazwaPotrawy,
                            przepis.IloscPorcji,
                            przepis.CzasPrzygotowania

                        }
                        ).ToList();
                        else dataGridViewListaPrzepisow.DataSource = db.Przepisy.ToList();
                    }
                    else
                    {
                        if (checkBoxUlubione.Checked) dataGridViewListaPrzepisow.DataSource = db.Przepisy.Join(
                        db.Ulubione,
                        przepis => przepis.PrzepisyId,
                        przepiswulubionych => przepiswulubionych.Przepis.PrzepisyId,
                        (przepis, przepiswulubionych) => new
                        {
                            przepis.PrzepisyId,
                            przepis.NazwaPotrawy,
                            przepis.IloscPorcji,
                            przepis.CzasPrzygotowania

                        }
                        ).Where(p => p.NazwaPotrawy.Contains(textBoxSzukaj.Text)).ToList();
                        else dataGridViewListaPrzepisow.DataSource = db.Przepisy.Where(p => p.NazwaPotrawy.Contains(textBoxSzukaj.Text)).ToList();
                    }


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas ładowania listy przepisów które znajdują się w ulubionych");
            }
        }

        private void checkBoxUlubione_CheckedChanged(object sender, EventArgs e)
        {
            LoadSearchAndFavourities();
        }

        private void textBoxSzukaj_TextChanged(object sender, EventArgs e)
        {
            LoadSearchAndFavourities();
        }

        private void modyfikujPrzepis_Click(object sender, EventArgs e)
        {
            DodajModyfikujPrzepisOkno dodajModyfikujPrzepisOkno = new DodajModyfikujPrzepisOkno((int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value);
            dodajModyfikujPrzepisOkno.ShowDialog();
        }


        private void usunPrzepis_Click(object sender, EventArgs e)
        {

        }

        private void dodajUsunUlubione_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    if (dodajUsunUlubione.Checked)
                    {
                        db.Remove(db.Ulubione.Where(u => u.Przepis.PrzepisyId == (int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value).First());
                        db.SaveChanges();
                        MessageBox.Show(String.Format("Usunięto przepis:{0}", dataGridViewListaPrzepisow.CurrentRow.Cells[1]));

                    }
                    else
                    {
                        Ulubione przepisdoulubionych = new Ulubione
                        {
                            CzySystemDodal = false,
                            Przepis = db.Przepisy.Find(dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value)
                        };
                        db.Add(przepisdoulubionych);
                        db.SaveChanges();
                        MessageBox.Show(String.Format("Dodano do ulubionych przepis {0}", przepisdoulubionych.Przepis.NazwaPotrawy));
                }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem z dodaniem/usunięciem przepisu z ulubionych.");
            }
        }

        private void dataGridViewListaPrzepisow_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridViewListaPrzepisow.CurrentCell = dataGridViewListaPrzepisow[e.ColumnIndex, e.RowIndex];
            }
        }

    }
}
