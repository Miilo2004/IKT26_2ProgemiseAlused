using System.Numerics;

namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta auto hobujõud:");
            int hj = int.Parse(Console.ReadLine());
            if (hj >= 0 && hj <= 100)
            {
                Console.WriteLine("Sinu auto võimsus on " + hj + "hj");
            }
            else if (hj >= 101 && hj <= 150)
            {
                Console.WriteLine("Sinu auto võimsus on" + hj + " hj");
            }
            else if (hj >= 151 && hj <= 250)
            {
                Console.WriteLine("Sinu auto võimsus on" + hj + " hj");
            }
            else hj >= 251
            {
                Console.WriteLine("Sinu auto võimsus on" + hj + "");
            }


            
        }
    }
}
