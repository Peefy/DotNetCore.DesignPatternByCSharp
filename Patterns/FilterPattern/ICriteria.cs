using System.Collections.Generic;

namespace VsCodeProOne.Patterns.FilterPattern
{
    public interface ICriteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }
}