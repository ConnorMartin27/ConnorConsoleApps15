using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    ///Connor Martin 17/02/2022
    /// </summary>
    public static class Program
    {

    public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Connor Martin                          ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" =================================================   ");
            Console.WriteLine("    Please choose the application you wish to launch ");
            Console.WriteLine("    1: Distance Convert                              ");
            Console.WriteLine("    2: BMI Calculator                                ");
            Console.WriteLine("    3: Student Grades                                ");
            Console.WriteLine(" =================================================   ");
            Console.WriteLine();
            bool success = Int32.TryParse(Console.ReadLine(), out int userChoice);
            switch (userChoice)
            {
                case 1:
                    DistanceConverter converter = new DistanceConverter();
                    converter.Conversion();
                break;
                case 2:
                    BMI bmi = new BMI();
                    bmi.Run();
                break;
                case 3:
                    StudentGrades studentGrades = new StudentGrades();
                    studentGrades.Run();
                break;
            }

        }
    }
}
