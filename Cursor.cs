using System;

namespace useSOLIDin
{
    class Cursor : ICursorInfo
    {
        public void SetPos(int cpl, int cpt)
        {
            Console.CursorLeft = cpl;
            Console.CursorTop = cpt;
        }
    }

}
