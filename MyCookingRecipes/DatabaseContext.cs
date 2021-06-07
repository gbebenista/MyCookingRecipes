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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RecipesDB;Trusted_Connection=True");

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

        public List<Przepisy> WyszukajPrzepisy(string name)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Przepisy.Where(p => p.NazwaPotrawy.Contains(name)).ToList();
            }
        }
        public void PobierzSkladnikiwPrzepisie(int id )
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

        //public IEnumerable<Skladniki> PobierzListeSkladnikow()
        //{
        //    using (DatabaseContext db = new DatabaseContext())
        //    {
        //        var query = Skladniki.Join(
        //            db.RodzajIlosciSkladnikow,
        //            skladnik => skladnik.IdRodzajuIlosciSkladnika,
        //            rodzajskladnika => rodzajskladnika.RodzajIlosciSkladnikaId,
        //            (skladnik, rodzajskladnika) => new 
        //            {
        //                skladnik.SkladnikiId,
        //                skladnik.NazwaSkladnika,
        //                rodzajskladnika.Liczebność
        //            }
        //            ).ToList();
        //        return query;
        //    }
        //}

    }
}
