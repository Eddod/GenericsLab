using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLab
{
    class Employee
    {
        public int _ID { get; set; }
        public string _name { get; set; }
        public string _gender { get; set; }
        public double _salary { get; set; }

        public Employee(int ID, string Name, string Gender, double Salary)
        {
            _ID = ID;
            _name = Name;
            _gender = Gender;
            _salary = Salary;

        }
            


    }
}
