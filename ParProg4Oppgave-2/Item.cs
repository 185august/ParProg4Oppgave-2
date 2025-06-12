namespace ParProg4Oppgave_2;

public class Item
{
    public int Cost { get; }
    public string Name { get; }
    public string Effect { get; }

    public Item(int cost, string name, string effect)
    {
        Cost = cost;
        Name = name;
        Effect = effect;
    }
}