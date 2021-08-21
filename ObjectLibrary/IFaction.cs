using System.Collections.Generic;

namespace ObjectLibrary
{
    public interface IFaction
    {
        int Id { get; }
        string Name { get; }
        HashSet<IArmy> Armies { get; }
        void AddArmy(IArmy army);
        void RemoveArmy(IArmy army);
    }
}
