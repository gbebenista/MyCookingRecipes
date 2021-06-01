using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookingRecipes
{
    public class KrokiPrzygotowaniaPrzepisu
    {
        public int KrokiPrzygotowaniaPrzepisuId { get; set; }
        public string Opis { get; set; }
        public int KolejnoscWPrzepisie { get; set; }
        public Przepisy Przepisy { get; set; }
    }
}
