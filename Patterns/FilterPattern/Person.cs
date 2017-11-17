
using System;

namespace VsCodeProOne.Patterns.FilterPattern
{
    public class Person
    {
        string _name = "";
        string _gender = "";
        string _maritialStatus = "";

        public Person(string name, string gender, string maritialStatus)
        {
            _name = name;
            _gender = gender;
            _maritialStatus = maritialStatus;
        }

        public string Name => _name;
        public string Gender => _gender;
        public string MaritialStatus => _maritialStatus;

    }

}