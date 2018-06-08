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
        private bool zitplaats;
        public Reiziger(string naam, string bestemming)
        {
            this.bestemming = bestemming;
            this.naam = naam;
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
        public bool GetZitplaats()
        {
            return this.zitplaats;
        }
        public bool SetZitplaats(bool zitplaats)
        {
            return this.zitplaats = zitplaats;
        }
        public override string ToString()
        {
            return this.naam;
        }
    }
}
