using System;

namespace MyCookingRecipes
{
    public class DataWybraniaPrzepisu
    {
        public int DataWybraniaPrzepisuId { get; set; }
        public DateTime DataWybrania { get; set; }

        public Przepisy Przepisy { get; set; }

    }
}
