namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta number 0-300");
            //esimese koondtulemuse puhul on number vahemikus
            //0 kuni 100
            //teise puhul 101 kuni 200
            //ja kolmanda puhul 201 kuni 300
            //kasutada switchi
            //parsige tähemärk numbriks
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case >= 0 and <= 100:

                    Console.WriteLine("Valsid: " + number);
                    break;
                case >= 101 and <= 200:
                    Console.WriteLine("Valisid: " + number);
                    break;
                case >= 201 and <= 300:
                    Console.WriteLine("Valisid: " + number);
                    break;
                default:
                    Console.WriteLine("Valisid midagi muud: " + number);
                    break;
            }
        }
    }
}
