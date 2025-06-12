namespace ParProg4Oppgave_2;

public class PokemonGame
{
    private List<Pokemon> _staterPokemons =
    [
        new("Charmander", "Fire", 100, 1),
        new("Squirtle", "Water", 100, 1),
        new("Bulbasaur", "Grass", 100, 1)
    ];

    public void StartGame()
    {
        Console.WriteLine("Hello please type in your name");
        var name = Console.ReadLine();
        var trainer = new PokemonTrainer(name);
        Console.WriteLine("Hello " + name);
        Console.WriteLine("Please select a starter pokemon");

        int i = 1;
        foreach (var pokemon in _staterPokemons)
        {
            Console.WriteLine($"{i++}. {pokemon.Name}");
        }

        var index = int.Parse(Console.ReadLine());
        trainer.AddPokemon(_staterPokemons[index - 1]);
        Console.WriteLine($"You have selected {_staterPokemons[index - 1].ToString()}");
        
        MainMenu(trainer);
    }

    public void MainMenu(PokemonTrainer trainer)
    {
        do
        {
            Console.WriteLine("Please select choice");
            Console.WriteLine("1. Go to Grass");
            Console.WriteLine("2. Go to Water");
            Console.WriteLine("3. Go to Pokeshop");
            Console.WriteLine("4. View pokemons");
            Console.WriteLine("5. View items");
            Console.WriteLine("6. Exit");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    StartGrassBattle();
                    break;
                case "2":
                    StartWaterBattle();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (true);
    }

    private void StartWaterBattle()
    {
        throw new NotImplementedException();
    }

    private void StartGrassBattle()
    {
        throw new NotImplementedException();
    }

    private void ViewPokeShop()
    {
        throw new NotImplementedException();
    }
    
    private void ViewPokemons(PokemonTrainer trainer)
    {
        if (trainer.Pokemons.Count == 0)
            return;
        foreach (var pokemon in trainer.Pokemons)
        {
            Console.WriteLine(pokemon.ToString());
        }
    }
}