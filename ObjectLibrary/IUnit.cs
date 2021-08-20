using System.Collections.Generic;

namespace ObjectLibrary
{
    public interface IUnit
    {
        int GetId();
        string GetName();
        int GetHealth();
        int GetMove();
        int GetCost();
        IArmy GetArmy();
        HashSet<IAction> GetActions();
        void AddAction(IAction action);
        void RemoveAction(IAction action);
    }
}
