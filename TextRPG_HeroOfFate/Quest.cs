using System;

namespace TextRPG_HeroOfFate
{
    public class Quest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public QuestState State { get; set; }

        // 퀘스트 완료조건을 정의
        public Func<Player, bool> CompleationCondition { get; set; }

        // 퀘스트 완료 조건을 확인
        public void CheckComplete(Player player)
        {
            if (State == QuestState.Received && CompleationCondition != null && CompleationCondition(player))
            {
                State = QuestState.Completed;
                Console.WriteLine($"{Title} 퀘스트 완료!");
            }
        }
    } 
}
