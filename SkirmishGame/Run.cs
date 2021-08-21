using Database;
using System;

namespace SkirmishGame
{
    class Run
    {

        static void Main(string[] args)
        {
            SkirmishDatabaseData databaseData = new();
            DataInitializer initializer = new(databaseData);
            SkirmishData data = initializer.Initialize();
            Console.WriteLine(data);
        }
    }
}
