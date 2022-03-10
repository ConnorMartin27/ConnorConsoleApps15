using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        public void Run()
        {
            OutputHeading(); //outputs heading
            //unit type selection, limited to metric and imperial
            Console.WriteLine("Please select unit type:");
            Console.WriteLine("1: Metric");
            Console.WriteLine("2: Imperial");
            if (Int32.TryParse(Console.ReadLine(), out int unitType )) { Console.WriteLine("User Choice is: " + unitType); } else { Console.WriteLine("Invalid Unit Type Selected"); }
            //in case of metric
            if (unitType == 1)
            {
                Console.WriteLine("Please enter your weight in kg:");
                if (Double.TryParse(Console.ReadLine(), out double userWeight)) { Console.WriteLine("User Choice is: " + userWeight); } else { Console.WriteLine("Invalid Weight entered"); }

                Console.WriteLine("Please enter your height in metres:");
                if (Double.TryParse(Console.ReadLine(), out double userHeight)) { Console.WriteLine("User Choice is: " + userHeight); } else { Console.WriteLine("Invalid Height entered"); }
                double userBMI = (userWeight / (userHeight * userHeight));

                //classification
                if (userBMI < 18.5) { Console.WriteLine("WHO classifies this BMI as: Underweight"); }
                if (userBMI >= 18.5 && userBMI <= 24.9) { Console.WriteLine("WHO classifies this BMI as: Normal"); }
                if (userBMI >= 25 && userBMI <= 29.9) { Console.WriteLine("WHO classifies this BMI as: Overweight"); }
                if (userBMI >= 30 && userBMI <= 34.9) { Console.WriteLine("WHO classifies this BMI as: Obese Class 1"); }
                if (userBMI >= 35 && userBMI <= 39.9) { Console.WriteLine("WHO classifies this BMI as: Obese Class 2"); }
                if (userBMI >= 40) { Console.WriteLine("WHO classifies this BMI as: Obese Class 3"); }
                Console.WriteLine("User BMI is: " + userBMI);
            }
            //in case of imperial selected
            if (unitType == 2)
            {
                Console.WriteLine("Please enter your weight in stone then pounds:"); 
                if (Double.TryParse(Console.ReadLine(), out double userWeight)) { Console.WriteLine("User Choice is: " + userWeight); } else { Console.WriteLine("Invalid Weight entered"); }
                if (Double.TryParse(Console.ReadLine(), out double userWeightlbs)) { Console.WriteLine("User Choice is: " + userWeightlbs); } else { Console.WriteLine("Invalid Weight entered"); }
                //could just use lbs or stone but to adhere to requirements
                userWeight = (userWeight * 6.35) + (userWeightlbs / 2.205); //converts to kg 

                Console.WriteLine("Please enter your height in feet then inches:");
                if (Double.TryParse(Console.ReadLine(), out double userHeight)) { Console.WriteLine("User Choice is: " + userHeight); } else { Console.WriteLine("Invalid Height entered"); }
                if (Double.TryParse(Console.ReadLine(), out double userHeightinches)) { Console.WriteLine("User Choice is: " + userHeightinches); } else { Console.WriteLine("Invalid Weight entered"); }

                userHeight = (userHeight / 3.281) + (userHeightinches / 39.37); //converts to metres
                double userBMI = (userWeight / (userHeight * userHeight));

                //classification
                if (userBMI < 18.5) { Console.WriteLine("WHO classifies this BMI as: Underweight"); }
                if (userBMI >= 18.5 && userBMI <= 24.9) { Console.WriteLine("WHO classifies this BMI as: Normal"); }
                if (userBMI >= 25 && userBMI <= 29.9) { Console.WriteLine("WHO classifies this BMI as: Overweight"); }
                if (userBMI >= 30 && userBMI <= 34.9) { Console.WriteLine("WHO classifies this BMI as: Obese Class 1"); }
                if (userBMI >= 35 && userBMI <= 39.9) { Console.WriteLine("WHO classifies this BMI as: Obese Class 2"); }
                if (userBMI >= 40) { Console.WriteLine("WHO classifies this BMI as: Obese Class 3"); }
                Console.WriteLine("User BMI is: " + userBMI); 
            }
        }
        private static void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BMI Calculator ");
            Console.WriteLine("     by Connor Martin                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
        }
    }
}
