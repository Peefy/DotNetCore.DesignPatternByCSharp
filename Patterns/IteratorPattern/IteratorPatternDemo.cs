
using System;

namespace VsCodeProOne.Patterns.IteratorPattern
{
    public static class IteratorPatternDemo
    {
        public static void Test()
        {
            Console.WriteLine("迭代器模式测试...");
            InternalTest();
            Console.WriteLine("");
        }

        private static void InternalTest()
        {
            var nameRepository = new NameRepository();
            for (var iterator = nameRepository.Iterator; iterator.HasNext();)
            {
                var name = iterator.Next() as string;
                Console.WriteLine("Name : " + name);
            }
        }
    }

}
