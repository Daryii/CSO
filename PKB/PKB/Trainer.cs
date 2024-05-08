using System;
using System.Collections.Generic;

namespace PKB
{
    public class Trainer
    {
        public string TrainerName;
        public List<Pokeball> Belt;

        public Trainer(string trainerName)
        { 
            this.TrainerName = trainerName;
            this.Belt = new List<Pokeball>();
        }

        public void Throw()
        {
            if (Belt.Count == 0)
            {
                Console.WriteLine("The trainer has no Pokeballs on the belt to throw.");
                return;
            }

            Pokeball pokeball = Belt[0];
            Console.WriteLine($"{TrainerName} throws a Pokeball");
            pokeball.Open();
            pokeball.Release();
        }
        public void Return(Pokeball pokeball)
        {
            try
            {
                if (Belt.Count >= 6)
                {
                    throw new InvalidOperationException("The trainer's belt is full. Cannot add more Pokeballs.");
                }

                Charmander charmander = pokeball.GetCharmander();
                Console.WriteLine($"{charmander.nickname} returns to its Pokeball.");
                Belt.Add(pokeball); // Add the Pokeball back to the belt
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}