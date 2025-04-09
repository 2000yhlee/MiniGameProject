using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TextRPG_HeroOfFate.Struct;

namespace TextRPG_HeroOfFate.GameObject
{
    public class Place : GameObject
    {
        private string scene;

        public Place(string scene, char symbol, Vector2 position)
            : base(ConsoleColor.Blue, symbol, position, false)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }

    }
}
