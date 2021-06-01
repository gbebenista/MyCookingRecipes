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
            using(DatabaseContext db = new DatabaseContext())
            {
                return Przepisy.ToList();
            }
        }
        public Przepisy PobierzPrzepis(int id)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Przepisy.Find(id);
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

    }
}
