using AlgoritmaDersler;

internal class Program
{
   
    private static void Main(string[] args)
    {
        
        // var mC = new SampleClass(11,22);
        // Console.WriteLine($"x={mC.x}, y={mC.y}");
        // Console.WriteLine($"C1={SampleClass.c1}, C2={SampleClass.c2}"); 
        
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
