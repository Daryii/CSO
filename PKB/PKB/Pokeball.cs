using System;

namespace PKB
{
    public class Pokeball
    {
        private bool isEmpty;
        private Pokemon pokemon;

        public Pokeball()
        {
            isEmpty = true;
        }

        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            isEmpty = false;
        }

        public Pokemon GetCharmander()
        {
            return pokemon;
        }
        
         
        public void Open()
        {
            Console.WriteLine($"The Pokeball opens up!");
        }

        public void Close()
        {
            Console.WriteLine("The Pokeball closed up!");
        }

        public void Release()
        {
            Console.WriteLine($"{pokemon.nickname} is released from the Pokeball!");
        }
    }
}