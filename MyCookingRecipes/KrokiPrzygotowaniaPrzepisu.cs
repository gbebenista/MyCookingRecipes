using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookingRecipes
{
    public class KrokiPrzygotowaniaPrzepisu
    {
        [Key]
        public int IdKrokuPrzepisu { get; set; }
        public int IdPrzepisu { get; set; }
        public string Opis { get; set; }
        public int KolejnoscWPrzepisie { get; set; }
        public Przepisy Przepisy { get; set; }
    }
}
