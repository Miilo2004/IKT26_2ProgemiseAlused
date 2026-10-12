namespace ifAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");

            //peate kasutama if and else lauseid,
            //et kontrollida, kas kasutaja vanus
            //on suurem kui 18 või väikes kui 18

            //saab kasutada Convert-i ja Parse-t
            string userInput = Console.ReadLine();
            int userAge = int.Parse(userInput);

            if (userAge < 18)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("alaealine");

            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Täisealine");
                
            }
            
        }
    }
}
