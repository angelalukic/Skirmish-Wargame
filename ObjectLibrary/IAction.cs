using System.Collections.Generic;

namespace ObjectLibrary
{
    public interface IAction
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
        bool Constant { get; }
        int Range { get; }
        IUnit Unit { get; }
    }
}
