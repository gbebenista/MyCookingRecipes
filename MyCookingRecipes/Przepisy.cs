﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCookingRecipes
{
    public class Przepisy
    {
        public int IdPrzepisu { get; set; }
        public string NazwaPotrawy { get; set; }
        public int CzasPrzygotowania { get; set; }
        public int? IloscPorcji { get; set; }
        
        public List<Ulubione> Ulubione { get; set; }
    }
}
