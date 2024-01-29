namespace AlgoritmaDersler;

public class Ders02
{

    public static void Anakod()
    {
        System.Console.WriteLine("Bir karakter giriniz:");
        char ch = (char)Console.Read();

        if (Char.IsUpper(ch))
        {
            System.Console.WriteLine("Girilen Karakter büyük bir karakterdir.");
        }
        else if (Char.IsLower(ch))
        {
            System.Console.WriteLine("Girilen Karakter küçük bir karakterdir.");
        }
        else if (Char.IsDigit(ch))
        {
            System.Console.WriteLine("Girilen Karakter bir rakamdır.");
        }
        else
        {
            System.Console.WriteLine("Girilen Karakter Alfanumerik bir ifade değildir.");     
        }

    }






}
