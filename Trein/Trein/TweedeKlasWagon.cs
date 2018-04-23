using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class TweedeKlasWagon : Wagon
    {
        public TweedeKlasWagon()
        {
            this.klasse = "2de klas";
            this.zitplaatsen = new List<Reiziger>();
        }
    }
}
