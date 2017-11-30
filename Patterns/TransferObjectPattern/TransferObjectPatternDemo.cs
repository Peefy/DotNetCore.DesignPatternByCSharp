
using System;

namespace VsCodeProOne.Patterns.TransferObjectPattern
{
    public static class TransferObjectPatternDemo
    {
        public static void Run()
        {
            var studentBusinessObject = new StudentBO();
            foreach(var student in studentBusinessObject.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : "
                    + student.RollNo+", Name : "+student.Name+" ]");
            }

            var student0 = studentBusinessObject.GetAllStudents()[0];
            student0.Name = "Michedl";
            studentBusinessObject.UpdateStudent(student0);
            student0 = studentBusinessObject.GetStudent(0);
            Console.WriteLine("Student: [RollNo : "
                    + student0.RollNo+", Name : "+student0.Name+" ]");
        }
    }

}
