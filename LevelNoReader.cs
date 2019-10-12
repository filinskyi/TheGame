using System;

namespace useSOLIDin
{
    class LevelNoReader : INoReader
    {
        private int lvlNumebr;
        public Int32 No
        {
            get
            {
                int.TryParse(Console.ReadLine(), out lvlNumebr);
                return lvlNumebr;
            }
        }
    }
}
