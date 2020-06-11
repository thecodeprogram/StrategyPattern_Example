/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 11.06.2020
*/

using System;

namespace StrategyPattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "trategy Design Pattern Example - Thecodeprogram";
       
            //First I will create interface component
            IEngineStart engineStart = null;

            //And I will get the method selection
            Console.WriteLine("Please enter start strategy : ");
            string start_procedure = Console.ReadLine();

            //Then I will start the engine according to user selection
            if (start_procedure == "auto")
            {
                engineStart = new AutomaticStart();
            }
            else if (start_procedure == "manual")
            {
                engineStart = new ManualStart();
            }

            engineStart.StartEngine();

            Console.ReadLine();
        }
    }
}
