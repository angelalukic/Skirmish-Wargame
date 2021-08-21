using ObjectLibrary;
using System.Collections.Generic;

namespace FactionLibrary
{
    public abstract class FactionFactory : IFaction
    {

        public int Id { get; }
        public string Name { get; }
        public HashSet<IArmy> Armies { get; }

        protected FactionFactory(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Armies = new();
        }

        public static IFaction GetInstance(int id, string name)
        {
            switch (name)
            {
                default:
                    return null;
                case "The Mordaunt Empire":
                    return new MordauntEmpireFaction(id, name);
                case "The Ventrasse Alliance":
                    return new VentrasseAllianceFaction(id, name);
            }
        }
        public void AddArmy(IArmy army)
        {
            Armies.Add(army);
        }

        public void RemoveArmy(IArmy army)
        {
            Armies.Remove(army);
        }

        public override string ToString()
        {
            return "ID: " + this.Id +
                ", Faction Name: " + this.Name;

        }
    }
}
