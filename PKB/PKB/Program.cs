namespace PKB
{
    class Program
    {
        public static String userInput;
        public static bool compare = true ;

        static void Main(string[] args)
        {
            while (compare) {
                
                Console.WriteLine("Welcome to Pokemon Battle Simulator"); 
                Console.WriteLine("Enter name: (enter q to quit)");
                userInput =  Console.ReadLine();
                Charmander Nadir = new Charmander(userInput, "fire", "water");

                if (userInput.ToLower() != "q") {
                    for (int i = 0; i < 10; i++) {
                        Nadir.battleCry();
                    } 
                } else {
                    compare = false;
                }
            }
        }
    }
}