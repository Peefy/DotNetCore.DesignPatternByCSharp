
using System;

namespace VsCodeProOne.Patterns.TemplatePattern
{
    public class Football : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine($"{nameof(Football)} Game Finished!");
        }

        public override void Initialize()
        {
            Console.WriteLine($"{nameof(Football)} Game Init! Start Playing");
        }

        public override void StartPlay()
        {
            Console.WriteLine($"{nameof(Football)} Game Started! Enjoy the game!");
        }
    }

}
