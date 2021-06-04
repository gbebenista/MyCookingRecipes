using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
