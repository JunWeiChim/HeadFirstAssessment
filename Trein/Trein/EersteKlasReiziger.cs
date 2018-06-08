using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class EersteKlasReiziger : Reiziger
    {
        public EersteKlasReiziger(string naam, string bestemming) : base(naam, bestemming)
        {
            this.klasse = "1ste klas";
            this.ticket = true;
        }
    }
}
