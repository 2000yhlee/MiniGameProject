using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate.GameObject;

namespace TextRPG_HeroOfFate
{
    public class Player
    {        
        public Struct.Vector2 position;
        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }

        public List<Quest> Quests { get; set; }

        public bool[,] map;

        private int curHP;
        public int CurHP { get { return curHP; } }
        private int maxHP;
        public int MaxHP { get { return maxHP; } }

        public Player()
        {
            inventory = new Inventory();
            Quests = new List<Quest>();
            maxHP = 100;
            curHP = maxHP;
        }

        public bool HasWeapon()
        {
            return Inventory.Items.Any(Item => Item is Weapon);
        }

        public void Heal(int amount)
        {
            curHP += amount;
            if (curHP > MaxHP)
            {
                curHP = maxHP;
            }
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine('P');
            Console.ResetColor();
        }

        public void Action(ConsoleKey input) 
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                    Move(input);
                    break;
                case ConsoleKey.I:
                    inventory.Open();
                    break;
            }
        }

        public void Move(ConsoleKey input)
        {
            Struct.Vector2 targetPos = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    targetPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    targetPos.y++;
                    break;
                case ConsoleKey.RightArrow:
                    targetPos.x++;
                    break;
                case ConsoleKey.LeftArrow:
                    targetPos.x--;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }
    }
}
