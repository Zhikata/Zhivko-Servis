namespace Zhivko_Servis
{
    public class AvtomobilObicen : KopnenoVozilo
    {
        public int EmisijaNaGasovi { get; }
        private int _emisijaNaGasovi;
        public AvtomobilObicen(): base()
        {

        }

        public AvtomobilObicen(string tipNaGorivo): base(tipNaGorivo)
        {
        }
        public AvtomobilObicen(string tipNaGorivo, int kapacitetNaRezervoar) : base(tipNaGorivo , kapacitetNaRezervoar)
        {
        }

        public AvtomobilObicen(string tipNaGorivo,
                                int kapacitetNaRezervoar,
                                int potrosuvackaNa100,
                                int cena,
                                string boja,
                                int godinaNaProizvodstvo,
                                string problem): 
            base(tipNaGorivo, kapacitetNaRezervoar, potrosuvackaNa100, cena , boja , godinaNaProizvodstvo , problem)
        {
            
        }
        public AvtomobilObicen(int EmisijaNaGasovi,
                                string tipNaGorivo,
                                int kapacitetNaRezervoar,
                                int potrosuvackaNa100,
                                int cena,
                                string boja,
                                int godinaNaProizvodstvo,
                                string problem)
        {
        }
        public new int MomentalnaVrednost(int cena, int godinaNaProizvodstvo, int potrosuvacka)
        {
            int momentalnaVrednost = cena - (2 * (cena - (godinaNaProizvodstvo / 100) * potrosuvacka));
            return momentalnaVrednost;
        }


    }
}