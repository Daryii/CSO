namespace PKB;

public class Charmander
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