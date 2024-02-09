using System.Net.NetworkInformation;
using AlgoritmaDersler;

internal class Program
{
   
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Lütfen bir sayı giriniz: ");
        // int n = Convert.ToInt32(Console.ReadLine());
        double r = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Alan = {0:F2}", Daire.AlaniHesapla(r,60));

        System.Console.WriteLine("Lütfen bir sayı giriniz: ");
        int tekToplam=0, ciftToplam = 0;
        int limit = Convert.ToInt32(Console.ReadLine());
       
       System.Console.WriteLine("Tek sayılar:");
       for (int i = 1; i < limit; i+=2)
       {
        System.Console.Write("{0,5}",i);
        tekToplam+=i;
       }
       System.Console.WriteLine("\n\nÇift sayılar:");
        for (int i = 2; i < limit; i+=2)
       {
        System.Console.Write("{0,5}",i);
        ciftToplam+=i;
       }

       System.Console.WriteLine("\n\n Tek Toplam : {0,5} \n Çift Toplam : {1,5}", tekToplam ,ciftToplam);

       int sayilarinKaresi=0;
       for (int i = 0; i < 100; i++)
       {
        System.Console.Write("{0,5}",i*i);
       }

       System.Console.WriteLine(" Beşin katı olan sayılar:");

       int sayac =0;
       for (int i = 1000; i >0; i-=5)
       {
        System.Console.Write("{0,5}",i);
        sayac++;
       }
       System.Console.WriteLine("\nBeşin katı {0} adet sayı vardır.",sayac);

       
       for (int i = 1; i < 11; i++)
       {
        
        for (int j = 1; j < 11; j++)
        {
            
            System.Console.Write("\n{0}x{1,3} = {2,5}",i,j,i*j);
        }
        System.Console.WriteLine("\n--------------------");
       }
    

        
    }
 
}
