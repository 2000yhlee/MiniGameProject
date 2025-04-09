using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_HeroOfFate
{
    public class ExtensionAndUtil
    {

    }

    public class Util
    {
        public static void PressAnyKey(string text = "아무키나 눌러 진행하세요.")
        {
            Console.WriteLine(text);
            Console.WriteLine("아무키나 눌러 진행하세요.");
            Console.ReadKey(true);
        }
    }
}
