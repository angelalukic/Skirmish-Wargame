using System;
using System.Collections.Generic;
using System.Data;
using ArmyLibrary;
using FactionLibrary;
using ObjectLibrary;

namespace Database
{
    public partial class DataInitializer
    {
        private readonly SkirmishDatabaseData databaseData;

        public DataInitializer(SkirmishDatabaseData databaseData)
        {
            this.databaseData = databaseData;
        }

        public SkirmishData Initialize()
        {
            HashSet <IFaction> factions = InitializeFactions();
            HashSet<IArmy> armies = InitializeArmies(factions);
            HashSet<IUnit> units = InitializeUnits(armies);
            HashSet<IAction> actions = InitializeActions(units);

            return new SkirmishData(factions, armies, units, actions);
        }

        HashSet<IFaction> InitializeFactions()
        {
            DataTable factionData = databaseData.GetFactionData();
            HashSet<IFaction> factions = new();
            foreach (DataRow row in factionData.Rows)
            {
                int id = Int32.Parse(row["FactionID"].ToString());
                string name = row["Name"].ToString();
                IFaction faction = FactionFactory.GetInstance(id, name);
                factions.Add(faction);
            }
            return factions;
        }

        HashSet<IArmy> InitializeArmies(HashSet<IFaction> factions)
        {
            DataTable armyData = databaseData.GetArmyData();
            DataTable factionArmiesData = databaseData.GetFactionArmiesData();
            HashSet<IArmy> armies = new();

            foreach (DataRow row in factionArmiesData.Rows)
            {
                int factionId = Int32.Parse(row["FactionID"].ToString());
                int armyId = Int32.Parse(row["ArmyID"].ToString());

                foreach (IFaction faction in factions)
                {
                    if (faction.Id == factionId)
                    {
                        // ArmyID is a Primary Key, so this array will always contain one value
                        DataRow army = armyData.Select("ArmyID=" + armyId)[0];

                        int id = Int32.Parse(army["ArmyID"].ToString());
                        string name = army["Name"].ToString();
                        string contributor = army["Contributor"].ToString();

                        IArmy initializedArmy = ArmyFactory.GetInstance(id, name, contributor, faction);

                        // There may be armies in the database which do not yet correspond to a class.
                        // Ignore these until they are implemented in code.
                        if (initializedArmy != null)
                        {
                            armies.Add(initializedArmy);
                            faction.AddArmy(initializedArmy);
                        }
                    }
                }
            }
            return armies;
        }
    }
}
