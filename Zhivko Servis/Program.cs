using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhivko_Servis
{

    partial class Program
    {
        static void Main(string[] args)
        {

            //TipNaGorivo
            //KapacitetNaRezervoar 
            //PotrosuvackaNa100 
            //Cena 
            //Boja 
            //GodinaNaProizvodstvo
            //Problem 
            var car = new KopnenoVozilo();

            List<Vozilo> vozenPark = new List<Vozilo>()
            {
                 new AvtomobilObicen("Dizel", 50 , 6 , 13000 , "Crna" , 1995 , "Kocnici" ),
                 new AvtomobilSportski("Benzin", 80 , 9 , 35000 , "Bela" , 2003 , "Nema" ),
                 new Kamion("Dizel", 150 , 15 , 70000 , "Zolta" , 2010 , "Nema" ),
                 new KopnenoVozilo("x", 0 , 0 , 0 , "" , 1990 , " " ),
                 new Patnicko("x", 0 , 0 , 0 , "" , 1990 , " " ),
                 new PatnickoKombe("Benzin", 90 , 11 , 20000 , "Srebrena" , 1989 , "Menuvac" ),
                 new Sedan("Benzin", 75 , 7 , 35000 , "Bela" , 2019 , "Klima" ),
                 new Tovarno("x", 0 , 0 , 0 , "" , 1990 , " " ),
                 new TovarnoKombe("Dizel", 100 , 12 , 30000 , "Crn" , 1990 , "Pumpa" ),
                 new PomorskoVozilo("x", 0 , 0 , 0 , "" , 1990 , " " ),
                 new Jahta("Struja", 2000 , 150 , 2000000 , "Bela" , 2005 , "Nema" ),
                 new VozduhoplovnoVozilo("x", 0 , 0 , 0 , "" , 1990 , " " ),
                 new Avion("Kerozin", 500 , 90 , 1500000 , "Bela" , 2017 , "Motor" ),
            };

            foreach (var item in vozenPark)
            {
               Console.WriteLine(" ");
                item.IspecatiSpecificniKarakteristiki();
            }
            int VkupenKapacitet = 0;
            foreach (var item in vozenPark)
            {
                VkupenKapacitet += item.KapacitetNaRezervoar;

            }
            Console.WriteLine(" ");
            Console.WriteLine($" Vkupniot kapacitet na site rezervoari e {VkupenKapacitet}");
            Console.ReadLine();
        }

        public static int KonvertNaBroj(string priem1)
        {
            if (int.TryParse(priem1, out int priemKonv1))
                return priemKonv1;
            return 0;
        }

    }
}