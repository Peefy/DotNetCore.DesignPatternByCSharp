using System.Collections.Generic;

namespace VsCodeProOne.Patterns.FilterPattern
{
    public class CriteriaFemale : ICriteria
    {

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var femalePersons = new List<Person>();
            foreach(var person in persons)
            {
                if(person.Gender == "Female")
                    femalePersons.Add(person);
            }
            return femalePersons;
        }
    }

}