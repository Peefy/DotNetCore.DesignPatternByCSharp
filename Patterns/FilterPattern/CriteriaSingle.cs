using System.Collections.Generic;

namespace VsCodeProOne.Patterns.FilterPattern
{
    public class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var singlePersons = new List<Person>();
            foreach(var person in persons)
            {
                if(person.Gender == "Single")
                    singlePersons.Add(person);
            }
            return singlePersons;
        }
    }

}