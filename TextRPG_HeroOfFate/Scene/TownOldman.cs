using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate.Scene
{
    class TownOldman : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("조용한 상점이 당신을 맞이합니다.");
            Console.WriteLine("가게는 몇명의 여인들이 물건을 살피고 있고 대체적으로 조용한듯 싶습니다.");
            Console.WriteLine("당신은 가게 프론트에 앉아있는 주인에게 다가가 말을 겁니다.");
            Console.WriteLine();
            Console.WriteLine("주인은 당신을 맞이하며 구매할 수 있는 물건을 보여줍니다.");
            Console.WriteLine();
            Console.WriteLine("1. 포션");
            Console.WriteLine("2. 갑옷");
            Console.WriteLine("3. 작은 철제 칼");
            Console.WriteLine();
            Console.WriteLine("구매할 물건을 선택하세요");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            
        }
        public override void Result()
        {
            
        }

    }
}
