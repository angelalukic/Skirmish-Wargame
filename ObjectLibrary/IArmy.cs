using System.Collections.Generic;

namespace ObjectLibrary
{
    public interface IArmy
    {
        int GetId();
        string GetName();
        string GetContributor();
        IFaction GetFaction();
        HashSet<IUnit> GetUnits();
        void AddUnit(IUnit unit);
        void RemoveUnit(IUnit unit);
    }
}
