using System.Collections.Generic;

namespace ObjectLibrary
{
    public interface IArmy
    {
        int Id { get; }
        string Name { get; }
        string Contributor { get; }
        IFaction Faction { get; }
        HashSet<IUnit> Units { get; }
        void AddUnit(IUnit unit);
        void RemoveUnit(IUnit unit);
    }
}
