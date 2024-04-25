namespace PKB;

public class Pokeball
{
    public Charmander Daryi = new Charmander("Daryi", "Losing", "success");

    public void thrown()
    {
        Console.WriteLine($"{Daryi.nickname} Throwed!!!");
    }

    public void opensItUp()
    {
        Console.WriteLine($"{Daryi.nickname} opens It Up!!!");
    }

    public void releases()
    {
        Console.WriteLine($"Relesases {Daryi.nickname}");
    }

    public void returnn()
    {
    }

}