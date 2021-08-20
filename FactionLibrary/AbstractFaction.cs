using System.Collections.Generic;
using ObjectLibrary;

namespace FactionLibrary
{
    public abstract class AbstractFaction : IFaction
    {
        private readonly int id;
        private readonly string name;
        internal HashSet<IArmy> armies;

        protected AbstractFaction(int id,  string name)
        {
            this.id = id;
            this.name = name;
            armies = new();
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public HashSet<IArmy> GetArmies()
        {
            return armies;
        }

        public void AddArmy(IArmy army)
        {
            armies.Add(army);
        }

        public void RemoveArmy(IArmy army)
        {
            armies.Remove(army);
        }
    }
}
