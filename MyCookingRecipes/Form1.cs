using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyCookingRecipes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            SprawdzCzyIstniejePlik();
            InitializeComponent();

            SprawdzPrzepisyZOstatniegoMiesiaca();
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
            if (przepisyOkno.DialogResult == DialogResult.OK) LoadDefaultDataGridView();
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
                if (e.RowIndex > -1)
                {
                    dataGridViewListaPrzepisow.CurrentCell = dataGridViewListaPrzepisow.Rows[e.RowIndex].Cells[0];
                    e.ContextMenuStrip = ContextMenuStrip;
                }

                if (db.CzyJestUlubiony((int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value)) dodajUsunDoUlubionychToolStripMenuItem.Text = "Usuń z ulubionych";
                else dodajUsunDoUlubionychToolStripMenuItem.Text = "Dodaj do ulubionych";
            }
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

        private void modyfikujPrzepisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajModyfikujPrzepisOkno dodajModyfikujPrzepisOkno = new DodajModyfikujPrzepisOkno((int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value);
            dodajModyfikujPrzepisOkno.ShowDialog();
        }

        private void usunPrzepisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć ten przepis?", "Usuwanie przepisu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.UsunPrzepis((int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value);

                        MessageBox.Show("Usunięto przepis.");

                        LoadDefaultDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił problem podczas usuwania przepisu.", ex.InnerException.ToString());
            }
        }

        private void dodajUsunDoUlubionychToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {

                    if (db.CzyJestUlubiony((int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value))
                    {
                        db.Remove(db.Ulubione.Where(u => u.Przepis.PrzepisyId == (int)dataGridViewListaPrzepisow.CurrentRow.Cells[0].Value).First());
                        db.SaveChanges();
                        MessageBox.Show(String.Format("Usunięto przepis:{0}", dataGridViewListaPrzepisow.CurrentRow.Cells[1].Value));
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

        private void SprawdzPrzepisyZOstatniegoMiesiaca()
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    List<Ulubione> noweUlubione = new List<Ulubione>();


                    var ulub = (from ulu in db.Ulubione
                                where ulu.CzySystemDodal == false
                                select ulu.Przepis.PrzepisyId
                                ).ToList();
                    var kompulu = (from dwp in db.DataWybraniaPrzepisow
                                   where dwp.DataWybrania > DateTime.Today.AddDays(-30)
                                   group dwp by dwp.Przepisy.PrzepisyId into g

                                   select new
                                   {
                                       g.Key,
                                       Ilosc = g.Count()
                                   }
                             ).OrderByDescending(i => i.Ilosc).ThenBy(j => j.Key).Take(5).ToList();


                    var xx = kompulu.Select(e => e.Key).Where(e => !ulub.Contains(e)).ToList();

                    foreach (var i in xx)
                    {
                        noweUlubione.Add(new Ulubione
                        {
                            Przepis = db.Przepisy.Find(i),
                            CzySystemDodal = false
                        });
                    }

                    db.RemoveRange(db.Ulubione.Where(u => u.CzySystemDodal == true).ToList());
                    db.AddRange(noweUlubione);
                    db.SaveChanges();
                    //Console.WriteLine(xx);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas dodawania przepisów do ulubionych .");


            }

        }
        private void SprawdzCzyIstniejePlik()
        {
            try
            {
                if (!File.Exists("RecipesDB.mdf"))
                {
                    MessageBox.Show(@"Nie można odnaleść bazy danych. Upewnij się że w folderze jest plik RecipesDB.mdf", "Zamykanie");
                    Environment.Exit(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można odnaleść bazy danych. Upewnij się że w folderze jest plik RecipesDB.mdf", ex.InnerException.ToString());
            }
        }
    }

}
