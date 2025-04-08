using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate.Scene;

namespace TextRPG_HeroOfFate
{
    public class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver;

        public static void Run()
        {
            Start();
            
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
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
            gameOver = false;

            //씬 설정
            sceneDic = new Dictionary<string, BaseScene>();
            //씬 추가
            sceneDic.Add("Title", new TitleScene());


            curScene = sceneDic["Title"];
        }

        private static void End()
        {

        }
    }
}
