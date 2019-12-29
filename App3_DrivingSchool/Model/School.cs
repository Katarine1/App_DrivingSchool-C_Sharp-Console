using System;
using System.Collections.Generic;
using System.Text;

namespace App3_DrivingSchool.Model
{
    public class School
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public School() { }

        public School(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string CheckAge(int age)
        {
            if(age < 18)
            {
                return "Without permission.";
            }
            else if (age >= 18)
            {
                return "Permission granted.";
            }
            return null;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age;
        }
    }
}
