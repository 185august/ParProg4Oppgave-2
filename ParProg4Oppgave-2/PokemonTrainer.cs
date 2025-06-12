namespace ParProg4Oppgave_2;

public class PokemonTrainer
{
    public string Name { get; }
    public List<Pokemon> Pokemons { get; } = new();
    public List<Item> Items { get; } = new();
    
    public PokemonTrainer(string name)
    {
        Name = name;
    }
    
    public void AddPokemon(Pokemon pokemon)
    {
        Pokemons.Add(pokemon);
    }

    public void AddItem(Item item)
    {
        Items.Add(item);   
    }
}