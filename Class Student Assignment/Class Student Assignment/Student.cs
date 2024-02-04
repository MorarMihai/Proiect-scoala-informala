using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student_Assignment
{
    class Student
    {
        private int _age;
        private string _name;
        private const int MIN_AGE = 18;
        private const int MAX_AGE = 99;

        public Student(int age,string name)
        {
            _age = age;
            _name = name;
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= MIN_AGE && value <= MAX_AGE)
                {
                    _age = value;
                }
            }
        }
        public int? Mark { get; set; }

        public  dynamic Info
        {
            get { return $"{_name}, {_age} ani"; }
            set { _age = value;_name = value; }
        }
        public double GetAverageMark(double a,double b,double c)
        {
            return (a + b + c) / 3;
        }
    }
}
