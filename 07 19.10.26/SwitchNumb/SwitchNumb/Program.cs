namespace SwitchNumb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number:");

            //tuleb teha switch, kus esimene case on 10, teine 20 ja kolmas 30.
            //küsitakse numbrit ja sisestad knsooli

            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 10:
                    Console.WriteLine("Sisestasid 10");
                    break;
                case 20:
                    Console.WriteLine("Siestasid 20");
                    break;
                case 30:
                    Console.WriteLine("Siestasid 30");
                    break;

                default:
                    Console.WriteLine("Siestatud numbrit ei ole!");
                    break;
            }
        }
    }
}
