namespace SwitchColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta värvi nimi");
            //kasutades switchi
            //sisestab värvi nime
            //Red,Green,Blue,White,yellow
            //iga värvi puhul näitab vastava värviga konsooli + tekst
            //kui sisestatakse muu värv, siis näitab "Värv puudub"
            string värv = Console.ReadLine();
            switch (värv)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valisid punase");
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vaisid rohelise");
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Valisid siise");
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Valisid valge");
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Valisid kollase");
                    break;
                default:
                    Console.WriteLine("Värv puudub");
                    break;
            }
        }
    }
}
