namespace IfandElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Teise if- sisse pane if ja else");

            double banaan1 = 300;

            if (banaan1 == 67)
            {
                if (banaan1 == 6)
                {

                    Console.WriteLine("Hehe, funny");
                }
                else
                {
                    Console.WriteLine("Vastus on midagi muud");
                }
            }
            else if (banaan1 == 57)
            {
                Console.WriteLine("Vastus o 57");
            }
            else if (banaan1 == 45)
            {
                Console.WriteLine("Vastus on 45");
            }
            else
            {
                Console.WriteLine("Midagi imelikku!");
            }
        }
    }
}
