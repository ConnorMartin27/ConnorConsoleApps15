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
        //used for the from and to unit selection
        private static int UnitInput()
        {
            Console.WriteLine("1: Miles");
            Console.WriteLine("2: Feet");
            Console.WriteLine("3: Metres");
            //checks if the input is an int and returns said int if success
            bool success = Int32.TryParse(Console.ReadLine(), out int userChoice);
            if (success) {
                Console.WriteLine("User Choice is: " + userChoice);
                return userChoice;
            }
            else
            {
                Console.WriteLine("Invalid unit entered");
                //defaults to 0 on input that isn't an int
                userChoice = 0;
                return userChoice;
            }
        }

        //two methods which essentially do the same thing, ask for an input then store that input
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
        //main method which does most of the work, is responsible for the final output
        public void Conversion()
        {
            //outputs the heading
            OutputHeading();
            int fromUnit = UnitInputFrom();
            int toUnit = UnitInputTo();
            string fromDisplay;
            string toDisplay = null;
            double num = 0;
            //checks if the user selected a correct input otherwise output "invalid"
            switch (fromUnit)
            {
                case 1:
                    num = InitialInput() * 1609.34; // converts metres to miles
                    fromDisplay = "Miles";
                    break;

                case 2:
                    num = InitialInput() / 3.281; // converts metres to feet
                    fromDisplay = "Feet";
                    break;
                case 3:
                    num = InitialInput(); //no conversion needed cause default is metres
                    fromDisplay = "Metres"; 
                    break;
                default:
                    Console.WriteLine("Invalid from unit entered");
                    break;
            }
            //checks if the user selected a correct input otherwise output "invalid"
            switch (toUnit)
            {
                case 1:
                    toDisplay = "Miles";
                    num /= 1609.34;  // converts to miles
                    break;
                case 2:
                    toDisplay = "Feet";
                    num *= 3.281; // converts to feet
                    break;
                case 3:
                    toDisplay = "Metres"; //default output cause 
                    break;

                default:
                    Console.WriteLine("Invalid to unit entered");
                    break;

            }
            //3 would return in metres
            Console.WriteLine("Output is " + num + " " + toDisplay); //outputs the converted number
        }
        //is responsible for the number that the user wants  converted in the from and to conversion
        private static double InitialInput()
        {
            Console.WriteLine("Input a number wish to convert:");
            bool success = Double.TryParse(Console.ReadLine(), out double userNumber);
            if (success)
            {
                Console.WriteLine("User Choice is: " + userNumber);
                return userNumber;
            }
            else
            {
                Console.WriteLine("Invalid unit entered");
                userNumber = 0;
                return userNumber;
            }
            //Console.WriteLine("User Choice is: " + userNumber);
        }
        private static void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    Distance Converter ");
            Console.WriteLine("    This application takes two distances, and then a number,");
            Console.WriteLine("    then it outputs the first distance converted into the second");
            Console.WriteLine("     by Connor Martin                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
        }
    }
}
