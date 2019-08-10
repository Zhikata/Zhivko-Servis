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
            //Console.WriteLine("Dobredojdovte vo servisot na Zhivko ! Posluzete se so naseto meni za poveke informacii !! ");
            //int brojac = 1;

            //while (brojac == 1)
            //{
            //    Console.WriteLine("1) Vnes na vozilo");
            //    Console.WriteLine("2) Pregled na veke vneseno vozilo");
            //    Console.WriteLine("3) Izlez");


            //    string priem = Console.ReadLine();
            //    int priemKonv = 0;



            //    KonvertNaBroj(priem, priemKonv);
            //    if (KonvertNaBroj(priem, priemKonv) == 1)
            //    {

            //        Console.Clear();
            //        Console.WriteLine("Tip na Vozilo ");
            //        Console.WriteLine("1) Kopneno");
            //        Console.WriteLine("2) Vodeno");
            //        Console.WriteLine("3) Vozdusno");


            //        string tipNaVozilo = Console.ReadLine();
            //        if(KonvertNaBroj(tipNaVozilo, priemKonv) == 1)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Kakvo e Kopnenoto Vozilo? ");
            //            Console.WriteLine("1) Patnicko");
            //            Console.WriteLine("2) Tovarno");

            //            string kopnenoVozilo = Console.ReadLine();


            //            if (KonvertNaBroj(kopnenoVozilo, priemKonv) == 1)
            //            {

            //                Console.Clear();
            //                Console.WriteLine("Kakvo e Kopnenoto Patnicko Vozilo? ");
            //                Console.WriteLine("1) Avtomobil Obicen");
            //                Console.WriteLine("2  Avtomobil Sportski");
            //                Console.WriteLine("")


            //            }


        }
        int KonvertNaBroj(string priem1, int priemKonv1)
        {

            int.TryParse(priem1, out priemKonv1);
            return priemKonv1;

        }
    }
    class KopnenoVozilo
    {
        public string Patnicko { get; set; }
        public string Tovarno { get; set; }



    }
}