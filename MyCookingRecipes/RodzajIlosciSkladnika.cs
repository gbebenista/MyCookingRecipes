using System.Collections.Generic;

namespace MyCookingRecipes
{
    public class RodzajIlosciSkladnika
    {
        public int RodzajIlosciSkladnikaId { get; set; }

        public string Liczebność { get; set; }

        public List<Skladniki> Skladnik { get; set; }
    }
}
