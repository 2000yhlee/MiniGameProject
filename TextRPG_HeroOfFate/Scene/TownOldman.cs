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
            Console.WriteLine("당신이 노인에게 다가가자 노인이 말을 겁니다.");
            Console.WriteLine("노인에게 퀘스트를 수령할 수 있습니다.");
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
