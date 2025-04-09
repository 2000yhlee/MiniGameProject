using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate.Scene
{
    public class BarScene : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("마을의 주점에 들어섰습니다.");
            Console.WriteLine("사람들이 음식을 먹고 술을 마시며 시끌벅적하게 이야기를 나누고 있습니다.");
            Console.WriteLine();
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 술을 마신다");
            Console.WriteLine("2. 마을로 돌아간다.");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            switch(input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("당신은 술을 마셨습니다. 눈앞이 어지러운듯 합니다.");
                    Util.PressAnyKey();
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Town");
                    break;
            }
        }
        public override void Result()
        {

        }

    }
}
