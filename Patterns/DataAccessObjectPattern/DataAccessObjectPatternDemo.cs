
using System;

namespace VsCodeProOne.Patterns.DataAccessObjectPattern
{
    public static class DataAccessObjectPatternDemo
    {
        public static void Run()
        {
            Console.WriteLine("数据访问对象模式测试...");
            var studentDao = new StudentDaoImp1();
            foreach(var student in studentDao.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : " + 
                    student.RollNo + ", Name : " + student.Name + " ]");
            }
            var student0 = studentDao.GetAllStudents()[0];
            student0.Name = "DuGu";
            studentDao.UpdateStudent(student0);

            var student1 = studentDao.GetStudent(0);
            Console.WriteLine("Student: [RollNo : "
                +student1.RollNo +", Name : "+student1.Name +" ]"); 

            Console.WriteLine("数据访问对象模式测试结束");
        }
    }

}
