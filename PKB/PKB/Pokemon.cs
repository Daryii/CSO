namespace PKB;

public abstract class Pokemon

{
        // Fields
        public String nickname { get; set; }
        public String strength { get; set; }
        public String weakness { get; set; }
        
        // Constructor
        public Pokemon(String nickname, String strength, String weakness)
        {
            this.nickname = nickname;
            this.strength = strength;
            this.weakness = weakness;
        }
        
        //  Methoud
        public abstract void battleCry();

}