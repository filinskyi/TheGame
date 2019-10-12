using System;

namespace useSOLIDin
{
    class GeneralLevelBinder : ILevelBinder
    {
        public Level CreateLevel(String[] data)
        {
            if (data.Length == 2)
            {
                if (data[1] != null) return new Level { Name = data[0], Data = data[1] };

                throw new Exception("Data Level is empty");

            }
            throw new Exception("Level INFO is empty");
        }
    }
}
