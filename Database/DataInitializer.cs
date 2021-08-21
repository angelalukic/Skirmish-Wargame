using System;
using System.Collections.Generic;
using System.Data;
using ActionLibrary;
using ArmyLibrary;
using FactionLibrary;
using ObjectLibrary;
using UnitLibrary;

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

        HashSet<IUnit> InitializeUnits(HashSet<IArmy> armies)
        {
            DataTable unitData = databaseData.GetUnitData();
            DataTable armyUnitsData = databaseData.GetArmyUnitsData();
            HashSet<IUnit> units = new();

            foreach (DataRow row in armyUnitsData.Rows)
            {
                int armyId = Int32.Parse(row["ArmyID"].ToString());
                int unitId = Int32.Parse(row["UnitID"].ToString());

                foreach (IArmy army in armies)
                {
                    if (army.Id == armyId)
                    {
                        // UnitID is a Primary Key, so this array will always contain one value
                        DataRow unit = unitData.Select("UnitID=" + unitId)[0];

                        int id = Int32.Parse(unit["UnitID"].ToString());
                        string name = unit["Name"].ToString();
                        int health = Int32.Parse(unit["Health"].ToString());
                        int move = Int32.Parse(unit["Move"].ToString());
                        int cost = Int32.Parse(unit["Cost"].ToString());

                        IUnit initializedUnit = UnitFactory.GetInstance(id, name, health, move, cost, army);

                        // There may be armies in the database which do not yet correspond to a class.
                        // Ignore these until they are implemented in code.
                        if (initializedUnit != null)
                        {
                            units.Add(initializedUnit);
                            army.AddUnit(initializedUnit);
                        }

                    }
                }
            }
            return units;
        }

        HashSet<IAction> InitializeActions(HashSet<IUnit> units)
        {
            DataTable actionData = databaseData.GetActionData();
            DataTable unitActionsData = databaseData.GetUnitActionsData();
            HashSet<IAction> actions = new();

            foreach (DataRow row in unitActionsData.Rows)
            {
                int unitId = Int32.Parse(row["UnitID"].ToString());
                int actionId = Int32.Parse(row["ActionID"].ToString());

                foreach (IUnit unit in units)
                {
                    if (unit.Id == unitId)
                    {
                        // ActionID is a Primary Key, so this array will always contain one value
                        DataRow action = actionData.Select("ActionID=" + actionId)[0];

                        int id = Int32.Parse(action["ActionID"].ToString());
                        string name = action["Name"].ToString();
                        string description = action["Description"].ToString();
                        bool constant = Convert.ToBoolean(Int32.Parse(action["Constant"].ToString()));
                        int range = Int32.Parse(action["Range"].ToString());

                        IAction initializedAction = ActionFactory.GetInstance(id, name, description, constant, range, unit);

                        // There may be armies in the database which do not yet correspond to a class.
                        // Ignore these until they are implemented in code.
                        if (initializedAction != null)
                        {
                            actions.Add(initializedAction);
                            unit.AddAction(initializedAction);
                        }
                    }
                }
            }
            return actions;
        }
    }
}
