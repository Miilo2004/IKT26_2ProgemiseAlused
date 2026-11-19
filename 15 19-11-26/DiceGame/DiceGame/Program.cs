namespace ForDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringumäng");

            Random random = new Random();

            int player = 0;
            int pc = 0;

            for (int round = 1; round <= 5; round++)
            {
                Console.WriteLine($"Voor {round}. Vajuta Enter, et täringut veeretada");
                Console.ReadLine();

                int playerroll = random.Next(1, 7);
                int pcroll = random.Next(1, 7);

                Console.WriteLine($"Sinu number: {playerroll}");
                Console.WriteLine($"Arvuti number: {pcroll}");

                if (playerroll > pcroll)
                {
                    Console.WriteLine("Sina võitsid vooru!");
                    player++;
                }
                else if (pcroll > playerroll)
                {
                    Console.WriteLine("arvuti võitis vooru!");
                    pc++;
                }
                else
                {
                    Console.WriteLine("Voor jäi viiki!");
                }
            }
            Console.WriteLine("Mäng läbi!");
            if (player > pc)
            {
                Console.WriteLine("Sina võitsid kogu mängu");
            }
            else if (pc > player)
            {
                Console.WriteLine("Arvuti võitis kogu mängu");
            }
            else
            {
                Console.WriteLine("Kogu mäng jäi viiki");
            }
        }
    }
}
