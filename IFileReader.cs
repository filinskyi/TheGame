using System.Collections.Generic;

namespace useSOLIDin
{
    interface IFileReader
    {
        void GetAllData(string fileName, List<Level> levels);
    }
}
