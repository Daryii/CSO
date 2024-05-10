using System;
using System.Collections.Generic;

namespace PKB
{
    public class Trainer
    {
        public string TrainerName;
        public List<Pokeball> Belt;

        public Trainer(string trainerName, List<Pokeball> belt)
        { 
            this.TrainerName = trainerName;
            this.Belt = belt;
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
            Charmander charmander = pokeball.GetCharmander();
            Console.WriteLine($"{charmander.nickname} returns to its Pokeball.");
            Belt.Add(pokeball);
        }
            
    }
    
}