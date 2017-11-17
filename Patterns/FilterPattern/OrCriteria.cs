using System.Collections.Generic;

namespace VsCodeProOne.Patterns.FilterPattern
{
    public partial class OrCriteria : ICriteria
    {

        ICriteria _criteria;
        ICriteria _otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this._criteria = criteria;
            this._otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var firstCriteriaItems = _criteria.MeetCriteria(persons);
            var otherCriteriaItems = _otherCriteria.MeetCriteria(persons);
            foreach(var person in otherCriteriaItems)
            {
                if(!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }
            return firstCriteriaItems;
        }

    }

}