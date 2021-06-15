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
