using Microsoft.Win32.SafeHandles;
using System.ComponentModel.Design;

namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //numbri arvamise mäng

            Random random = new Random();
            int secretnumber = random.Next(1, 101);
            int guess = 0;
            int attempt = 0;

            //tuleb kasutada while, kus öeldakse,
            //kas sinu pakutud number oli suurem või väiksem
            while (guess != secretnumber)
            {
                Console.WriteLine("Pakus üks number 1-100: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    attempt++;
                    if (guess < secretnumber)
                    {
                        Console.WriteLine("Number on suurem");
                    }
                    else if (guess > secretnumber)
                    {
                        Console.WriteLine("Number on väiksem");
                    }
                    else
                    {
                        Console.WriteLine($"arvasid numbri ära! Number oli {secretnumber}");
                    }
                }
                else
                {
                    Console.WriteLine("Palun sisesta number uuesti");
                }

            }
        }
    
    }
}
