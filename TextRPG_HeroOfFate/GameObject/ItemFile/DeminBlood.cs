using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate.GameObject
{
    public class DeminBlood : MainItem
    {
        public DeminBlood(Math.Vector2 position) : base('D', position)
        {
            name = "악마의 피";
            description = "강력한 마력을 품은 붉은 액체, 왠지 쓸모가 있을 듯 하다.";
        }

        public override void Use()
        {
            Console.WriteLine("이 아이템은 사용이 불가능합니다.");
        }
    }
}
