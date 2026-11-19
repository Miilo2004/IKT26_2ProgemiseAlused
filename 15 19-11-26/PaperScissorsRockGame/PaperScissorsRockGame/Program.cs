namespace PaperScissorsRockGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string playerChoice = "";
            int playerPoints = 0;
            int computerPoints = 0;

            while (playerChoice == "lõpeta")
            {
                Console.WriteLine("Vali: kivi, paper või käärid.");
                Console.WriteLine("Mängu lõpetamiseks kirjuta : Lõpeta");
                //Tolower muudab sinu kirjutatud teksti väikesteks tähtedeks
                playerChoice = Console.ReadLine().ToLower();

                if (playerChoice == "lõpeta")
                {
                    break;
                }

                if (playerChoice != "kivi" &&
                        playerChoice != "paber" &&
                        playerChoice != "käärid")
                {
                    Console.WriteLine("Sellist valikut pole, Proovi uuesti.");
                    continue;
                        
                }
                int computerNumber = random.Next(1, 4);
                string computerChocice = "";

                if (computerNumber == 1)
                {
                    computerChocice = "Kivi";
                }
                else if (computerNumber == 2)
                {
                    computerChocice = "Paber";
                }
                else
                {
                    computerChocice = "Käärid";
                }

                Console.WriteLine($"Arvuti valis: {computerChocice}");

                if (playerChoice == computerChocice)
                {
                    Console.WriteLine("viik");
                }
                else if((playerChoice == "kivi" && computerChocice == "käärid") || //ctrl alt gr z
                (playerChoice == "paber" && computerChocice == "kivi") ||
                (playerChoice == "käärid" && computerChocice == "paber"))
                {
                    Console.WriteLine("sina võitsid");
                    playerPoints++;
                }
                else
                {
                    Console.WriteLine("arvuti võitis");
                    computerPoints++;
                }
                Console.WriteLine($"Punktid: sina {playerPoints} -- arvuti {computerPoints}");
                Console.WriteLine();
            }

            Console.WriteLine("Mäng on läbi.");
            Console.WriteLine($"Lõpptulemus: {playerPoints} arvuti -- {computerPoints}");
        }
    }
}
