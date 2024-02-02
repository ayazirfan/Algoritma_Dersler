namespace AlgoritmaDersler;

public class Ders10
{
    public static int TekSayilarinToplami(int n)
    {
        int t = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 1 )
            {
                t += i;
            }
        }

        return t;
    }

    public static int TekSayilarinToplamiAlternatif(int n)
    {
        int t = 0;
        for (int i = 1; i <= n; i+=2)
        {
            t+=i;
        }
        return t;
    }

    public static int TekSayilarinToplamiFormul(int n)
    {
        n = n+1;
        n = n/2;
        return n*n;
    }

}
