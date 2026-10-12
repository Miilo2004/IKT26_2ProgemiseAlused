namespace IfAndElseFoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta jalanumber:");
            int jalanumber = int.Parse(Console.ReadLine());
            if (jalanumber >= 30 && jalanumber <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sinu jalanumber on 30-33.");
            }
            else if (jalanumber >= 34 && jalanumber <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Sinu jalanmber on 34-38");
            }
            else if (jalanumber >= 39 && jalanumber <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sin jalanumber on 39-44");
            }
            else if (jalanumber >= 45 && jalanumber <= 48)
            {
                Console.WriteLine("sinu jalanumber on 45-48");
                Console.Beep();
            }
            else
            {
                Console.WriteLine("Sinu jalanumber ei ole meie andmebaasis");
            }
        }
    }
}
