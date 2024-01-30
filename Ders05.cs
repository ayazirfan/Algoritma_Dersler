namespace AlgoritmaDersler;

public class Ders05
{
    public static void Anakod()
    {
        Random rnd = new Random();
       int caseSwitch = rnd.Next(1,4);
       System.Console.WriteLine(caseSwitch);

       switch (caseSwitch)
       {
        case 1:
        System.Console.WriteLine(" Durum 1");
        break;
        case 2:
        case 3:
        System.Console.WriteLine($"Case {caseSwitch}");
        break;
        default:
        System.Console.WriteLine($"Beklenmeyen durum {caseSwitch} ");
        break;
       }
    }

}
