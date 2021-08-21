using System.Collections.Generic;
using System.Text;
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

        public override string ToString()
        {
            StringBuilder str = new();
            str.Append("Factions:\n");
            foreach(IFaction faction in this.factions)
            {
                str.Append(faction + "\n");
                str.Append("\tArmies:\n");
                foreach(IArmy army in faction.Armies)
                {
                    str.Append("\t" + army + "\n");
                    str.Append("\t\tUnits:\n");
                    foreach(IUnit unit in army.Units)
                    {
                        str.Append("\t\t" + unit + "\n");
                        str.Append("\t\t\tActions:\n");
                        foreach(IAction action in unit.Actions)
                        {
                            str.Append("\t\t\t" + action + "\n");
                        }
                    }
                }
            }
            return str.ToString();
        }
    }
}
