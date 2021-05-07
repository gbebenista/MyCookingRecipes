using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookingRecipes
{
    public class Ulubione
    {
        public int IdUlubionegoPrzepisu { get; set; }
        public int IdPrzepisu { get; set; }
        public bool CzySystemDodal { get; set; }

        public Przepisy Przepis { get; set; }
    }
}
