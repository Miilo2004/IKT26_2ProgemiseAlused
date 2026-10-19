namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisesta esimene number:");

            float arv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe: *, /, +, -");

            string tehe = (Console.ReadLine());

            Console.WriteLine("Sisesta teine number:");

            float arv2 = float.Parse(Console.ReadLine());

            float tulemus = 0;

            switch (tehe)
            {
                case  "+":
                    tulemus = arv1 + arv2;
                    break;
                case "-":
                    tulemus = arv1 - arv2;
                    break;
                case "/":
                    if (arv2 == 0)
                    {
                        Console.WriteLine("Nulliga ei saa jagada");
                    }
                    else
    
                    tulemus = arv1 / arv2;
                    break;
                case "*":
                    tulemus = arv1 * arv2;
                    break;

                default:
                    Console.WriteLine("Vigane tehe!");
                    break;
            }
            Console.WriteLine("Tulemus: " + tulemus);
        }
        //nüüd tuleb teha swithi valik, kus on *, /, +, -.
        //tuleb teha case, kus toimub soovitud tehe
        //peab näitama tehte tulemust
        //kasutage floati Parsimisel
    }
}
