using System;

namespace useSOLIDin
{
    class GeneralLevelValidator : ILevelValidator
    {
        public Boolean IsValid(Level level)
        {
            if (string.IsNullOrEmpty(level.Name) || string.IsNullOrEmpty(level.Data) || level.Data.Length != 25)
            {
                return false;
            }
            return true;
        }
    }
}
