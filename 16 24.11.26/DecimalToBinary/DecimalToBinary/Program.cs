using System.Numerics;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal To Binary");

            Console.WriteLine("Sisesta number: ");

            //tuleb kasutada while
            int num = Convert.ToInt32(Console.ReadLine());
            string BinaryNumber = "";

            while (num > 0)
            {
                int reminder = num % 2;
                BinaryNumber = reminder + BinaryNumber;
                num /= 2;
            }
            Console.WriteLine(BinaryNumber);
        }
    }
}
