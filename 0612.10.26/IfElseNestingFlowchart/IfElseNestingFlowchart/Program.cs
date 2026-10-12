namespace IfElseNestingFlowchart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja Else nesting");
            string input = Console.ReadLine();

            if (input == "auto")
            {
                Console.WriteLine("Sisesta auto suurus");
                string size = Console.ReadLine();
                if (size == "sedaan")
                {
                    Console.WriteLine("Valisid sedaan");
                }
                else if (size == "kabrioleti")
                {
                    Console.WriteLine("valisid kabrioleti");
                }
                else
                {
                    Console.WriteLine("valisid mu auto");
                }
            }
            else
            {
                Console.WriteLine("Valisid muu sõiduki");
            }
            }
        }
    }
}
