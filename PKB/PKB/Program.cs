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
                Bulbasaur bulbasaur = new Bulbasaur("Bulbasaur", "Grass", "Ice");
                Pokeball pokeballB = new Pokeball(bulbasaur);
                Trainer1belt.Add(pokeballB);
                
                Charmander charmander = new Charmander("Charmander", "Water", "Fire");
                Pokeball pokeballC = new Pokeball(charmander);
                Trainer1belt.Add(pokeballC);
                
                Squirtle squirtle = new Squirtle("Squirtle","Water","Electric");
                Pokeball pokeballS = new Pokeball(squirtle);
                Trainer1belt.Add(pokeballS); 
            }
            
            List<Pokeball> Trainer2belt = new List<Pokeball>();
            for (int i = 0; i < 2; i++)
                
            {
                Squirtle squirtle = new Squirtle("Squirtle","Water","Electric");
                Pokeball pokeballS = new Pokeball(squirtle);
                Trainer2belt.Add(pokeballS); 
                
                Charmander charmander = new Charmander("Charmander", "Water", "Fire");
                Pokeball pokeballC = new Pokeball(charmander);
                Trainer2belt.Add(pokeballC);

                Bulbasaur bulbasaur = new Bulbasaur("Bulbasaur", "Grass", "Ice");
                Pokeball pokeballB = new Pokeball(bulbasaur);
                Trainer2belt.Add(pokeballB);
               
            }
            
            Trainer firstTrainer = new Trainer(TrainerName1,Trainer1belt);  
            Trainer secondTrainer = new Trainer(TrainerName2,Trainer2belt);


            while (true)
            {
                int counter = 1;
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"Round {i + 1}");
                    firstTrainer.Throw();
                    firstTrainer.Belt[i].GetCharmander();
                    
                    secondTrainer.Throw();
                    secondTrainer.Belt[i].GetCharmander();
                    
                    firstTrainer.Return(firstTrainer.Belt[i]);
                    secondTrainer.Return(secondTrainer.Belt[i]);
                }
                Console.WriteLine("Do you want quit? Type 'q' to quit. ");
                string continuebattle = Console.ReadLine();
                if (continuebattle.ToLower() == "q")
                {
                    break;
                }
              
            }
        }
        
    }
}