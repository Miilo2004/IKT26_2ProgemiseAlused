namespace ComputerLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, kalkulatsioon!");
            double calc1 = 3 + 8 / (4 - 2) * 4;
            double calc2 = 3 + 8 / 4 - 2 * 4;
            double calc3 = (3 + 8) / (4 - 2) * 4;
            double calc4 = (3.0 + 8.0) / (4.0 - 2.0) * 4.0;

            Console.WriteLine("3 + 8 / (4 - 2) * 4 = " + calc1);
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = " + calc2);
            //annab vastuseks 20 aga peaks olema 22
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calc3);
            Console.WriteLine("(3.0 + 8.0) / (4.0 - 2.0) * 4.0 = " + calc4);

        }
    }
}
