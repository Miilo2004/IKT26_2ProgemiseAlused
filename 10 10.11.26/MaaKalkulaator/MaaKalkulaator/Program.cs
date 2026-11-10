namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Meil on münt, mille diameeter on 25.75mm
            //Arvuta välja Maa ümbermõõt ja mitu münti
            //mahub järjestikku ümber maa
            //arvustuses tohib kasutada anult mündi diameetrit ja maa raadiust (6371 km)

            double diameeter = 0.02575;
            double maaraadius = 6371000;
            double maaümbermõõt = 2 * Math.PI * maaraadius;

            Console.WriteLine("Maa ümermõõt on " + maaümbermõõt);

            double mündid = maaümbermõõt / diameeter;

            Console.WriteLine("Kahe euroseid läheb ümber maa {0:0}", mündid);
        }
    }
}
