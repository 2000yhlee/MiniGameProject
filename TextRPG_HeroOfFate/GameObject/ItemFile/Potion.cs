using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TextRPG_HeroOfFate;
using TextRPG_HeroOfFate.GameObject;

namespace TextRPG_HeroOfFate.GameObject.Item
{
    public class Potion : MainItem
    {
        public Potion(Struct.Vector2 position) : base('P', position)
        {
            name = "포션";
            description = "체력을 회복하는 물약입니다.";
        }

        public override void Use()
        {
            Console.WriteLine("포션을 사용하여 체력이 회복됩니다!");
            // 체력 회복 로직 추가 가능
        }
    }
}
