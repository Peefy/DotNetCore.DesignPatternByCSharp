
using System;
using System.Collections.Generic;

namespace VsCodeProOne.Patterns.DataAccessObjectPattern
{
    public class StudentDaoImp1 : IStudentDao
    {

        List<Student> students;

        public StudentDaoImp1()
        {
            students = new List<Student>();
            var student1 = new Student("Robert", 0);
            var student2 = new Student("John", 1);
            students.Add(student1);
            students.Add(student2);
        }

        public void DeleteStudent(Student student)
        {
            students.RemoveAt(student.RollNo);
            Console.WriteLine("Student: Roll No " + student.RollNo + 
                ", deleted from database");
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void UpdateStudent(Student student)
        {
            students[student.RollNo].Name = student.Name;
            Console.WriteLine("Student: Roll No " + student.RollNo + 
                ", updated from database");
        }
    }

}
