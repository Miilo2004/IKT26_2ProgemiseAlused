namespace ForLoopHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            //teha konsoolirakendus, kus kastad loopi
            //kolm korda näidatakse tere tulemast reaumber
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("tere tulemast " + i);
            }
        }
    }
}
