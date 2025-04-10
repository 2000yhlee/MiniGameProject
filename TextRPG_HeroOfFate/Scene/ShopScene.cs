using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate.GameObject;
using TextRPG_HeroOfFate.GameObject.Item;

namespace TextRPG_HeroOfFate.Scene
{
    class ShopScene : BaseScene
    {
        private ConsoleKey input;
        private List<MainItem> itemForSale = new List<MainItem>
        {
            new Potion(new Math.Vector2 (0, 0)),
            new Armor('A', new Math.Vector2(0, 0)),
            new Weapon('!', new Math.Vector2(0, 0), "작은 철제 칼", "작고 날카로운 검이다.")
        };
        public override void Render()
        {
            Console.WriteLine("조용한 상점이 당신을 맞이합니다.");
            Console.WriteLine("가게는 몇명의 여인들이 물건을 살피고 있고 대체적으로 조용한듯 싶습니다.");
            Console.WriteLine("당신은 가게 프론트에 앉아있는 주인에게 다가가 말을 겁니다.");
            Console.WriteLine();
            Console.WriteLine("주인은 당신을 맞이하며 구매할 수 있는 물건을 보여줍니다.");
            
            Console.WriteLine();
            Console.WriteLine("구매할 물건을 선택하세요");

            for (int i = 0; i < itemForSale.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {itemForSale[i].name} - {itemForSale[i].description}");
            }

            Console.WriteLine("0. 마을로 돌아가기");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key; // 키를 누를 때까지 기다리고 저장
        }

        // 입력에 따른 게임 로직 처리
        public override void Update()
        {
            int selected = (int)input - (int)ConsoleKey.D1; // D1이 1번 키, D2는 2번 키...

            if (input == ConsoleKey.D0) // 0번 키 입력 시
            {
                Game.ChangeScene("Town"); // 마을로 돌아감
                return;
            }

            // 유효한 상품 선택 시
            if (selected >= 0 && selected < itemForSale.Count)
            {
                MainItem selectedItem = itemForSale[selected]; // 선택한 아이템 가져오기
                Game.Player.Inventory.Add(selectedItem); // 인벤토리에 추가
                itemForSale.RemoveAt(selected); // 상점 리스트에서 제거

                Console.WriteLine($"{selectedItem.name} 을/를 구매하여 인벤토리에 추가했습니다.");
                Util.PressAnyKey();
            }
            else // 잘못된 입력 처리
            {
                Console.WriteLine("잘못된 입력입니다.");
                Util.PressAnyKey();
            }
        }

        public override void Result()
        {
            // 상점 씬 유지
        }

    }
}
