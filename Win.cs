using System;
using System.Text.RegularExpressions;

namespace useSOLIDin
{
    class Win : IComper
    {
        public Boolean IsMatch(String lvlData, String lvlDataToComper)
        {
            if (((Func<String, String, Boolean>)((str1, str2) => Regex.IsMatch(str1, str2)))(lvlData, lvlDataToComper))
            {
                return true;
            }
            return false;
        }
    }

}
