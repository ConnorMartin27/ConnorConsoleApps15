using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Connor Martin version 0.2
    /// </author>
    public class DistanceConverter
    {
        public string fromDisplay;
        public void Run()
        {
           
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
        public void Conversion()
        {
            OutputHeading();
            int fromUnit = UnitInputFrom();
            int toUnit = UnitInputTo();
            string fromDisplay;
            string toDisplay = null;
            double num = 0;
            if (fromUnit == 1) { 
                num = InitialInput() * 1609.34;
                fromDisplay = "Miles";
            }
            if (fromUnit == 2) { 
                num = InitialInput() / 3.281;
                fromDisplay = "Feet";
            }
            if (fromUnit == 3) { 
                num = InitialInput();
                fromDisplay = "Metres";
            }


            if (toUnit == 1) {
                toDisplay = "Miles";
                num /= 1609.34; 
            }
            if (toUnit == 2) {
                toDisplay = "Feet";
                num *= 3.281; 
            }
            if (toUnit == 3) { toDisplay = "Metres"; }
            //3 would return in metres
            Console.WriteLine("Output is " + num + " " + toDisplay);
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
