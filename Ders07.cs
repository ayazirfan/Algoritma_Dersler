namespace AlgoritmaDersler;

public class Ders07
{
    public static bool AsalMi(int n)
    {
        if (n<=1)
        {
            System.Console.WriteLine("En küçük asal sayı 2'dir. ");
            return false;
        }
        bool kontrol = true;
        for (int i = 2; i < n; i++)
        
            if (n%i==0)
            {
                kontrol = false;
                break;
            }
            return kontrol;
    }        

}
