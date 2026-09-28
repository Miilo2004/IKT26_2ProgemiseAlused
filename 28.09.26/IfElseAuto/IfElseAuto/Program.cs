using System.Threading.Channels;

namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //kasutada if ja else
            //kirjuta automark
            //valikus on BMW,Audi,Porche ja Skoda
            //Kui valitakse Skoda, siis seal sees on uuesti küsimus, et
            //mis mudelit soovd valida. Mudeli valikus Kodiaq ja Octavia
            Console.WriteLine("Vali automark(valikus on BMW,Audi,Porchse ja Skoda):");
            string automark = Console.ReadLine();

            if (automark == "BMW")
            {
                Console.WriteLine("Valisid BMW");
            }
            else if (automark == "Audi")
            {
                Console.WriteLine("Valisid Audi");
            }
            else if (automark == "Porsche")
            {
                Console.WriteLine("Valisid Porsche");
            }
            else if (automark == "Skoda")
            {
                Console.WriteLine("Mis mudelit soovid (Kodiaq või Octavia)? ");
                string mudel = Console.ReadLine();
                if (mudel == "Octavia")
                {
                    Console.WriteLine("valisid Octavia");
                }
                else if  (mudel == "Kodiaq")
                {
                    Console.WriteLine("Valisid kodiaq");
                }
                else
                {
                    Console.WriteLine("See pole valikus");
                }
             
            }
            else
            {
                Console.WriteLine("Sellist marki pole.");
            }
        }

    }
}
