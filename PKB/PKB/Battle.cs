using System;

namespace PKB
{
    public class Battle
    {
        public void StartBattle(Trainer firstTrainer, Trainer secondTrainer , int round)
        {
                for (int i = 0; i < round; i++) 
                {
                    Console.WriteLine($"Round {i + 1}");

                    // Trainer 1 throws a Pokeball
                    Pokeball pokeball1 = firstTrainer.Throw();
                    Pokemon pokemon1 = pokeball1.GetCharmander();
                    Console.WriteLine($"{firstTrainer.TrainerName} sends out {pokemon1.Nickname}");

                    // Trainer 2 throws a Pokeball
                    Pokeball pokeball2 = secondTrainer.Throw();
                    Pokemon pokemon2 = pokeball2.GetCharmander();
                    Console.WriteLine($"{secondTrainer.TrainerName} sends out {pokemon2.Nickname}");

                    // Determine the winner of the round based on the rock-paper-scissors style
                    string winner = DetermineWinner(pokemon1, pokemon2);
                    if (winner == firstTrainer.TrainerName)
                    {
                        Console.WriteLine($"{pokemon1.Nickname} wins!");
                        secondTrainer.ReturnPo(pokeball2); // Return losing Pokemon to its Pokeball
                    }
                    else if (winner == secondTrainer.TrainerName)
                    {
                        Console.WriteLine($"{pokemon2.Nickname} wins!");
                        firstTrainer.ReturnPo(pokeball1); // Return losing Pokemon to its Pokeball
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!");
                        firstTrainer.ReturnPo(pokeball1); // Return both Pokemon to their respective Pokeballs
                        secondTrainer.ReturnPo(pokeball2);
                    }

                }
        }
        private string DetermineWinner(Pokemon pokemon1, Pokemon pokemon2)
        {
            // Determine the winner based on the rock-paper-scissors style
            if ((pokemon1.Strength == Energytypes.Fire && pokemon2.Strength == Energytypes.Grass) ||
                (pokemon1.Strength == Energytypes.Grass && pokemon2.Strength == Energytypes.Water) ||
                (pokemon1.Strength == Energytypes.Water && pokemon2.Strength == Energytypes.Fire))
            {
                return $"{pokemon1} has Won!";
            }
            else if ((pokemon2.Strength == Energytypes.Fire && pokemon2.Strength == Energytypes.Grass) ||
                     (pokemon2.Strength == Energytypes.Grass && pokemon2.Strength == Energytypes.Water) ||
                     (pokemon2.Strength == Energytypes.Water && pokemon2.Strength == Energytypes.Fire))
            {
                return $"{pokemon2} has Won!";
            }
            else
            {
                return "Draw";
            }
        }
    }
}