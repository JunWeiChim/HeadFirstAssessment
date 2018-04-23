using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    abstract class Wagon
    {
        protected List<Reiziger> zitplaatsen;
        protected string klasse;
        public void Instappen(Reiziger reiziger)
        { 
            this.zitplaatsen.Add(reiziger);
        }
        public void Uitstappen(Reiziger reiziger)
        {
            this.zitplaatsen.Remove(reiziger);
        }
        public string GetKlasse()
        {
            return this.klasse;
        }
        public void TicketControleren()
        {
            foreach (Reiziger reiziger in zitplaatsen)
            {
                if (reiziger.TicketControleren() == false) Uitstappen(reiziger);
            }
        }
    }
}
