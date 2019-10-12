using System;

namespace useSOLIDin
{
    class ConsoleOutPut : IOutPut
    {
        public void Print(String text)
        {
            Console.WriteLine(text);
        }
    }
}
