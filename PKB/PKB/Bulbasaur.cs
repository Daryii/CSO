namespace PKB;

public class Bulbasaur : Pokemon
{
    public Bulbasaur(String nickname, Energytypes strength, Energytypes weakness) : base(nickname,strength,weakness)
    {
    }

    public override void battleCry()
    {
        Console.WriteLine($"{Nickname} Bulba!");    }
}