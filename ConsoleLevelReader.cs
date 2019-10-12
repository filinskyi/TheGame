using System;

namespace useSOLIDin
{
    class ConsoleLevelReader : ILevelReader
    {
        public String[] GetInputData()
        {
            Console.WriteLine("Enter level name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter level data:");
            string data = Console.ReadLine();
            return new string[] { name, data };
        }
    }
}
