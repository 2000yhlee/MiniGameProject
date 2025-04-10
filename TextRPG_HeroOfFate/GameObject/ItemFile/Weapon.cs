using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TextRPG_HeroOfFate.Math;


namespace TextRPG_HeroOfFate.GameObject
{
    public class Weapon : MainItem
    {
        public int power { get; }

        public Weapon(char symbol, Math.Vector2 position, string name, string description) : base(symbol, position)
        {
            this.name = name;
            this.description = description;
        }

        public override void Use()
        {
            Console.WriteLine($"{name}을 휘둘렀습니다!");
        }
    }
}
