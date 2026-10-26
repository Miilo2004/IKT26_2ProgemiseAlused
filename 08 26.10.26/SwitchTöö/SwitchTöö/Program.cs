using System.Threading.Channels;

namespace SwitchTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            float arv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Kas soovid need omavahel korrutada? Jah või Ei");

            string tehe = (Console.ReadLine());

            Console.WriteLine("Sisesta teine number:");

            float arv2 = float.Parse(Console.ReadLine());

            float tulemus = 0;


            switch (tehe)
            {
                case "jah":
                    tulemus = arv1 * arv2;
                    break;
                case "ei":
                default:
                    Console.WriteLine("Te ei soovinud jätkata. kena päeva");
                    break;
            }

            Console.WriteLine("Tulemus: " + tulemus);
            Console.WriteLine("Kas soovid jätkata? Kui ja, siis kirjuta Vanus");
            string meetod = Console.ReadLine();
            switch (meetod)
            {
                case "vanus":
                    vanus();
                    break;
                default:
                    Console.WriteLine("Te ei soovinud jätkata. Kena päeva");
                    break;
            }
        }
        static void vanus()
        {
            Console.WriteLine("Sisesta oma vanus:");
            string vanus = Console.ReadLine();
            Console.WriteLine("Sinu vanus on: " + vanus);
            Console.WriteLine("Kui soovid vahetada meetodi peale Miau, siis kirjuta Miau");
            string meetod2 = Console.ReadLine();
            switch (meetod2)
            {
                case "Miau":
                    Miau();
                    break;
                default:
                    Console.WriteLine("Te ei soovinud meetodit vahetada head aega");
                    break;
            }
        }
        static void Miau()
        {
            Console.WriteLine("Sisenesid meetodi Miau");
        }
    }
}
