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

            Reiziger Piet = new EersteKlasReiziger("Piet", "Vlissingen");
            Reiziger Jan = new TweedeKlasReiziger("Jan", "Vlissingen");
            Reiziger Job = new TweedeKlasReiziger("Job", "Vlissingen");
            Reiziger Henk = new TweedeKlasReiziger("Henk", "Vlissingen");
            Reiziger Kwik = new TweedeKlasReiziger("Kwik", "Vlissingen");
            Reiziger Kwek = new TweedeKlasReiziger("Kwek", "Vlissingen");
            Reiziger Kwak = new ZwartRijder("Kwak", "Middelburg");
            Goes.Instappen(Piet, Jan, Job, Henk, Kwik, Kwek, Kwak);

            Goes.TreinVertrekt();

            Station Arnemuiden = new Station("Arnemuiden");
            Arnemuiden.TreinArriveert(trein);
            Wagon wagon2 = new EersteKlasWagon();
            trein.WagonKoppelen(wagon2);
            Reiziger Kees = new TweedeKlasReiziger("Kees", "Vlissingen-Souburg");
            Reiziger Jordy = new TweedeKlasReiziger("Jordy", "Vlissingen-Souburg");
            trein.Instappen(Kees);
            trein.Instappen(Jordy);
            Arnemuiden.TreinVertrekt();

            trein.TicketControleren();

            Station Middelburg = new Station("Middelburg");
            Middelburg.TreinArriveert(trein);
            trein.Uitstappen();
            Reiziger Jeroen = new EersteKlasReiziger("Jeroen", "Vlissingen");
            Middelburg.TreinVertrekt();

            Station VlissingenSouburg = new Station("Vlissingen-Souburg");
            VlissingenSouburg.TreinArriveert(trein);
            trein.Uitstappen();
            VlissingenSouburg.TreinVertrekt();

            Console.Read();
        }
    }
}
