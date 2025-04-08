using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate.Scene
{
    class GrasslandScene : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("아름다운 평원이 당신의 눈앞에 펼쳐집니다.");
            Console.WriteLine("당신은 모험을 펼칠 기대를 품고 앞으로 나아갑니다.");
            Console.WriteLine("저 멀리 마을이 보이고 있습니다.");
            Console.WriteLine();
            Console.WriteLine("선택지를 눌러 진핼하세요");
            Console.WriteLine();
            Console.WriteLine("1. 마을로 들어간다.");
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
            switch(input)
            {
                case ConsoleKey.D1:
                    Util.PressAnyKey("마을로 진입합니다.");
                    Game.ChangeScene("Town");
            }
        }
    }
}
