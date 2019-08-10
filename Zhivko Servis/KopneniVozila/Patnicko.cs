namespace Zhivko_Servis
{
    public class Patnicko : KopnenoVozilo
    { 
        public Patnicko() : base()
    {

    }

    public Patnicko(string tipNaGorivo) : base(tipNaGorivo)
    {
    }
    public Patnicko(string tipNaGorivo, int kapacitetNaRezervoar) : base(tipNaGorivo, kapacitetNaRezervoar)
    {
    }

    public Patnicko(string tipNaGorivo,
                            int kapacitetNaRezervoar,
                            int potrosuvackaNa100,
                            int cena,
                            string boja,
                            int godinaNaProizvodstvo,
                            string problem) :
        base(tipNaGorivo, kapacitetNaRezervoar, potrosuvackaNa100, cena, boja, godinaNaProizvodstvo, problem)
    {
    }
    public new int MomentalnaVrednost(int cena, int godinaNaProizvodstvo, int potrosuvacka)
    {
        int momentalnaVrednost = cena - (2 * (cena - (godinaNaProizvodstvo / 100) * potrosuvacka));
        return momentalnaVrednost;
    }

    }
}