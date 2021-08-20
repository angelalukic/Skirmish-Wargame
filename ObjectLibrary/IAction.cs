using System.Collections.Generic;

namespace ObjectLibrary
{
    public interface IAction
    {
        int GetId();
        string GetName();
        string GetDescription();
        bool GetConstant();
        int GetRange();
        IUnit GetUnit();
    }
}
