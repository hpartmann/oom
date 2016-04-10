using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Haus Regina = new Haus("Prefa", "Josko", "Josko", 5, 350000);
            Haus Sonja = new Haus("Velux", "Internorm", "Josko", 6, 450000);
            Haus Mathilde = new Haus("Bramac", "Internorm", "Eckmaier", 7, 800000);
            Eigentumswohnung Florid_Spitz = new Eigentumswohnung(92581, 70);
            Eigentumswohnung Donaust_Maculan = new Eigentumswohnung(93146, 100);
            Eigentumswohnung Brigitt_Hoech = new Eigentumswohnung(91467, 50);
            Console.WriteLine("Haustyp: Dach|Fenster|Türen|Zimmer|Preis in Euro");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Sonja: {0}|{1}|{2}|{3}|{4}", Sonja.Dach, Sonja.Fenster, Sonja.Türen, Sonja.Zimmer, Sonja.Preis);
            Console.WriteLine("Mathilde: {0}|{1}|{2}|{3}|{4}", Mathilde.Dach, Mathilde.Fenster, Mathilde.Türen, Mathilde.Zimmer, Mathilde.Preis);
            Console.WriteLine("Regina: {0}|{1}|{2}|{3}|{4}", Regina.Dach, Regina.Fenster, Regina.Türen, Regina.Zimmer, Regina.Preis);
            Regina.Zimmer = 4;
            Regina.UpdatePreis(200000);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Neue Zimmeranzahl für Haus Regina: {0}", Regina.Zimmer);
            Console.WriteLine("Neuer Preis für Haus Regina: {0}", Regina.Preis);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Regina: {0}|{1}|{2}|{3}|{4}", Regina.Dach, Regina.Fenster, Regina.Türen, Regina.Zimmer, Regina.Preis);
            Sonja.Zimmer = 3;
            Console.WriteLine("Sonja: {0}|{1}|{2}|{3}|{4}", Sonja.Dach, Sonja.Fenster, Sonja.Türen, Sonja.Zimmer, Sonja.Preis);

            var Wohnkombinationen = new IZimmerPreis[]
            {
              Regina, Sonja, Mathilde,
              Florid_Spitz, Donaust_Maculan, Brigitt_Hoech
            };

            foreach (var x in Wohnkombinationen)
            {
                Console.WriteLine($"{x} {x.AnzZimmer} {x.Preis}");
            }

            SerialDeserial.Run(Wohnkombinationen);
        }
    }
}
