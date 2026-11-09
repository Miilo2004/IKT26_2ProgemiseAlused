namespace Kujundikalkuaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Ruudu sees asub ring. Ringi raadius on 3 ühikut
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            double raadius = 3;
            double külg = raadius * 2;
            double pindala = külg * külg;
            double ümbermõõt = 4 * külg;

            int roundRadius = 3;
            int diameter = roundRadius * 2;

            double squarearea1 = Math.Pow(diameter, 2);
            double squarearea2 = diameter * diameter;

            double squarepermeter = diameter * 4;

            Console.WriteLine("Pindala on " + pindala);
            Console.WriteLine("Ümbermõõt on " + ümbermõõt);

            // arvuti ringi pindala ja ümbermõõt

            double roundarea1 = Math.PI * Math.Pow(roundRadius, 2);
            double roundarea2 = Math.PI * (roundRadius * roundRadius);
            double roundPerimeter = 2 * Math.PI * roundRadius;
            
            //kuidas teha, et maksimaalselt kaks kohta pärast koma oleks?
            Console.WriteLine("Ringi pindala " + roundarea1.ToString("0.##"));
            Console.WriteLine("Ringi ümbemõõt " + roundPerimeter.ToString("0.##"));
        }

    }
}
