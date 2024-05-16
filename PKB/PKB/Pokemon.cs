namespace PKB;

public abstract class Pokemon

{
    // Fields
    public String Nickname { get; set; }
    public Energytypes Strength { get;}
    public Energytypes Weakness { get;}
        
    // Constructor
    public Pokemon(String nickname, Energytypes strength, Energytypes weakness)
    {
        Nickname = nickname;
        Strength = strength;
        Weakness = weakness;
    }
        
    //  Methoud
    public abstract void battleCry();

}