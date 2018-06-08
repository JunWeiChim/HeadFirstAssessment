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
            reiziger.SetZitplaats(true);
            this.zitplaatsen.Add(reiziger);
            Console.WriteLine(reiziger + " is ingestapt met bestemming " + reiziger.GetBestemming());
        }
        public void Uitstappen(Reiziger reiziger)
        {
            reiziger.SetZitplaats(false);
            this.zitplaatsen.Remove(reiziger);
            Console.WriteLine(reiziger + " is uitgestapt");
        }
        public string GetKlasse()
        {
            return this.klasse;
        }
        public List<Reiziger> GetReizigers()
        {
            return this.zitplaatsen;
        }
        public void TicketControleren()
        {
            for (int i = 0; i < zitplaatsen.Count; i++)
            {
                if (zitplaatsen[i].TicketControleren() == false)
                {
                    Console.WriteLine(zitplaatsen[i].GetNaam() + " heeft geen ticket");
                    Uitstappen(zitplaatsen[i]);
                }
            }
        }
    }
}
