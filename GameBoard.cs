using System;
using System.Text.RegularExpressions;

namespace useSOLIDin
{
    class GameBoard
    {
        public String CodedLevelData { get; set; }

        public string LevelName { get; set; }
        public string LevelData { get; set; }
        public int LevelNo { get; set; }
        public IOutPut OutPut { get; set; }
        public INoReader NoReader { get; set; }
        public ICode Code { get; set; }
        public GameBoard(IOutPut outPut, INoReader noReader, ICode code)
        {
            OutPut = outPut;
            NoReader = noReader;
            Code = code;

        }
        public void PrintLevelName() => OutPut.Print(this.LevelName);
        public void PrintLevelData()
        {
            string pattern = @"[x|o]{5}";
            MatchCollection matchCollection = Regex.Matches(LevelData, pattern);
            foreach (Match match in matchCollection)
            {
                OutPut.Print(match.Value);

            }
        }
        public void PrintCodedData()
        {
            string pattern = @"[x|o]{5}";
            MatchCollection matchCollection = Regex.Matches(CodedLevelData, pattern);
            foreach (Match match in matchCollection)
            {
                OutPut.Print(match.Value);

            }
        }
        public void GetNoValue()
        {
            Console.WriteLine("Enter Level No: ");
            LevelNo = NoReader.No;

        }
        public void OnPublished(object source, EventArgs args)
        {
            PrintLevelData();
        }
        public void CodeLevel()
        {
            Code.Code(this);
        }
    }
}
