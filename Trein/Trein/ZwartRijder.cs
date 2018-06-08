using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class ZwartRijder : Reiziger
    {
        public ZwartRijder(string naam, string bestemming) : base(naam, bestemming)
        {
            this.ticket = false;
        }
    }
}
