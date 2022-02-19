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
        public double Miles = 1609.34;
        public double Feet = 0.3048;
        public int Metres = 1;

        public void Run()
        {
            OutputHeading();
            Console.WriteLine("from output is: " + UnitInputFrom());
            UnitInputTo();
          //  Conversion();
        }

        private static int UnitInput()
        {
            Console.WriteLine("1: Miles");
            Console.WriteLine("2: Feet");
            Console.WriteLine("3: Metres");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("User Choice is: " + userChoice);
            return userChoice;
        }
        private static int UnitInputFrom()
        {
            Console.WriteLine("Select unit type you wish to convert from:");
            return UnitInput();
        }
        private static int UnitInputTo()
        {
            Console.WriteLine("Select unit type you wish to convert to:");
            return UnitInput();
        }
        /* private static double Conversion()
        {
        double userInput = InitialInput();
        int fromInput = UnitInputFrom();
        int toInput = UnitInputTo();
        return sum;
        }
        */
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
