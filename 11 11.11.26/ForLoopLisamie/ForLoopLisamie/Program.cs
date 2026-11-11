namespace ForLoopLisamie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täisarvude kokku litmine kuni kümneni");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n");

            int summa = 0;

            for (int i = 1; i <= 10; i++)
            {
                summa = summa + i;
                Console.WriteLine("Summa on: " + summa);
            }
        }
    }
}
