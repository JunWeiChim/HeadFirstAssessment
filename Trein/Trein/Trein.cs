using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class Trein
    {
        private List<Wagon> wagons;
        public Trein()
        {

        }
        public void WagonKoppelen(Wagon wagon)
        {
            this.wagons.Add(wagon);
        }
        public void Instappen(Reiziger reiziger)
        {
            foreach (Wagon wagon in wagons)
            {
                if (wagon.GetKlasse() == reiziger.GetKlasse())
                {
                    wagon.Instappen(reiziger);
                    Console.WriteLine(reiziger + " is ingestapt");
                } else
                {
                    wagon.Instappen(reiziger);
                    Console.WriteLine(reiziger + " is ingestapt");
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
