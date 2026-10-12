using System.Numerics;

namespace IfElseRuutmeetrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta maja ruutmeetrid:");
            int rm = int.Parse(Console.ReadLine());
            if (rm >= 0 && rm <= 40)
            //esimene tingimus on alati if
            {
                Console.WriteLine("Sinu maja surus on " + rm + " ruutmeetrit");
            }
            else if (rm >= 41 && rm <= 90)
            {
                Console.WriteLine("Sinu maja suurus on " + rm + " ruutmeetrit");
            }
            else if (rm >= 91 && rm <= 130)
            {
                Console.WriteLine("Sinu maja suurus on " + rm + " ruutmeetrit");
            }
            else
            {
                Console.WriteLine("Sinu maja suurus on " + rm + "ruutmeetrit");
            }
        }
    }
}
