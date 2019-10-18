using System;
using System.Text.RegularExpressions;

namespace useSOLIDin
{
    class Win : IComper
    {
        public bool IsMatch(string lvlData, string lvlDataToComper)
        {
            return ((Func<string, string, bool>)((str1, str2) => Regex.IsMatch(str1, str2)))(lvlData, lvlDataToComper);
        }
    }
}
