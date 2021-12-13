﻿
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace MLModel1_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                Name = @"Kylian Mbappé",
                Position = @"Centre-Forward",
                Age = @"22",
                Country = @"France",
                Club = @"Paris Saint-Germain",
                Goals = @"7",
                Assists = @"11",
                Yellow_Cards = @"3",
                Red_Cards = @"0",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = MLModel1.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Markey_Value_In_Millions___ with predicted Markey_Value_In_Millions___ from sample data...\n\n");


            Console.WriteLine($"Name: {@"Kylian Mbappé"}");
            Console.WriteLine($"Position: {@"Centre-Forward"}");
            Console.WriteLine($"Age: {@"22"}");
            Console.WriteLine($"Markey_Value_In_Millions___: {1440F}");
            Console.WriteLine($"Country: {@"France"}");
            Console.WriteLine($"Club: {@"Paris Saint-Germain"}");
            Console.WriteLine($"Goals: {@"7"}");
            Console.WriteLine($"Assists: {@"11"}");
            Console.WriteLine($"Yellow_Cards: {@"3"}");
            Console.WriteLine($"Red_Cards: {@"0"}");


            Console.WriteLine($"\n\nPredicted Markey_Value_In_Millions___: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
