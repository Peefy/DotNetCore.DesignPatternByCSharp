
using System;

namespace VsCodeProOne.Patterns.MVCPattern
{
    public static class MVCPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("MVC模式测试...");
            var model = RetriveStudentFromDatabase();
            var view = new StudentView();
            var controller = new StudentController(model, view);
            controller.UpdateView();
            controller.StudentName = "John";
            controller.StudentRollNo = "12";
            controller.UpdateView();
            Console.WriteLine("MVC模式测试结束...");
        }

        private static Student RetriveStudentFromDatabase()
        {
            return new Student()
            {
                Name = "DuGu",
                RollNo = "10"
            };
        }
    }

}
