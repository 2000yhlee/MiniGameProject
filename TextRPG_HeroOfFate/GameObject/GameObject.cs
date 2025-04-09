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
        public Struct.Vector2 position;
        public bool isOnce;

        public GameObject(ConsoleColor color, char symbol, Struct.Vector2 position, bool isOnce)
        {
            this.color = color;
            this.symbol = symbol;
            this.position = position;
            this.isOnce = isOnce;
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.WriteLine(symbol);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);
    }
}
