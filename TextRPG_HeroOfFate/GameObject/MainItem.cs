using System;
using static TextRPG_HeroOfFate.Math;

namespace TextRPG_HeroOfFate.GameObject
{
    public abstract class MainItem : GameObject
    {
        public string name;
        public string description;

        public MainItem(char symbol, Vector2 position)
            : base(ConsoleColor.Yellow, symbol, position, true)
        {
        }

        public override void Interact(Player player)
        {
            player.Inventory.Add(this);
        }

        public abstract void Use();

    }
}
