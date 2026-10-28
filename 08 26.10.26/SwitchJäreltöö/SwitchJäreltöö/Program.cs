namespace SwitchJäreltöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Lahutamine");
            Console.WriteLine("2 - Meetodi kutsumine");
            Console.WriteLine("3 - Lemmik toit");

            Console.WriteLine("Vali tegevus: ");
            int valik = Convert.ToInt32(Console.ReadLine());

            switch (valik)
            {
                case 1:
                    Console.WriteLine("sisesta esimene arv: ");
                    int arv1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sisesta teine arv");
                    int arv2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tulemus: " + (arv1 - arv2));
                    break;
                case 2:
                    tere_tulemast();
                    break;
                case 3:
                    Console.WriteLine("Sisesta oma lemmik toit: ");
                    string toit = Console.ReadLine();
                    Console.WriteLine("sinu lemmik toit on: " + toit);
                    break;


                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }
        static void tere_tulemast()
        {
            Console.WriteLine("Tere tulemast");
        }
    }
}
