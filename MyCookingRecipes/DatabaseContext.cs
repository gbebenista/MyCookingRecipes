using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookingRecipes
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Przepisy> Przepisy { get; set; }
        public DbSet<Ulubione> Ulubione { get; set; }
        public DbSet<DataWybraniaPrzepisu> DataWybraniaPrzepisow { get; set; }
        public DbSet<KrokiPrzygotowaniaPrzepisu> KrokiPrzygotowaniaPrzepisow { get; set; }

        public DbSet<Skladniki> Skladniki { get; set; }
        public DbSet<RodzajIlosciSkladnika> RodzajIlosciSkladnikow { get; set; }
        public DbSet<SkladnikWPrzepisie> SkladnikiWPrzepisach { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>  optionsBuilder.UseSqlServer(@"Server=localhost;Database=RecipesDB;Trusted_Connection=True");
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>  optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;AttachDBFilename="+ Environment.CurrentDirectory+"\\RecipesDB.mdf;Trusted_Connection=true;MultipleActiveResultSets=true");
        public List<Przepisy> PobierzPrzepisy()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return Przepisy.ToList();
            }
        }
        public Przepisy PobierzPrzepis(int id)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Przepisy.Include(p => p.SkladnikiWPrzepisie).ThenInclude(p => p.Skladnik).ThenInclude(p => p.RodzajIlosciSkladnika).Where(p => p.PrzepisyId == id).First();
            }
        }

        public Przepisy PobierzPrzepisZKrokami(int id)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Przepisy.Include(p => p.SkladnikiWPrzepisie).ThenInclude(p => p.Skladnik).ThenInclude(p => p.RodzajIlosciSkladnika).Include(p => p.KrokiPrzygotowaniaPrzepisow).Where(p => p.PrzepisyId == id).First();
            }
        }

        public List<Przepisy> WyszukajPrzepisy(string name)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Przepisy.Where(p => p.NazwaPotrawy.Contains(name)).ToList();
            }
        }
        public void PobierzSkladnikiwPrzepisie(int id)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.SkladnikiWPrzepisach.Join(
                                db.Skladniki,
                                skladnikiwprzepisie => skladnikiwprzepisie.Skladnik.SkladnikiId,
                                skladniki => skladniki.SkladnikiId,
                                (skladnikiwprzepisie, skladniki) => new
                                {
                                    Nazwa = skladniki.NazwaSkladnika,

                                }
                                ).ToList();
            }
        }

        public List<RodzajIlosciSkladnika> PobierzRodzajeIlosciSkladnika()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return RodzajIlosciSkladnikow.ToList();
            }
        }

        public bool CzyJestUlubiony(int id)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Ulubione.Where(u => u.Przepis.PrzepisyId == id).Any();
            }
        }

       public void UsunPrzepis(int przepisid)
        {
            using(DatabaseContext db = new DatabaseContext())
            {
                if (db.Ulubione.Where(u => u.Przepis.PrzepisyId == przepisid).Any())
                    db.Ulubione.RemoveRange(db.Ulubione.Where(u => u.Przepis.PrzepisyId == przepisid).First());
                db.DataWybraniaPrzepisow.RemoveRange(db.DataWybraniaPrzepisow.Where(dwp => dwp.Przepisy.PrzepisyId == przepisid).ToList());
                db.KrokiPrzygotowaniaPrzepisow.RemoveRange(db.KrokiPrzygotowaniaPrzepisow.Where(kpp => kpp.Przepisy.PrzepisyId == przepisid).ToList());
                db.SkladnikiWPrzepisach.RemoveRange(db.SkladnikiWPrzepisach.Where(swp => swp.Przepis.PrzepisyId == przepisid).ToList());
                db.Przepisy.RemoveRange(db.Przepisy.Where(p => p.PrzepisyId == przepisid).First());
                db.SaveChanges();
            }
        }

    }
}
