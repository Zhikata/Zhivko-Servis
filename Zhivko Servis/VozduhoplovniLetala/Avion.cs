namespace Zhivko_Servis
{
    public class Avion : VozduhoplovnoVozilo
    {
        public int KapacitetNaPatnici { get; set; }

        public new int MomentalnaVrednost(int cena, int godinaNaProizvodstvo, int potrosuvacka)
        {
            int momentalnaVrednost = cena - (2 * (cena - (godinaNaProizvodstvo / 100) * potrosuvacka));
            return momentalnaVrednost;
        }
     }
}