namespace PKB;

public class Squirtle : Pokemon
{
    public Squirtle(String nickname, Energytypes strength, Energytypes weakness) : base(nickname,strength,weakness)
    {
    }

    public override void battleCry()
    {
        Console.WriteLine($"{Nickname} Bulba!");
    }
}