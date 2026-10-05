namespace Pikkus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta pikkus:");
            int pikkus = int.Parse(Console.ReadLine());
            if (pikkus >= 40 && pikkus <= 80)
            {
                Console.WriteLine("Sinu pikkus on " + pikkus + " sentimeetrit");
            }
            else if (pikkus >= 81 && pikkus <= 130)
            {
                Console.WriteLine("Sinu pikkus on " + pikkus + " sentimeetrit");
            }
            else if (pikkus >= 131 && pikkus <= 170)
            {
                Console.WriteLine("Sinu pikkus on " + pikkus + " sentimeetrit");
            }
            else if (pikkus >= 170)
            {
                Console.WriteLine("sinu pikus on " + pikkus + " sentimeetrit");
            }
            else
            {
                Console.WriteLine("Sisesatud väärtus ei ole kehtiv");
            }

        }
    }
}
