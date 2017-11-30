
using System;
using System.Collections.Generic;

namespace VsCodeProOne.Patterns.TransferObjectPattern
{
    public class StudentBO
    {
        List<StudentVO> students;

        public StudentBO()
        {
            students = new List<StudentVO>();
            var student1 = new StudentVO("DuGu", 0);
            var student2 = new StudentVO("John", 1);
            students.Add(student1);
            students.Add(student2);
        }

        public void DeleteStudent(StudentVO student)
        {
            students.RemoveAt(student.RollNo);
            Console.WriteLine("Student: Roll No " 
                + student.RollNo +", deleted from database");
        }

        public List<StudentVO> GetAllStudents()
        {
            return students;
        }

        public StudentVO GetStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void UpdateStudent(StudentVO student)
        {
            students[student.RollNo].Name = student.Name;
            Console.WriteLine("Student: Roll No " 
                + student.RollNo +", updated in the database");
        }

    }

}
