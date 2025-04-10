using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate.GameObject;
using TextRPG_HeroOfFate.GameObject.Item;

namespace TextRPG_HeroOfFate
{
    public class Player
    {        
        public Math.Vector2 position;
        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }

        public List<Quest> Quests { get; set; }

        public bool[,] map;

        public int curHP;
        public int CurHP { get { return curHP; } }
        private int maxHP;
        public int MaxHP { get { return maxHP; } }

        private int attack;

        public int Attack { get { return attack; }}

        private Weapon equippedWeapon;
        private Armor equippedArmor;

        public Weapon EquippedWeapon => equippedWeapon;
        public Armor EqippedArmor => equippedArmor;

        public Player()
        {
            inventory = new Inventory();
            Quests = new List<Quest>();
            maxHP = 100;
            curHP = maxHP;
            attack = 3;
        }

        public void EquipWeapon(Weapon weapon)
        {
            equippedWeapon = weapon;
            attack = 3 + weapon.power;
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
            Console.Write('P');
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
            Math.Vector2 targetPos = position;

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

            if (targetPos.y >= 0 && targetPos.y < map.GetLength(0) &&
                targetPos.x >= 0 && targetPos.x < map.GetLength(1) &&
                map[targetPos.y, targetPos.x])
            {
                position = targetPos;
            }
        }
    }
}
