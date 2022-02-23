using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        public static double miles = 1609.34;
        public static double feet = 0.3048;
        public static double metres = 1;

        public void Run()
        {
            OutputHeading();
            Console.WriteLine("Output is: " + Conversion());
        }

        private static double UnitInput()
        {
            Console.WriteLine("1: Miles");
            Console.WriteLine("2: Feet");
            Console.WriteLine("3: Metres");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            double choice = 0;
            if (userChoice == 1) { choice = miles; }
            else if (userChoice == 2) { choice = feet; }
            else if (userChoice == 3) { choice = metres; }
            //Console.WriteLine("User Choice is: " + userChoice);
            return choice;
        }

        private static double UnitInputFrom()
        {
            Console.WriteLine("Select unit type you wish to convert from:");
            return UnitInput();
        }
        private static double UnitInputTo()
        {
            Console.WriteLine("Select unit type you wish to convert to:");
            return UnitInput();
        }
        private static double Conversion()
        {
        double sum = (InitialInput() * UnitInputFrom()) * UnitInputTo();
        return sum;
        }
       
        private static double InitialInput()
        {
            Console.WriteLine("Input a number wish to convert:");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("User Choice is: " + userNumber);
            return userNumber;
        }
        private static void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    Distance Converter ");
            Console.WriteLine("        by Connor Martin                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
        }
    }
}
