namespace TriangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk, täisnurkne kolmnurk");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta ridade arv: ");
            int i, j, rows, k = 1;
            rows = Convert.ToInt32(Console.ReadLine());

            //kasutame kahte fo loopi
            //for loop for loopi sees

            for (i = 1; i <= rows;i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
