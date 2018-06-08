using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class Trein
    {
        private List<Wagon> wagons;
        private string locatie;
        public Trein()
        {
            this.wagons = new List<Wagon>();
        }
        public void WagonKoppelen(Wagon wagon)
        {
            this.wagons.Add(wagon);
        }
        public string GetLocatie()
        {
            return this.locatie;
        }
        public void SetLocatie(string locatie)
        {
            this.locatie = locatie;
        }
        public void Instappen(Reiziger reiziger)
        {
            foreach (Wagon wagon in wagons)
            {
                if (reiziger.GetZitplaats() == false)
                {
                    if (wagon.GetKlasse() == reiziger.GetKlasse())
                    {
                        wagon.Instappen(reiziger);
                    } else
                    {
                        wagon.Instappen(reiziger);
                    }
                }
                
            }
        }
        public void Uitstappen()
        {
            foreach (Wagon wagon in wagons)
            {
                for (int i = 0; i < wagon.GetReizigers().Count; i++)
                {
                    if (this.locatie == wagon.GetReizigers()[i].GetBestemming())
                    {
                        wagon.Uitstappen(wagon.GetReizigers()[i]);
                    }
                }
            }
        }
        public void TicketControleren()
        {
            foreach (Wagon wagon in wagons)
            {
                wagon.TicketControleren();
            }
        }
    }
}
