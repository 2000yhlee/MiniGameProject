using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate;

namespace TextRPG_HeroOfFate.Scene
{
    public class TownOldman : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("당신이 노인에게 다가가자 노인이 말을 겁니다.");
            Console.WriteLine("노인 : 안녕하신가 젊은이, 건강해보이는구만");

            if (Game.OldmanQuestState == QuestState.Completed)
            {
                Console.WriteLine("오랜만이군 잘 지냈나? 저번엔 휼륭했네.");
            }
            else if (Game.OldmanQuestState == QuestState.NotReceived)
            {
                if (!Game.Player.HasWeapon())
                {
                    Console.WriteLine("노인 : 건강한 젊은이군! 하지만 뭔가 부족한듯하네만, 마을에 필요한 인재는 아닌듯하군 그래");
                    Console.WriteLine();
                    Console.WriteLine("아무키나 눌러 마을로 돌아갑니다.");
                }
                else
                {
                    Console.WriteLine("노인 : 상당한 강인함을 가진 젊은이처럼 보이는군");
                    Console.WriteLine("노인 : 괜찮다면 이 노인장의 부탁을 하나 들어줄 수 있겠는가?");
                    Console.WriteLine();
                    Console.WriteLine("1. 퀘스트를 수락");
                    Console.WriteLine("2. 거절한다.");
                }
            }
            else
            {
                Console.WriteLine("노인 : 괜찮다면 숲에 있는 늑대를 토벌하는걸 부탁해도 되겠는가?");
                Console.WriteLine("요즘 늑대가 사나워져서 사람이 많이 다친다네 부탁하지");
            }
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            // 처음 노인을 찾아갔을때 
            if (Game.OldmanQuestState == QuestState.NotReceived && Game.Player.HasWeapon())
            {
                if (input == ConsoleKey.D1)
                {
                    Game.OldmanQuestState = QuestState.Received;
                    Console.WriteLine("작은 숲으로 가서 늑대를 처치하시오");
                    Util.PressAnyKey();
                    Game.ChangeScene("Town");
                }
                else if (input == ConsoleKey.D2)
                {
                    Console.WriteLine("노인 : 그렇다면 어쩔 수 없군... 만약 마음이 동한다면 나중에라도 부탁함세");
                    Util.PressAnyKey();
                    Game.ChangeScene("Town");
                }
            }
            else if(Game.OldmanQuestState == QuestState.Received && Game.Player.HasWeapon()) //퀘스트를 받고 노인을 찾아왔을 경우
            {
                bool haswolfBone = Game.Player.Inventory.Items.Any(item => item.name == "늑대의 뼈"); 

                if (haswolfBone)
                {
                    Game.OldmanQuestState = QuestState.Completed;
                    Console.WriteLine("노인 : 오오! 늑대를 잡아왔구만");
                    Console.WriteLine("보상으로 이걸 줌세 아마 앞으로의 모험에 큰 도움이 될껄세");
                    Util.PressAnyKey("수정구슬을 얻었다!");
                }
                else
                {
                    Console.WriteLine("노인 : 늑대는 아직인가?");
                    Util.PressAnyKey("작은 숲으로 가서 늑대를 잡아오자");
                }

                Game.ChangeScene("Town");
            }
            else
            {
                Util.PressAnyKey();
                Game.ChangeScene("Town");
            }
        }
        public override void Result()
        {
            
        }

    }
}
