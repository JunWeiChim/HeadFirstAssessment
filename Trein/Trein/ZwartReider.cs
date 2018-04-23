using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class ZwartReider : Reiziger
    {
        public ZwartReider(string bestemming) : base(bestemming)
        {
            this.ticket = false;
        }
    }
}
