
using System;

namespace VsCodeProOne.Patterns.FrontControllerPattern
{
    public class FrontControllerPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("前端控制器模式测试...");
            var frontController = new FrontController();
            frontController.DispatchRequest("Home");
            frontController.DispatchRequest("Student");
            Console.WriteLine("前端控制器模式测试结束");
        }
    }

}
