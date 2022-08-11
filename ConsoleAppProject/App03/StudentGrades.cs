using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        
        List<Student> studentsList = new List<Student>();
        
        public bool AddStudent()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please input Student ID");
            Console.WriteLine();
            Console.WriteLine();
            if (Int32.TryParse(Console.ReadLine(), out int Id))
            {
                Console.WriteLine("User Choice is: " + Id);
            }
            else
            {
                Console.WriteLine("Invalid Unit Type Selected");
                Console.WriteLine("Do you want to try again? [Y/N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    AddStudent();
                }
                else return false;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please input Student Name");
            Console.WriteLine();
            Console.WriteLine();
            string Name = Console.ReadLine();
            if (Name.GetType() == typeof(string))
            {
                Console.WriteLine("User Choice is: " + Name);
            }
            else
            {
                Console.WriteLine("Invalid Unit Type Selected");
                Console.WriteLine("Do you want to try again? [Y/N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    AddStudent();
                }
                else return false;
            }

            studentsList.Add(new Student(Id,Name));
            
            OutputChoices();
            return true;
        }
        
        public bool DisplayList()
        {
            Console.WriteLine("                     List                            ");
            Console.WriteLine(" =================================================   ");
            Console.WriteLine(); 
            foreach (var student in studentsList)
            { 
                Console.WriteLine("ID = " + student.Id);
                Console.WriteLine("Name = " + student.Name); 
                Console.WriteLine("Mark = " + student.Mark);
            }
            Console.WriteLine();  
            Console.WriteLine(" =================================================   ");
            Console.WriteLine();
            return true;
        }
        public void Run()
        {
            studentsList.Add(new Student(1,"Micah",0));
            studentsList.Add(new Student(2,"Pearson",0));
            studentsList.Add(new Student(3,"Jack",0));
            studentsList.Add(new Student(4,"Bill",0));
            studentsList.Add(new Student(5,"Hosea",0));
            studentsList.Add(new Student(6,"Lenny",0));
            studentsList.Add(new Student(7,"John",0));
            studentsList.Add(new Student(8,"Arthur",0));
            studentsList.Add(new Student(9,"Javier",0));
            studentsList.Add(new Student(10,"Dutch",0));
            OutputHeading();
            OutputChoices();


        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================   ");
            Console.WriteLine("    Student Grades ");
            Console.WriteLine("     by Connor Martin                                ");
            Console.WriteLine(" =================================================   ");
            Console.WriteLine();

        }

        private void OutputChoices()
        {
            Console.WriteLine(" =================================================   ");
            Console.WriteLine("    Please what you wish to do                       ");
            Console.WriteLine("    1: Add a Student                                 ");
            Console.WriteLine("    2: Display List of Students                      ");
            Console.WriteLine("    3: Input a mark for a Student                    ");
            Console.WriteLine(" =================================================   ");
            bool success = Int32.TryParse(Console.ReadLine(), out int userChoice);
            switch (userChoice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    DisplayList();
                    break;
                case 3:
                    break;
            }
        }
    }
}


/*
 student object
    - add student
    - mark variable
    - check mark method
    - put objects into array?
    - loop through array
 */