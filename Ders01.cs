namespace AlgoritmaDersler;

public class Ders01
{
    public static void Anakod()
    {
        int m=9;
        int n= 7;
        int p = 5;

        if (m>=n && m>=p)
        {
            System.Console.WriteLine("En büyük m");
        }
        else if (m>n && !(p>n))
        {
            System.Console.WriteLine("En büyük m");
        }
        else if (m>n || m>p)
        {
            System.Console.WriteLine("m Enküçük değil");    
        }
        m=4;
        if (!(m>=n || m>=p))
        {
            System.Console.WriteLine("m artık en küçük");
            
        }
    }


}
