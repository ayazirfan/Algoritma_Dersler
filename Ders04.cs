namespace AlgoritmaDersler;

public class Ders04
{
    public enum Renkler { Kirmizi, Yesil, Mavi}
    
    public static void Anakod()
    {
        Renkler r = (Renkler)(new Random()).Next(0,10);
        System.Console.WriteLine(r);

        switch (r)
        {
            case Renkler.Kirmizi:
                System.Console.WriteLine("Renk Kırmızı'dır.");
            break;
            case Renkler.Yesil:
                System.Console.WriteLine("Renk Yesil'dir.");
            break;
            case Renkler.Mavi:
                System.Console.WriteLine("Renk Mavi'dir");
            break;
            default:
            System.Console.WriteLine("Renk Bilinmiyor.");
            break;
            
        }

    }

}
