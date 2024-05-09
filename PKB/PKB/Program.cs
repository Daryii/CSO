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
            for (int i = 0; i < 5; i++)
            {
                Charmander pikachu = new Charmander("pikachu", "water", "fire");
                Pokeball pokeball = new Pokeball(pikachu);
                Trainer1belt.Add(pokeball);
            }
            
            List<Pokeball> Trainer2belt = new List<Pokeball>();
            for (int i = 0; i < 5; i++)
            {
                Charmander charmander = new Charmander("charmander", "calm", "speed");
                Pokeball pokeball2 = new Pokeball(charmander);
                Trainer2belt.Add(pokeball2); 
            }
      
                        
            Trainer firstTrainer = new Trainer(TrainerName1,Trainer1belt);  
            Trainer secondTrainer = new Trainer(TrainerName2,Trainer2belt);


            while (true)
            {
                int counter = 1;
                for (int i = 0; i < 5; i++)
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