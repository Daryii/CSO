namespace PKB;

public class Charmander : Pokemon
{
    public Charmander(String nickname, String strength, String weakness) : base(nickname,strength,weakness)
    {
    }

    public override void battleCry()
    {
        Console.WriteLine($"{nickname} Char!");    }

}