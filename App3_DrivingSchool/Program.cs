using System;
using App3_DrivingSchool.Model;

namespace App3_DrivingSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("\t\t# -- Driving Scholl -- #");

            Console.WriteLine();
            Console.Write("\t\tEnter your Name: ");
            string name = Console.ReadLine();
            Console.Write("\t\tEnter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            School school = new School(name, age);
            string a = school.CheckAge(age);

            Console.WriteLine("\t\t" + school + ", " + a + "\n\n");
        }
    }
}
