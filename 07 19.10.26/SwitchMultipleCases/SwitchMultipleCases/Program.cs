namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple cases!");

            string input = Console.ReadLine();

            switch (input)
            {
                case "intro to C#" or "Variables" or "Data Types":
                    Console.WriteLine("Basic");
                    break;

                case "OOP" or "classes" or "Objects":
                    Console.WriteLine("intermediate");
                    break;
                case "Asynchronous Programming" or "LINQ" or "Delegates":
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Unknown course");
                    break;
            }
        }
    }
}
