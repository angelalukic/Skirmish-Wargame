 using System.Collections.Generic;
using ObjectLibrary;

namespace ArmyLibrary
{
    public abstract class AbstractArmy : IArmy
    {
        private readonly int id;
        private readonly string name;
        private readonly string contributor;
        private readonly IFaction faction;
        internal HashSet<IUnit> units;

        public AbstractArmy(int id, string name, string contributor, IFaction faction)
        {
            this.id = id;
            this.name = name;
            this.contributor = contributor;
            this.faction = faction;
            units = new();
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }
        public string GetContributor()
        {
            return contributor;
        }

        public IFaction GetFaction()
        {
            return faction;
        }

        public HashSet<IUnit> GetUnits()
        {
            return units;
        }

        public void AddUnit(IUnit unit)
        {
            units.Add(unit);
        }

        public void RemoveUnit (IUnit unit)
        {
            units.Remove(unit);
        }
    }
}
