namespace VsCodeProOne.Patterns.DataAccessObjectPattern
{
    public class Student
    {
        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }

        public string Name {get;set;}
        public int RollNo {get;set;}
    }

}
