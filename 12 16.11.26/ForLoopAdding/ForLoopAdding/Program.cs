namespace ForLoopAdding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta korduste arv");
            Console.WriteLine("--------------------");
            Console.WriteLine("\n\n");

            //eelnevaid teadmisei kasutades kirjuta programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - kill
            //kill - kill
            //jne
            //kasutada for loopi ja kasutaja saab sisestada korduse arvu

            int kordus = int.Parse(Console.ReadLine());

            for (int i = 1; i <= kordus; i++)
            {
                Console.WriteLine("See on rida nr {0}", i);

                for (int k = 1; k <= 2; k++)
                {
                    Console.WriteLine("kill - koll");
                }
                Console.WriteLine("Killadi - koll");
            }
        }
    }
}
