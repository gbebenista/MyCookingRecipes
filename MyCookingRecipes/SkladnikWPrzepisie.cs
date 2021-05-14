using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookingRecipes
{
    public class SkladnikWPrzepisie
    {
        public int IdSkladnikaWPrzepisie { get; set; }
        public int IdPrzepisu { get; set; }
        public int IdSkladnika { get; set; }

        public decimal Ilosc { get; set; }

        public Przepisy Przepis { get; set; }

        public Skladniki Skladnik { get; set; }

    }
}

