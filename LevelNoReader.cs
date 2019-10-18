using System;

namespace useSOLIDin
{
    class LevelNoReader : INoReader
    {
        private int lvlNumebr;
        public int No
        {
            get
            {
                int.TryParse(Console.ReadLine(), out lvlNumebr);
                return lvlNumebr;
            }
        }
    }
}
