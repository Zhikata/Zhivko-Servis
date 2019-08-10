using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhivko_Servis
{
    public class Vozilo
    {
        public string TipNaGorivo { get => _tipNaGorivo; }
        private string _tipNaGorivo;

        public int KapacitetNaRezervoar { get; set; }
        public int PotrosuvackaNa100 { get; set; }
        public int Cena { get; set; }
        public string Boja { get; set; }
        public int GodinaNaProizvodstvo { get; set; }
        public string Problem { get; set; }

        public Vozilo()
        {
        }
        public Vozilo(string tipNaGorivo)
        {
            _tipNaGorivo = tipNaGorivo;
        }
        public Vozilo(string tipNaGorivo, int kapacitetNaRezervoar) : this(tipNaGorivo)
        {
            KapacitetNaRezervoar = kapacitetNaRezervoar;
        }

        public Vozilo(string   tipNaGorivo, 
                        int    kapacitetNaRezervoar,
                        int    potrosuvackaNa100, 
                        int    cena, 
                        string boja,
                        int    godinaNaProizvodstvo, 
                        string problem) : this(tipNaGorivo, kapacitetNaRezervoar)
        {
            PotrosuvackaNa100 = potrosuvackaNa100;
            Cena = cena;
            Boja = boja;
            GodinaNaProizvodstvo = godinaNaProizvodstvo;
            Problem = problem;

        }

        public float MaksimalenDomet(int kapacitetNaRezervoar, int potrosuvackaNa100)
        {
            float maksimalendomet = (kapacitetNaRezervoar / potrosuvackaNa100);
            return maksimalendomet;
        }

        public int MomentalnaVrednost(int cena, int godinaNaProizvodstvo, int potrosuvacka)
        {
            int momentalnaVrednost = cena - (2 * (cena - (godinaNaProizvodstvo / 100) * potrosuvacka));
            return momentalnaVrednost;
        }

        public void IspecatiSpecificniKarakteristiki()
        {

        }
    }
}
