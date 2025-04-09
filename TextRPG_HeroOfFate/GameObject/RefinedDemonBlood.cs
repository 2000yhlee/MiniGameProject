using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate.GameObject
{
    public class RefinedDemonBlood : MainItem
    {
        public  RefinedDemonBlood (Struct.Vector2 position): base ('R', position)
        {
            name = "가공된 악마의 피";
            description = "죽음의 전당에 들어갈 수 있는 강력한 결정체";
        }

        public override void Use()
        {
            Console.WriteLine("형용할 수 없는 강한 힘이 느껴집니다... 사용할 수 있을 듯 합니다.");
            Game.ChangeScene("SantumOfDeath");
        }
    }
}
