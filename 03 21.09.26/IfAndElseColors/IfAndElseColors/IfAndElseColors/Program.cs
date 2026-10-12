using System.Data;

namespace IfAndElseColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Teha if ja else konsoolirakendus," +
                " kus kontrollitakse stringi abil värvi vastavus");
            Console.WriteLine("V'rvide valikus on: red,blue,green ja white");
            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta " +
                "eelpool sisestatud värvi");
            Console.WriteLine("Sisestavärv (punane,sinine,roheline või valge):");
            string värv = Console.ReadLine();
            if (värv == "punane")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valisid punase.");
            }
            
            else if (värv == "roheline")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valisid rohelise");
            }
            else if (värv == "sinine")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Valisid sinise");
            }
            else if (värv == "valge")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Valisid valge");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("mingi mu värv");
            }
            
        }
    }
}
