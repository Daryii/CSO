namespace PKB;

public class Bulbasaur : Pokemon
{
    public Bulbasaur(String nickname, String strength, String weakness) : base(nickname,strength,weakness)
    {
    }

    public override void battleCry()
    {
        Console.WriteLine($"{nickname} Bulba!");    }
}