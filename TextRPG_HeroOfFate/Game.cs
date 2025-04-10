using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using TextRPG_HeroOfFate.GameObject;
using TextRPG_HeroOfFate.Scene;

namespace TextRPG_HeroOfFate
{
   
    public class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static Player player;
        public static Player Player { get { return player; } }

        // 노인 퀘스트의 현재상태
        private static QuestState oldmanQuestState = QuestState.NotReceived;
        // 다른 클래스에서 접근 가능하도록 공개 프로퍼티 제공
        public static QuestState OldmanQuestState
        {
            get { return oldmanQuestState; }
            set { oldmanQuestState = value; }
        }
        // 게임 종료 여부
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
            curScene.Enter(); //씬 전환시 Enter 호출;
        }

        private static void Start()
        {
            //커서 안보이게
            Console.CursorVisible = false;

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
            sceneDic.Add("TownOldman", new TownOldman());
            sceneDic.Add("Shop", new ShopScene());
            sceneDic.Add("Grove", new GroveScene());
            sceneDic.Add("Bar", new BarScene());
            sceneDic.Add("Smithy", new SmithyScene());
            sceneDic.Add("LittleForest", new LittleForest());

            //시작씬
            curScene = sceneDic["Title"];
        }

        private static void End()
        {

        }
    }
}
