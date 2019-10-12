using System.Collections.Generic;

namespace useSOLIDin
{
    class FileLevelReader : IFileReader
    {
        public void GetAllData(string fileName, List<Level> levels)
        {
            string name = null;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(fileName))
            {
                while ((name = reader.ReadLine()) != null)
                {
                    levels.Add(new Level() { Name = name, Data = reader.ReadLine() });
                }
            }
        }
    }
}
