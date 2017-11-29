
using System;

namespace VsCodeProOne.Patterns.TemplatePattern
{
    public static class TemplatePatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("模板模式测试...");
            Game game = new Cricket();
            game.Play();
            Console.WriteLine("");
            game = new Football();
            game.Play();
            Console.WriteLine("");
        }
    }

}
