namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Endless");

            ushort counter = 1;

            for (; ; )
            {
                Console.WriteLine($"counter: {counter}");
                counter++;

                if (counter > 10)
                {
                    break;
                }
            }
        }
    }
}
