using System.Collections.Generic;

namespace ObjectLibrary
{
    public interface IUnit
    {
        int Id { get; }
        string Name { get; }
        int BaseHealth { get; }
        int BaseMove { get; }
        int Cost { get; }
        IArmy Army { get; }
        HashSet<IAction> Actions { get; }
        void AddAction(IAction action);
        void RemoveAction(IAction action);
    }
}
