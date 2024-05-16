using System;
using System.Collections.Generic;

namespace PKB
{
    public class Trainer
    {
        public string TrainerName;
        public List<Pokeball> Belt;
        public int indexx;

        public Trainer(string trainerName, List<Pokeball> belt)
        { 
            this.TrainerName = trainerName;
            this.Belt = belt;
        }


        public Pokeball Throw()
        {
            if (indexx >= Belt.Count)
            {
                indexx = 0;
            }
            
            Pokeball pokeball = Belt[indexx];
            Console.WriteLine($"{TrainerName} throws a Pokeball");
            pokeball.Open();
            pokeball.Release();
            indexx++;
            return pokeball;

        }
        public void ReturnPo(Pokeball pokeball)
        {
            Pokemon pokemon = pokeball.GetCharmander();
            Console.WriteLine($"{pokemon.Nickname} returns to its Pokeball.");
            pokeball.Close();
        }
            
    }
    
}