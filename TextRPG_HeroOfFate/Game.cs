using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate.Scene;

namespace TextRPG_HeroOfFate
{
    public class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static Player player;
        public static Player Player { get { return player; } }

        private static bool gameOver;

        public static void Run()
        {
            Start();
            
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Result();
            }

            End();
        }        

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        private static void Start()
        {
            //게임 설정
            gameOver = false;

            //플레이어 설정
            player = new Player();

            //씬 설정
            sceneDic = new Dictionary<string, BaseScene>();
            //씬 추가
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Grassland", new GrasslandScene());
            sceneDic.Add("Town", new TownScene());

            //시작씬
            curScene = sceneDic["Title"];
        }

        private static void End()
        {

        }
    }
}
