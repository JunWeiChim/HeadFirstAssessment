using System;
using System.Collections.Generic;
using System.Text;

namespace Trein
{
    class Station
    {
        private Trein trein;
        private string locatie;
        public Station(string locatie)
        {
            this.locatie = locatie;
        }
        public void TreinArriveert(Trein trein)
        {
            this.trein = trein;
        }
        public void TreinVertrekt()
        {
            this.trein = null;
        }
        public Trein CheckTrein()
        {
            return this.trein;
        }
        public void Instappen(Reiziger reiziger, Reiziger reiziger2, Reiziger reiziger3, Reiziger reiziger4, Reiziger reiziger5, Reiziger reiziger6, Reiziger reiziger7)
        {
            trein.Instappen(reiziger);
            trein.Instappen(reiziger2);
            trein.Instappen(reiziger3);
            trein.Instappen(reiziger4);
            trein.Instappen(reiziger5);
            trein.Instappen(reiziger6);
            trein.Instappen(reiziger7);
        }
    }
}
