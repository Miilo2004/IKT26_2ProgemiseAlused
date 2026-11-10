namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb kasutada while ja omakorda while sisse panna while
            //while nestig
            //while kordab ennast 5 korda
            int a = 1;
            while (a <= 5)
            {
                //uus while kordab ennast 5 korda
                int b = 1;
                while (b <= 5) 
                {
                    Console.WriteLine(" *");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}
