namespace PKB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pokemon Battle Simulator");

            Console.WriteLine("Enter name of the first trainer: ");
            string Trainer1 = Console.ReadLine();
            Charmander pikachu = new Charmander("pikachu", "water", "fire");
            Pokeball pokeball = new Pokeball(pikachu);
            Trainer first = new Trainer(Trainer1);
            
            first.Throw();
            
            
            // Console.WriteLine("Enter name of the second trainer: ");
            // string Trainer2 = Console.ReadLine();
            // Trainer second = new Trainer(Trainer2);
            //
            
            // ash.Belt.Add(pokeball);   
            //
            // ash.Throw();
            //
            // ash.Return(pokeball);
            
            
            
           
        }
        
    }
}