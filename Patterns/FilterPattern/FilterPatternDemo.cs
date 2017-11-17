using System;
using System.Collections.Generic;

namespace VsCodeProOne.Patterns.FilterPattern
{
    public static class FilterPatternDemo
    {
        public static void Test()
        {
            var persons = new List<Person>();
            persons.Add(new Person("Rebort","Male","Single"));
            persons.Add(new Person("John","Male","Married"));
            persons.Add(new Person("Laura","Female","Single"));
            persons.Add(new Person("Rebort","Female","Single"));
            persons.Add(new Person("Mike","Male","Single"));
            persons.Add(new Person("Bobby","Male","Single"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            PrintPersons(male.MeetCriteria(persons));
            Console.WriteLine("Females: ");
            PrintPersons(female.MeetCriteria(persons));
            Console.WriteLine("Single Males: ");
            PrintPersons(singleMale.MeetCriteria(persons));
            Console.WriteLine("Single Or Females");
            PrintPersons(singleOrFemale.MeetCriteria(persons));

        }

        public static void PrintPersons(List<Person> persons)
        {
            foreach(var person in persons)
            {
                 Console.WriteLine("Person : [ Name : " + person.Name
                    +", Gender : " + person.Gender 
                    +", Marital Status : " + person.MaritialStatus
                    +" ]");
            }
        }

    }
}