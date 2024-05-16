namespace PKB;

public class Charmander : Pokemon
{
    public Charmander(String nickname, Energytypes strength, Energytypes weakness) : base(nickname,strength,weakness)
    {
    }

    public override void battleCry()
    {
        Console.WriteLine($"{Nickname} Char!");    }

}