using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookingRecipes
{
    public class DataWybraniaPrzepisu
    {
        public int DataWybraniaPrzepisuId { get; set; }
        public DateTime DataWybrania { get; set; }

        public Przepisy Przepisy { get; set; }

    }
}
