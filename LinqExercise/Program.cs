﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine(numbers.Sum());
            //TODO: Print the Average of numbers
            Console.WriteLine(numbers.Average());
            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine(numbers.OrderBy(x => x));
            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine(numbers.OrderByDescending(x => x));
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine(numbers.Where(x => x > 6));
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var ascNumbers = numbers.OrderBy(x => x).ToList();
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(ascNumbers[i]);
            }
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            ascNumbers[3] = 37;
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(ascNumbers[i]);
            }
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine(employees.Where(n => n.FirstName.StartsWith("C") || n.FirstName.StartsWith("S")).OrderBy(n => n.FirstName).Select(n => n.FullName));
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine(employees.Where(n => n.Age > 26).OrderBy(n => n.Age).OrderBy(n => n.FirstName).Select(n => n.FullName + " " + n.Age));
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine(employees.Where(n => n.YearsOfExperience <= 10 && n.Age > 35).Select(n => n.YearsOfExperience).Sum());
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine(employees.Where(n => n.YearsOfExperience <= 10 && n.Age > 35).Select(n => n.YearsOfExperience).Average());
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees.Insert(employees.Count, new Employee() { Age = 35, YearsOfExperience = 23, FirstName = "stan", LastName = "man"});

            Console.WriteLine(employees[employees.Count - 1]);

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
