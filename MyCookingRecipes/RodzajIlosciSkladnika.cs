using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookingRecipes
{
    public class RodzajIlosciSkladnika
    {
        public int IdRodzajuIlosciSkladnika { get; set; }

        public string Liczebność { get; set; }

        public List<Skladniki> Skladnik { get; set; }
    }
}
 