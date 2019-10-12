using System;
using System.Threading;
using System.Collections.Generic;

namespace useSOLIDin
{
    class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            Menu m = new Menu(new Cursor(), new Swap(),new Win());
            Levels ls = new Levels(new ConsoleLevelReader(), new GeneralLevelBinder(), new GeneralLevelValidator(), new DataLevelSaver(), new FileLevelReader());
            GameBoard gameBoard = new GameBoard(new ConsoleOutPut(), new LevelNoReader(), new Coder());
            ls.LoadLevels();//load all lvls form file;
            bool isMenuShows = false;
            while (!isMenuShows)
            {
                display.DisplayMenu();
                                
                while (int.TryParse(Console.ReadLine(), out Int32 menuSelected) && menuSelected < 5)
                {
                    Console.Clear();
                    switch (menuSelected)
                    {
                        case 1:
                            Console.WriteLine($"Levels No betven 0 - {ls.LevelsInfo.Count - 1}");
                            gameBoard.GetNoValue();//choose level 
                            gameBoard.LevelData = ls.LevelsInfo[gameBoard.LevelNo].Data;
                            gameBoard.LevelName = ls.LevelsInfo[gameBoard.LevelNo].Name;
                            Console.Clear();
                            gameBoard.CodeLevel();
                            gameBoard.PrintCodedData();
                            Console.WriteLine();
                            gameBoard.PrintLevelData();
                            display.DisplayLevelName(ls, gameBoard.LevelNo);
                            m.Move(gameBoard);
                            Thread.Sleep(3000);
                            Console.Clear();

                            break;

                        case 2:
                            ls.CreatLevel();
                            break;
                        case 3:
                            display.DisplayAllLevels(ls);
                            display.Print("Press enter to return to the main menu");

                            break;
                        default:
                            break;
                    }
                }
                Console.Clear();
            }


            Console.ReadKey();
        }

    }

}
