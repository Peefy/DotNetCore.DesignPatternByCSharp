using System.Collections.Generic;

namespace VsCodeProOne.Patterns.FilterPattern
{
    public class CriteriaMale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var malePersons = new List<Person>();
            foreach(var person in persons)
            {
                if(person.Gender == "Male")
                    malePersons.Add(person);
            }
            return malePersons;
        }
    }

}