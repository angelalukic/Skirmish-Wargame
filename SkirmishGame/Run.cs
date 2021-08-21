using Database;
using ObjectLibrary;
using System;
using System.Collections.Generic;

namespace SkirmishGame
{
    class Run
    {

        static void Main(string[] args)
        {
            SkirmishDatabaseData databaseData = new();
            DataInitializer initializer = new(databaseData);
            SkirmishData data = initializer.Initialize();

            HashSet<IFaction> factions = data.GetFactions();

            foreach (IFaction faction in factions)
            {
                Console.WriteLine(faction.Name);

                foreach (IArmy army in faction.Armies)
                {
                    Console.WriteLine("\t" + army.Name);

                    foreach (IUnit unit in army.Units)
                    {
                        Console.WriteLine("\t\t" + unit.GetName());

                        foreach (IAction action in unit.GetActions())
                        {
                            Console.WriteLine("\t\t\t" + action.Name);
                        }
                    }
                }
            }
        }
    }
}
