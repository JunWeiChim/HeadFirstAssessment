using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class EersteKlasWagon : Wagon
    {
        public EersteKlasWagon()
        {
            this.klasse = "1ste klas";
            this.zitplaatsen = new List<Reiziger>();
        }
    }
}
