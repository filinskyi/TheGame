using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
namespace useSOLIDin
{
    class Levels
    {
        
        const string pathToFile = @"..\..\Levels.txt";
        public ILevelReader LevelReader { get; set; }
        public ILevelBinder LevelBinder { get; set; }
        public ILevelValidator LevelValidator { get; set; }
        public ILevelSaver LevelSaver { get; set; }
        public IFileReader FileReader { get; set; }
        public List<Level> LevelsInfo { get; } = new List<Level>();

        public Levels(ILevelReader levelReader, ILevelBinder levelBinder, ILevelValidator levelValidator, ILevelSaver levelSaver, IFileReader fileReader)
        {
            this.LevelReader = levelReader;
            this.LevelBinder = levelBinder;
            this.LevelValidator = levelValidator;
            this.LevelSaver = levelSaver;
            this.FileReader = fileReader;

        }
        public void CreatLevel()
        {
            string[] data = LevelReader.GetInputData();
            Level level = LevelBinder.CreateLevel(data);
            if (LevelValidator.IsValid(level))
            {
                LevelsInfo.Add(level);
                LevelSaver.Save(level, pathToFile);
                
                Console.WriteLine("Level created and saved.."); // remove CW from BL
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("level info is wrong");// remove CW from BL
            }
        }
        public void LoadLevels() => FileReader.GetAllData(pathToFile, LevelsInfo); 

    }
}
