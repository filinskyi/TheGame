using System;

namespace useSOLIDin
{
    class Menu
    {

        private bool isWin;
        public ICursorInfo CursorInfo { get; set; }
        public ISwap Swap { get; set; }
        public IComper Comper { get; set; }

        public Menu(ICursorInfo cursorInfo, ISwap swap, IComper comper)
        {
            CursorInfo = cursorInfo;
            Swap = swap;
            Comper = comper;
        }

        public void Move(GameBoard board)
        {
            ConsoleKeyInfo keyInfo;

            isWin = false;
            CursorInfo.SetPos(2, 2);
            int positionLeft = Console.CursorLeft;
            int positionTop = Console.CursorTop;
            int size = 5;

            do
            {
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Spacebar:

                        Swap.SwapElementOnPosition(Console.CursorLeft, Console.CursorTop, board);
                        Console.Write(board.CodedLevelData[positionLeft + positionTop * size]);
                        break;
                    case ConsoleKey.LeftArrow:

                        positionLeft -= 1;
                        if (positionLeft < 0)
                        {
                            positionLeft = size - 1;
                        }

                        break;
                    case ConsoleKey.UpArrow:
                        positionTop -= 1;
                        if (positionTop < 0)
                        {
                            positionTop = size - 1;
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        positionLeft += 1;
                        if (positionLeft >= size)
                        {
                            positionLeft -= size;
                        }

                        break;
                    case ConsoleKey.DownArrow:
                        positionTop += 1;
                        if (positionTop >= size)
                        {
                            positionTop -= size;
                        }

                        break;
                }
                CursorInfo.SetPos(positionLeft, positionTop);
                if (Comper.IsMatch(board.LevelData, board.CodedLevelData))
                {
                    isWin = true;

                }


            } while (keyInfo.Key != ConsoleKey.Escape && !isWin);
            CursorInfo.SetPos(9, 9);
            
            Console.Write($"Win");// remove cw => move to Display
        }
    }

}
