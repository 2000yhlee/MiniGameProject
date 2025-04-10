using System.CodeDom;
using System.Collections.Generic;
using TextRPG_HeroOfFate.GameObject;
using TextRPG_HeroOfFate.GameObject.Enemy.작은_숲;
using TextRPG_HeroOfFate.GameObject.Item;
using TextRPG_HeroOfFate.GameObject.ItemFile;

namespace TextRPG_HeroOfFate.GameObject
{
    public class LittleForest : FieldScene
    {
        public LittleForest()
        {
            name = "LittleForest";

            mapData = new string[]
            {
                "####################",
                "#     P            #",
                "#  #######         #",
                "#        #   ###   #",
                "#        #         #",
                "#####    #####     #",
                "#        #   #     #",
                "#    T       #  W  #",
                "#            #######",
                "####################"
            };

            int height = mapData.Length;
            int width = mapData[0].Length;
            map = new bool[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    map[y, x] = mapData[y][x] != '#';
                }
            }

            gameObjects = new List<GameObject>
            {
                new Place("Town", 'T', new Math.Vector2(6, 7)),
                new Potion(new Math.Vector2(6,1)),
                new Wolf("Wolf", 'w', new Math.Vector2(17,7), System.ConsoleColor.DarkBlue, 10, 3, new WolfBone())
            };
        }

        public override void Enter()
        {
            Game.Player.position = new Math.Vector2(4, 7);
            Game.Player.map = map;
        }
    }
}
