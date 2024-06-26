﻿using System;
using System.Collections.Generic;

namespace PKB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pokemon Battle Simulator");

            Console.WriteLine("Enter name of the first trainer: ");
            string TrainerName1 = Console.ReadLine();

            Console.WriteLine("Enter name of the second trainer: ");
            string TrainerName2 = Console.ReadLine();

            List<Pokeball> Trainer1belt = new List<Pokeball>();
            for (int i = 0; i < 2; i++)
            {
                Bulbasaur bulbasaur = new Bulbasaur("Bulbasaur", Energytypes.Grass, Energytypes.Fire);
                Pokeball pokeballB = new Pokeball(bulbasaur);
                Trainer1belt.Add(pokeballB);

                Charmander charmander = new Charmander("Charmander", Energytypes.Fire, Energytypes.Water);
                Pokeball pokeballC = new Pokeball(charmander);
                Trainer1belt.Add(pokeballC);

                Squirtle squirtle = new Squirtle("Squirtle", Energytypes.Water, Energytypes.Leaf);
                Pokeball pokeballS = new Pokeball(squirtle);
                Trainer1belt.Add(pokeballS);
            }

            List<Pokeball> Trainer2belt = new List<Pokeball>();
            for (int i = 0; i < 2; i++)
            {
                Squirtle squirtle = new Squirtle("Squirtle", Energytypes.Water,Energytypes.Leaf);
                Pokeball pokeballS = new Pokeball(squirtle);
                Trainer2belt.Add(pokeballS);

                Charmander charmander = new Charmander("Charmander", Energytypes.Fire,Energytypes.Water);
                Pokeball pokeballC = new Pokeball(charmander);
                Trainer2belt.Add(pokeballC);

                Bulbasaur bulbasaur = new Bulbasaur("Bulbasaur", Energytypes.Grass, Energytypes.Water);
                Pokeball pokeballB = new Pokeball(bulbasaur);
                Trainer2belt.Add(pokeballB);
            }

            Trainer firstTrainer = new Trainer(TrainerName1, Trainer1belt);
            Trainer secondTrainer = new Trainer(TrainerName2, Trainer2belt);

            Arena.StartBattle(firstTrainer, secondTrainer);
            Arena.DisplayScoreboard();
        }
    }
}