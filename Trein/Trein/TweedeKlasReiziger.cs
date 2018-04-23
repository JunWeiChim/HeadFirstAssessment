using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class TweedeKlasReiziger : Reiziger
    {
        public TweedeKlasReiziger(string bestemming) : base(bestemming)
        {
            this.klasse = "2de klas";
            this.ticket = true;
        }
    }
}
