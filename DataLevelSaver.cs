using System;

namespace useSOLIDin
{
    class DataLevelSaver : ILevelSaver
    {
        public void Save(Level level, String fileName)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, true))
            {
                writer.WriteLine(level.Name);
                writer.WriteLine(level.Data);
            }
        }
    }
}
