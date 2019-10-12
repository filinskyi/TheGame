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
                //temp = gb.LevelData.ToCharArray();
                // Console.WriteLine($"pos {randomPos} chOr {charInRandomPosithion}");
                charInRandomPosithion = charInRandomPosithion == 'x' ? 'o' : 'x';
                //.WriteLine(charInRandomPosithion);
                temp[randomPos] = charInRandomPosithion;
                counter++;

            } while (counter != 21);
            gb.CodedLevelData = new string(temp);

        }
    }

}
