using System;

namespace useSOLIDin
{
    class Swap : ISwap
    {
        public void SwapElementOnPosition(Int32 cpl, Int32 cpt, GameBoard gb)
        {
            int pos = cpl + cpt * (int)Math.Sqrt(gb.CodedLevelData.Length);
            char charInPos = gb.CodedLevelData[pos];
            char[] temp = gb.CodedLevelData.ToCharArray();
            charInPos = charInPos == 'x' ? 'o' : 'x';
            temp[pos] = charInPos;
            gb.CodedLevelData = new string(temp);
        }

    }

}
