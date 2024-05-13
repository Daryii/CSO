using System;

namespace PKB
{
    public class Arena
    {
        private static int roundsFought = 0;
        private static int battlesFought = 0;

        public static void StartBattle(Trainer firstTrainer, Trainer secondTrainer)
        {
            while (true)
            {
                Battle battle = new Battle();
                battle.StartBattle(firstTrainer, secondTrainer,6);
                roundsFought += 6; 
                battlesFought+= 1;
                Console.WriteLine("Do you want to quit? Type 'q' to quit.");
                string continueBattle = Console.ReadLine();
                if (continueBattle.ToLower() == "q")
                {
                    break;
                }
            }
            
            
        }

        public static void DisplayScoreboard()
        {
            Console.WriteLine("Scoreboard:");
            Console.WriteLine($"Rounds fought: {roundsFought}");
            Console.WriteLine($"Battles fought: {battlesFought}");
        }
    }
}