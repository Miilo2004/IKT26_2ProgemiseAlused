using System.Net.Sockets;

namespace YesGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta sõna");

            string sõna = Console.ReadLine();

            //while ja nii kaua tsükkel kestab kuni kasutaja sisestab sõna yes

            while (sõna != "yes")
            {
                Console.WriteLine("Kirjuta sõna yes või midagi muud");
                sõna = Console.ReadLine();

            }
            Console.WriteLine("Tubi töö");
            

        }
    }
}
