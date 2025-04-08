using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate.GameObject
{
    public abstract class GameObject : Interactable
    {
        public ConsoleColor color;
        public char symbol;
        public Vector2 position
        public abstract void Interact(Player player);
    }
}
