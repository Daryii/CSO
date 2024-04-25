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

    class Charmander
    {
        // Fields
        public String nickname { get; set; }
        public String strength { get; set; }
        public String weakness { get; set; }
        
        // Constructor
        public Charmander(String nickname, String strength, String weakness)
        {
            this.nickname = nickname;
            this.strength = strength;
            this.weakness = weakness;
        }
        
        //  Methoud
        public void battleCry()
        {
            Console.WriteLine($"{nickname} {nickname}");
        }
    }
}