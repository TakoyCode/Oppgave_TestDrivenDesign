namespace Oppgave_TestDrivenDesign.Main
{
    public class GamePlay
    {
        public List<Item> DroppableItems;

        public GamePlay()
        {
            DroppableItems = new List<Item>()
            {
                new Item("HealthPotion"),
                new Item("HealthPotion"),
                new Item("HealthPotion"),
                new Item("StrengthPotion"),
                new Item("StrengthPotion"),
                new Item("StaminaPotion"),
                new Item("StaminaPotion"),
                new Item("StaminaPotion"),
                new Item("StaminaPotion"),
                new Item("StaminaPotion"),
            };
        }

        public Item GetHealthPotion()
        {
            return new Item("HealthPotion");
        }

        public Item GetRandomItemToDrop()
        {
            var r = new Random();
            var randomIndex = r.Next(0, 10);
            return DroppableItems[randomIndex];
        }
    }
}
