using System;

namespace Trein
{
    class Program
    {
        static void Main(string[] args)
        {
            Trein trein = new Trein();
            Wagon wagon = new TweedeKlasWagon();
            trein.WagonKoppelen(wagon);
            Station Goes = new Station("Goes");
            Goes.TreinArriveert(trein);

            Reiziger Piet = new EersteKlasReiziger("Vlissingen");
            Reiziger Jan = new TweedeKlasReiziger("Vlissinge");
            Reiziger Job = new TweedeKlasReiziger("Vlissingen");
            Reiziger Henk = new TweedeKlasReiziger("Vlissingen");
            Reiziger Kwik = new TweedeKlasReiziger("Vlissingen");
            Reiziger Kwek = new TweedeKlasReiziger("Vlissingen");
            Reiziger Kwak = new ZwartReider("Middelburg");
            Goes.Instappen(Piet, Jan, Job, Henk, Kwik, Kwek, Kwak);

            Goes.TreinVertrekt();

            Station Arnemuiden = new Station("Arnemuiden");
            Arnemuiden.TreinArriveert(trein);
            Wagon wagon2 = new TweedeKlasWagon();
            trein.WagonKoppelen(wagon2);
            Reiziger Kees = new TweedeKlasReiziger("Vlissingen-Souburg");
            Reiziger Jordy = new TweedeKlasReiziger("Vlissingen-Souburg");
            Arnemuiden.TreinVertrekt();

            trein.TicketControleren();

            Station Middelburg = new Station("Middelburg");
            Middelburg.TreinArriveert(trein);
        }
    }
}
