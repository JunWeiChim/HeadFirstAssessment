using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class EersteKlasReiziger : Reiziger
    {
        public EersteKlasReiziger(string bestemming) : base(bestemming)
        {
            this.klasse = "1ste klas";
            this.ticket = true;
        }
    }
}
