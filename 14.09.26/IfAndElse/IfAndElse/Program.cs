namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi");

            //siin on muutuja nimega name, mis on tüübiga string
            //oeb andmeid konsoolist ja salvestab
            //need muutuja name sisse
            string name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine("Tere," + name);
            }
            else
            {
                Console.WriteLine("Tere, tundmatu! ERROR");
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
        }
    }
}