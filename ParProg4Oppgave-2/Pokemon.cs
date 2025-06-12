namespace ParProg4Oppgave_2;

public class Pokemon
{
    public string Name { get; }
    public string Type { get; }
    public int Health { get; }
    public int Level { get; }
    
    public Pokemon(string name, string type, int health, int level)
    {
        Name = name;
        Type = type;
        Health = health;
        Level = level;
    }

    public override string ToString() => $"{Name} {Type} {Health} {Level}";
}