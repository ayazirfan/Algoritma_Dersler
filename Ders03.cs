public class Ders03
{
    public static void Anakod()
    {
        int i=23;
object o =i;

// Unboxing- Kutudan çıkarma
i*=2;
i= (int)o;
System.Console.WriteLine("Değer turu: {0}", i);
System.Console.WriteLine("Referans turu: {0}",o);
    }

}