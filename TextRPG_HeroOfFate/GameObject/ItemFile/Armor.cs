using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate.GameObject.Item
{
    public class Armor : MainItem
    {
        public Armor(char symbol, Math.Vector2 position) : base('A', position)
        {
            name = "갑옷";
            description = "단단해 보이는 갑옷이다.";
        }

        public override void Use()
        {
            Console.WriteLine("굉장히 든든하다. 다칠 일이 없어진듯한 느낌이 든다.");
        }
    }
}
