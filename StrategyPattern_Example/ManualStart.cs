/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 11.06.2020
*/


using System;

namespace StrategyPattern_Example
{
    class ManualStart : IEngineStart
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine has started as MANUALLY");
        }
    }
}
