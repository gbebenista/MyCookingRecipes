using System.Collections.Generic;

namespace MyCookingRecipes
{
    public class Przepisy
    {
        public int PrzepisyId { get; set; }
        public string NazwaPotrawy { get; set; }
        public int CzasPrzygotowania { get; set; }
        public int? IloscPorcji { get; set; }

        public List<Ulubione> Ulubione { get; set; }

        public List<DataWybraniaPrzepisu> DataWybraniaPrzepisow { get; set; }

        public List<KrokiPrzygotowaniaPrzepisu> KrokiPrzygotowaniaPrzepisow { get; set; }
        public List<SkladnikWPrzepisie> SkladnikiWPrzepisie { get; set; }
    }
}
