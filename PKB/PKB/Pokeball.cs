using System;

namespace PKB
{
    public class Pokeball
    {
        private bool isEmpty;
        private Charmander charmander;

        public Pokeball()
        {
            isEmpty = true;
        }

        public Pokeball(Charmander charmander)
        {
            this.charmander = charmander;
            isEmpty = false;
        }

        public Charmander GetCharmander()
        {
            return charmander;
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
            Console.WriteLine($"{charmander.nickname} is released from the Pokeball!");
        }
    }
}