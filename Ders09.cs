namespace AlgoritmaDersler;

public class Ders09
{
    public static int SayilarinToplami(int n)
    {
        int t =0;
        for (int i = 1; i <= n; i++)
        {
            t+=i;
        }
        return t;
    }
    public static int SayilarinFormulleToplami(int n)
    {
        return n*(n+1)/2; 
    }
    

}
