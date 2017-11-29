
using System;

namespace VsCodeProOne.Patterns.MVCPattern
{
    public class StudentView
    {
        public void PrintStudentDetails(string studentName, string studentRollNo)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("Name : " + studentName);
            Console.WriteLine("Roll No : " + studentRollNo);
        }
    }

}
