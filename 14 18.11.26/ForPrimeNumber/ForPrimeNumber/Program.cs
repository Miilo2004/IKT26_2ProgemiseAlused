using System.Security.Cryptography;

namespace ForPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number: ");

            //sisestad algarvu
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = number > 1;

            //for loopiga käib kontroll, kas on siis algarv
            //if ja else annavad vastuse, kas o algarv või mitte
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"Arv {number} on algarv");
            }
            else
            {
                Console.WriteLine($"Arv {number} ei ole algarv");
            }
        }
        

    }
}
