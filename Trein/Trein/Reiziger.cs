using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class Reiziger
    {
        private string naam;
        protected bool ticket;
        private string bestemming;
        protected string klasse;
        public Reiziger(string bestemming)
        {
            this.bestemming = bestemming;
        }
        public bool TicketControleren()
        {
            return this.ticket;
        }
        public string GetNaam()
        {
            return this.naam;
        }
        public string GetBestemming()
        {
            return this.bestemming;
        }
        public string GetKlasse()
        {
            return this.klasse;
        }
    }
}
