using System.Collections.Generic;

namespace VsCodeProOne.Patterns.CompositePattern
{
    public class Employee
    {
        string _name = "";
        string _dept = "";
        int _salary;
        List<Employee> _subordinates;

        public Employee(string name, string dept, int sal)
        {
            _name = name;
            _dept = dept;
            _salary = sal;
            _subordinates = new List<Employee>();
        }

        public void Add(Employee e) => _subordinates.Add(e);

        public void Remove(Employee e) => _subordinates.Remove(e);

        public List<Employee> Subordinates => _subordinates;

        public override string ToString()
        {
            return ("Employee :[ Name : " + _name
                + ", dept : " + _dept + ", salary :"
                + _salary + " ]");
        }

    }

}
