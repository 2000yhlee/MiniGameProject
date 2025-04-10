using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate.GameObject.ItemFile
{
    public class WolfBone : MainItem
    {
        public WolfBone() : base('B', new Math.Vector2(0, 0))
        {
            name = "늑대의 뼈";
            description = "늑대를 처치하고 얻은 뼈이다. 강인한 늑대를 처치한 증거가 될것 같다.";
        }

        public override void Use()
        {
            Console.WriteLine("늑대의 뼈를 얻었다. 이걸 노인에게 가져가주자");
        }
    }
}
