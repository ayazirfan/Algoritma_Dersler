namespace AlgoritmaDersler;

public class Ders11
{
    public static int CiftsayilarinToplami(int n)
    {
        int t = 0;
        for (int i = 2; i <= n; i++)
        {
            if (i%2==0)
            {
                t+=i;
            }
            
        }
        return t;
    }
    public static int CiftsayilarinToplamiAlternatif(int n)
    {
        int t = 0;
        for (int i = 2; i <=n; i+=2)
            t+=i;
        return t;           
    }

    public static int CiftsayilarinToplamiFormul(int n)
    {
        n = n/2;
        n= n*(n+1);
        return n;
    }


}
