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
            
            //if ja else kontrollib, kas muutuja
            //name on tühi või mitte
            //kui muutuja nimi on tühi, siis väljastab konsoolile
            //teksti "Tere, tundmatu! ERROR ja teeb 4 piiksu
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