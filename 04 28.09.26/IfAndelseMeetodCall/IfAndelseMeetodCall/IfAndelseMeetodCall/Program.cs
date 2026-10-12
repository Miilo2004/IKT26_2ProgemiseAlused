using System.Collections.Concurrent;

namespace IfAndelseMeetodCall
{
    internal class Program
    {
        //see on meetod Main
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else
            //kui kasutaja soovib, siis saab ta meetodi välja kutsuda
            Console.WriteLine("Kui soovid  meetodit välja kutsuda ,siis kirjuta ja");
            string meetod = Console.ReadLine();
            if (meetod == "ja")
            {
                //see on meetodi kutsumine,
                //kui kirjutad selle väja
              HelloMethod();
            }
            else
            {
                Console.WriteLine("Meetodit ei kutsutud välja");
            }
                
            
        }
        //tehke uus meetod nimega HelloMethod
        //kirjutage sisse kood, mis kuvab teksti Hello Kitty

        static void HelloMethod()
        {
           Console.WriteLine("HelloMethod");
        }
    }
}
