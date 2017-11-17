using System.Collections.Generic;

namespace VsCodeProOne.Patterns.FilterPattern
{
    public class AndCriteria : ICriteria
    {

        ICriteria _criteria;
        ICriteria _otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this._criteria = criteria;
            this._otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var firstCriteriaPersons = _criteria.MeetCriteria(persons);
            return _otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }

}