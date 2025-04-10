using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate.GameObject.ItemFile;

namespace TextRPG_HeroOfFate.GameObject.Enemy.작은_숲
{
    public class Wolf : Monster
    {
        public Wolf(string name, char symbol, Math.Vector2 position, ConsoleColor color, int hp, int attack, MainItem dropItem) 
            : base("늑대", symbol, position, ConsoleColor.DarkBlue, 10, 3, new WolfBone()) { }
    }
}
