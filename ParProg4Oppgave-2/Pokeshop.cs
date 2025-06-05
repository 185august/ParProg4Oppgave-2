namespace ParProg4Oppgave_2;

public class Pokeshop
{
    public List<Item> PokeshopItems = new();


    public Item BuyItem(int index)
    {
        return PokeshopItems[index - 1];
    }

    public void AddItemToShopInventory(Item item)
    {
        PokeshopItems.Add(item);
    }
    
    public void InitializeShop()
    {
        List<Item> items = new()
        {
            new(10, "Potion", "Heals 10 HP"),
            new(20, "Super Potion", "Heals 20 HP"),
            new(30, "Hyper Potion", "Heals 30 HP"),
            new(10, "Pokemon ball", "Tries to catch a Pokemon, low chance"),
            new(20, "Super pokemon ball", "Tries to catch a Pokemon, high chance"),
        };
        foreach (var item in items)
        {
            AddItemToShopInventory(item);
        }
    }
}