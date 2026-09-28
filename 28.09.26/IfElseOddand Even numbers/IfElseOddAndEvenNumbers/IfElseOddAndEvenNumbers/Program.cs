namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Kirjuta number:");
            string tekst = Console.ReadLine();
            //konsool küsib numbrit
            //number tuleb ära parsida
            //if ja else juures toimub kontroll, et
            //kas on paaris või paaritu number
            int number = int.Parse(tekst);
            if (number % 2 == 0)
                //mida % tähendab, see leib jäägi ja
                //nii kaua kontrollib, kas on 0    
            {
                paaris();
            }
            else
            {
                paaritu();
            }
            //kutsuda paarisarv ja paarituarvu tekst välja
            //läbi meetodi kutsumise
        }
        static void paaris()
        {
            Console.WriteLine("Paaris");
        }
        static void paaritu()
        {
            Console.WriteLine("Paaritu");
        }
    }
}
