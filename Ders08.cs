namespace AlgoritmaDersler;

public class Ders08
{
    /// <summary>
    /// Parametre olarak aldigi sayinin rakamlari toplamini doner
    /// </summary>
    /// <param name="n">sayi</param>
    /// <returns>Rakamlarin Toplamidir.</returns>
    public static int RakamlariToplami(int n)
    {
        int toplam = 0, rakam=0;
        while (n>0)
        {
            rakam = n%10;
            toplam+=rakam;
            n = n / 10;
        }
        return toplam;
    }

}
