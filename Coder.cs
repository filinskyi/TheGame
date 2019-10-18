using System;

namespace useSOLIDin
{
    class Coder : ICode
    {
        public void Code(GameBoard gb)
        {
            Random random = new Random();
            int counter = 0;
            char[] temp = gb.LevelData.ToCharArray();

            do
            {
                int randomPos = random.Next(temp.Length - 1);
                char charInRandomPosithion = temp[randomPos];
                charInRandomPosithion = charInRandomPosithion == 'x' ? 'o' : 'x';
                temp[randomPos] = charInRandomPosithion;
                counter++;

            } while (counter != 21);
            gb.CodedLevelData = new string(temp);

        }
    }

}
