using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookingRecipes
{
    public class DataWybraniaPrzepisu
    {
        [Key]
        public int IdDataWybraniaPrzepisu { get; set; }
        public int IdPrzepisu { get; set; }
        public DateTime DataWybrania { get; set; }

        public Przepisy Przepisy { get; set; }

    }
}
