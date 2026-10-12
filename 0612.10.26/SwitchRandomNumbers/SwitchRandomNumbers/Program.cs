namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühest kueni");
            //genereerib juhuslikke numbreid 1 kuni 6
            int randomnumber = new Random().Next(1, 7);
            //kasuta switchi
            //peab kontrollima tulemust ja kuvama vastavat sõnumit

            switch (randomnumber)
            {
                case 1:
                    Console.WriteLine("veeretasid ühe");
                    break;
                case 2:
                    Console.WriteLine("Veeretasid kahe");
                    break;
                case 3:
                    Console.WriteLine("Veeretasid kolme");
                    break;
                case 4:
                    Console.WriteLine("Veeretasid nelja");
                    break;
                case 5:
                    Console.WriteLine("Veeretasid viie");
                    break;
                case 6:
                    Console.WriteLine("Veeretasid kuue");
                    break;
                default:
                    Console.WriteLine("Ei saanudki numbrit");

                    break;
            }
        }
    }
}
