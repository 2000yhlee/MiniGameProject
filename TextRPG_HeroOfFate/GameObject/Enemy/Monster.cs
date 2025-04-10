using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate.GameObject.ItemFile;

namespace TextRPG_HeroOfFate.GameObject.Enemy
{
    public class Monster : GameObject
    {
        protected int hp;
        protected int attack;
        protected MainItem dropItem;

        public Monster(string name, char symbol, Math.Vector2 position,
            ConsoleColor color, int hp, int attack, MainItem dropItem) : base(color, symbol, position, true)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.dropItem = dropItem;
        }

        public override void Interact(Player player)
        {
            Console.WriteLine($"{name}과/와 전투를 시작합니다.");

            while (hp > 0 && player.CurHP >0)
            {
                Console.WriteLine($"{name}의 체력 : {hp}");
                Console.WriteLine($"플레이어 HP : {player.curHP}");
                Console.WriteLine("키를 눌러 공격하세요.");
                Console.ReadKey(true);

                hp -= player.Attack;

                if (hp > 0)
                {
                    player.curHP -= attack;
                    Console.WriteLine($"{name}의 공격! 플레이어 HP :{player.curHP}");
                }
            }

            if (player.curHP <= 0)
            {
                Console.WriteLine("당신은 싸움에서 패했습니다....");
                return;
            }

            Console.WriteLine($"{name}을 처치했습니다.");

            if (dropItem != null)
            {
                player.Inventory.Add(dropItem);
                Console.WriteLine($"{dropItem.name}을/를 획득했습니다.");
            }

            Util.PressAnyKey("전투를 마쳤습니다.");
        }
    }
}
