using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate.GameObject;

namespace TextRPG_HeroOfFate.Scene
{
    public class TownScene : BaseScene //마을 
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("고즈넉한 마을이 당신을 반겨준다.");
            Console.WriteLine("당신은 마을에 들어서서 주변을 살펴본다.");
            Console.WriteLine();
            Console.WriteLine("마을의 한쪽에 어느 노인이 당신을 신기하다는 표정으로 쳐다보고 있다.");
            Console.WriteLine("어떤 선택을 할까?");
            Console.WriteLine();
            Console.WriteLine("1. 노인에게 다가가 말을건다.");
            Console.WriteLine("2. 무시하고 가까이 있는 상점으로 들어간다.");
            Console.WriteLine("3. 근처에 있는 대장간으로 향한다.");
            Console.WriteLine("4. 왁자지껄한 주점으로 향한다.");
            if (Game.OldmanQuestState == QuestState.Received)
            {
                Console.WriteLine("5. 작은 숲으로 향한다.");
            }
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
                    Util.PressAnyKey("노인에게 다가가 말을겁니다.");
                    Game.ChangeScene("TownOldman");
                    break;
                case ConsoleKey.D2:
                    Util.PressAnyKey("상점으로 들어갑니다.");
                    Game.ChangeScene("Shop");
                    break;
                case ConsoleKey.D3:
                    if (Game.Player.Inventory.Items.Any(item => item.name == "악마의 피"))
                    {
                        Console.WriteLine("대장간으로 들어가시겠습니까?");
                        Console.WriteLine("1. 들어간다");
                        Console.WriteLine("2. 마을로 돌아간다");
                        var key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.D1)
                        {
                            Game.ChangeScene("Smithy");
                        }
                        else
                        {
                            Game.ChangeScene("Town");
                        }
                    }
                    else
                    {
                        Console.WriteLine("아직 문을 열지 않은 듯하다...");
                        Util.PressAnyKey();
                    }
                        break;
                case ConsoleKey.D4:
                    Util.PressAnyKey("주점으로 향합니다..");
                    Game.ChangeScene("Bar");
                    break;
                case ConsoleKey.D5:
                    if (Game.OldmanQuestState == QuestState.Received)
                    {
                        Util.PressAnyKey("작은 숲으로 향한다...");
                        Game.ChangeScene("LittleForest");
                    }
                    break;
            }

        }
        public override void Result()
        {            
            
        }
    }
}
