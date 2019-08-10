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
       var car  = new KopnenoVozilo();

        List<Vozilo> vozenPark = new List<Vozilo>()
            {
                 new AvtomobilObicen("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new AvtomobilSportski("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new Kamion("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new KopnenoVozilo("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new Patnicko("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new PatnickoKombe("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new Sedan("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new Tovarno("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new TovarnoKombe("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new PomorskoVozilo("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new Jahta("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new VozduhoplovnoVozilo("", 0 , 0 , 0 , "" , 1990 , " " ),
                 new Avion("", 0 , 0 , 0 , "" , 1990 , " " ),
            };

            foreach (var item in vozenPark)
            {
                Console.WriteLine(item.KapacitetNaRezervoar);
                item.IspecatiSpecificniKarakteristiki();
            }
            foreach (var item in vozenPark)
            {
               // Da se ispecati Vkupniot kapacitet na rezervoarot za gorivo na site vozila
            }
            Console.Read();
        }

        public static int KonvertNaBroj(string priem1)
        {
            if(int.TryParse(priem1, out int priemKonv1))
                return priemKonv1;
            return 0;
        }
    }
}