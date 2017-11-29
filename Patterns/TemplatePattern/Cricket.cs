
using System;

namespace VsCodeProOne.Patterns.TemplatePattern
{
    public class Cricket : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine($"{nameof(Cricket)} Game Finished!");
        }

        public override void Initialize()
        {
            Console.WriteLine($"{nameof(Cricket)} Game Init! Start Playing");
        }

        public override void StartPlay()
        {
            Console.WriteLine($"{nameof(Cricket)} Game Started! Enjoy the game!");
        }
    }

}
