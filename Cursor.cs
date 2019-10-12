using System;

namespace useSOLIDin
{
    class Cursor : ICursorInfo
    {
        public void SetPos(Int32 cpl, Int32 cpt)
        {
            Console.CursorLeft = cpl;
            Console.CursorTop = cpt;
        }
    }

}
