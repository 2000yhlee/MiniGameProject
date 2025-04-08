using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate.Scene
{
    public class GroveScene : BaseScene // 작은숲
    {
        private ConsoleKey input;

        private string[] mapData;
        private bool[,] map;

        public GroveScene()
        {
            mapData = new string[]
            {
                "#####################",
                "#                   #",
                "#                   #",
                "#                   #",
                "#                   #",
                "#                   #",
                "#                   #",
                "#                   #",
                "#                   #",
                "#####################"
            };

            map = new bool[10, 21];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }
        }
        public override void Render()
        {
            PrintMap();
            Game.Player.Print();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            Game.Player.Move(input);
        }
        public override void Result()
        {
            
        }
        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
