using System.Collections.Generic;

namespace ObjectLibrary
{
    public interface IFaction
    {
        int GetId();
        string GetName();
        HashSet<IArmy> GetArmies();
        void AddArmy(IArmy army);
        void RemoveArmy(IArmy army);
    }
}
