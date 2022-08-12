using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        
        private bool AddStudent()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please input Student ID");
            Console.WriteLine();
            Console.WriteLine();
            if (Int32.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("User Choice is: " + id);
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
            string name = Console.ReadLine();
            if (name.GetType() == typeof(string))
            {
                Console.WriteLine("User Choice is: " + name);
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

            studentsList.Add(new Student(id,name));
            
            OutputChoices();
            return true;
        }

        private string CalculateGrade(int mark)
        {
            
            if (mark == 100 || mark >= 70)
            {
                return "A";
            }

            if (mark >= 60)
            {
                return "B";
            }

            if (mark >= 50)
            {
                return "C";
            }

            if (mark >= 40)
            {
                return "D";
            }

            if (mark < 39)
            {
                return "F";
            }
            return "Invalid";
        }

        private bool AddMark()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please input Student ID");
            Console.WriteLine();
            Console.WriteLine();
            if (Int32.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("User Choice is: " + id);
            }
            else
            {
                Console.WriteLine("Invalid Unit Type Selected");
                Console.WriteLine("Do you want to try again? [Y/N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    AddMark();
                }
                else return false;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please input Student Mark");
            Console.WriteLine();
            Console.WriteLine();
            if (Int32.TryParse(Console.ReadLine(), out int mark))
            {
                Console.WriteLine("User Choice is: " + mark);
                studentsList[id].Mark = mark;
                DisplayList();
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Do you want to try again? [Y/N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    AddMark();
                }
                else return false;
            }
            return false;
        }
        
        private void DisplayList()
        {
            Console.WriteLine("                     List                            ");
            Console.WriteLine(" =================================================   ");
            Console.WriteLine(); 
            foreach (var student in studentsList)
            { 
                Console.WriteLine("ID = " + student.Id + " Name = " + student.Name + " Mark = " + student.Mark + " Grade = " + CalculateGrade(student.Mark));
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("");
            }
            Console.WriteLine();  
            Console.WriteLine(" =================================================   ");
            Console.WriteLine();
            OutputChoices();
        }
        private void DisplayProfile()
        {
            var maxMark = studentsList.Max(student => student.Mark);
            var minMark = studentsList.Min(student => student.Mark);
            var mean = studentsList.Average(student => student.Mark);
            var profile = new List<string>();
            Console.WriteLine("                     List                            ");
            Console.WriteLine(" =================================================   ");
            Console.WriteLine();
            Console.WriteLine("Maximum Mark: " + maxMark);
            Console.WriteLine("Minimum Mark: " + minMark);
            Console.WriteLine("Mean Mark: " + mean);
            foreach (var student in studentsList)
            {
                profile.Add(CalculateGrade(student.Mark));
            }
            var A = ((double)profile.Count(i=>i=="A"))/profile.Count * 100;
            var B = ((double)profile.Count(i=>i=="B"))/profile.Count * 100;
            var C = ((double)profile.Count(i=>i=="C"))/profile.Count * 100;
            var D = ((double)profile.Count(i=>i=="D"))/profile.Count * 100;
            var F = ((double)profile.Count(i=>i=="F"))/profile.Count * 100;
            var invalid = ((double)profile.Count(i=>i=="Invalid"))/profile.Count * 100;
            Console.WriteLine("A = " + A + "%");
            Console.WriteLine("B = " + B + "%");
            Console.WriteLine("C = " + C + "%");
            Console.WriteLine("D = " + D + "%");
            Console.WriteLine("F = " + F + "%");
            Console.WriteLine();  
            Console.WriteLine(" =================================================   ");
            Console.WriteLine();
            OutputChoices();
        }
        public void Run()
        {
            //example data
            studentsList.Add(new Student(1,"Micah",40));
            studentsList.Add(new Student(2,"Pearson",50));
            studentsList.Add(new Student(3,"Jack",60));
            studentsList.Add(new Student(4,"Bill",70));
            studentsList.Add(new Student(5,"Hosea",69));
            studentsList.Add(new Student(6,"Lenny",49));
            studentsList.Add(new Student(7,"John",50));
            studentsList.Add(new Student(8,"Arthur",21));
            studentsList.Add(new Student(9,"Javier",57));
            studentsList.Add(new Student(10,"Dutch",59));
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
            Console.WriteLine("    4: Student Profile    ");
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
                    AddMark();
                    break;
                case 4:
                    DisplayProfile();
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