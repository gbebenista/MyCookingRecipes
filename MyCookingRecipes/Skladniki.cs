using System.Collections.Generic;

namespace MyCookingRecipes
{
    public class Skladniki
    {
        public int SkladnikiId { get; set; }

        public string NazwaSkladnika { get; set; }

        public RodzajIlosciSkladnika RodzajIlosciSkladnika { get; set; }

        public List<SkladnikWPrzepisie> SkladnikiWPrzepisie { get; set; }

    }
}
