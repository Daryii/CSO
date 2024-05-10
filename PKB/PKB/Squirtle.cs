namespace PKB;

public class Squirtle : Pokemon
{
    public Squirtle(String nickname, String strength, String weakness) : base(nickname,strength,weakness)
    {
    }

    public override void battleCry()
    {
       Console.WriteLine($"{nickname} Bulba!");
    }
}