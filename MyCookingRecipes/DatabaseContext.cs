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
