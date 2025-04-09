using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate.GameObject;

namespace TextRPG_HeroOfFate.Scene
{
    public class SmithyScene : BaseScene
    {
        private ConsoleKey input;
        private bool isRefined = false;

        public override void Render()
        {
            Console.WriteLine("당신은 대장간으로 들어섰습니다.");
            Console.WriteLine("뜨거운 열기가 얼굴을 덮칩니다.");
            Console.WriteLine("망치로 강철을 두드리던 대장장이가 당신을 바라봅니다.");
            Console.WriteLine();
            Console.WriteLine("대장장이 : 어서오시게, 무슨 일로 찾으셨나?");
            Console.WriteLine();
            Console.WriteLine("1. 대장장이에게 악마의 피를 보여주고 가공을 부탁한다.");
            Console.WriteLine("2. 마을로 돌아간다.");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    var demonBlood = Game.Player.Inventory.Items.FirstOrDefault(item => item.name == "악마의 피");

                    if(demonBlood == null)
                    {
                        Console.WriteLine("인벤토리에 악마의 피가 없습니다.");
                        Util.PressAnyKey();
                        return;
                    }

                    Game.Player.Inventory.Remove(demonBlood);
                    Game.Player.Inventory.Add(new RefinedDemonBlood(new Struct.Vector2(0, 0)));
                    Console.WriteLine("악마의 피를 가공했습니다.");
                    isRefined = true;
                    break;
            }
        }
        public override void Result()
        {

        }

    }
}
