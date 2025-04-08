using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate
{
    public class Player : Struct
    {        
        public Vector2 position;

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine('P');
            Console.ResetColor();
        }

        public void Move(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    position.y--;
                    break;
                case ConsoleKey.DownArrow:
                    position.y++;
                    break;
                case ConsoleKey.RightArrow:
                    position.x++;
                    break;
                case ConsoleKey.LeftArrow:
                    position.x--;
                    break;
            }
        }
    }
}
