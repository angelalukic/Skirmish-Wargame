using System.Collections.Generic;
using ObjectLibrary;

namespace Database
{
    public class SkirmishData
    {
        private readonly HashSet<IFaction> factions;
        private readonly HashSet<IArmy> armies;
        private readonly HashSet<IUnit> units;
        private readonly HashSet<IAction> actions;

        public SkirmishData(HashSet<IFaction> factions, HashSet<IArmy> armies, HashSet<IUnit> units, HashSet<IAction> actions)
        {
            this.factions = factions;
            this.armies = armies;
            this.units = units;
            this.actions = actions;
        }

        public HashSet<IFaction> GetFactions()
        {
            return factions;
        }

        public HashSet<IArmy> GetArmies()
        {
            return armies;
        }

        public HashSet<IUnit> GetUnits()
        {
            return units;
        }

        public HashSet<IAction> GetActions()
        {
            return actions;
        }
    }
}
