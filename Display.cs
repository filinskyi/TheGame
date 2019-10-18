using System;
using System.Text.RegularExpressions;

namespace useSOLIDin
{
    class Display : IDisplay
    {
        private readonly string[] menuInfo = new string[] { "1.Start Game", "2.CreatLevel", "3.Show Levels", "4." };
        public int MenuLenght { get; }
        public Display()
        {
            MenuLenght = menuInfo.Length;
        }

        public void DisplayAllLevels(Levels levels)
        {
            for (int i = 0; i < levels.LevelsInfo.Count; i++)
            {
                DisplayLevelName(levels, i);
                DisplayLevelData(levels, i);
                Print("");

            }
        }

        public void DisplayLevelData(Levels levels, int levelNo)
        {
            string pattern = @"[x|o]{5}";
            MatchCollection matchCollection = Regex.Matches(levels.LevelsInfo[levelNo].Data, pattern);
            foreach (Match match in matchCollection)
            {
                Print(match.Value);
            }
        }

        public void DisplayLevelName(Levels levels, int levelName)
        {
            Print(levels.LevelsInfo[levelName].Name);
        }

        public void DisplayMenu()
        {
            foreach (var item in menuInfo)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
        }


    }

}
