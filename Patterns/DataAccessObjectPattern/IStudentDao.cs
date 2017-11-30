using System.Collections.Generic;

namespace VsCodeProOne.Patterns.DataAccessObjectPattern
{
    public interface IStudentDao
    {
        List<Student> GetAllStudents();

    }

}
