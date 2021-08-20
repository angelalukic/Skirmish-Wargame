using ObjectLibrary;
using System.Collections.Generic;

namespace ActionLibrary
{
    public abstract class AbstractAction : IAction
    {
        
        private readonly int id;
        private readonly string name;
        private readonly string description;
        private readonly bool constant;
        private readonly int range;
        private readonly IUnit unit;

        public AbstractAction(int id, string name, string description, bool constant, int range, IUnit unit)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.constant = constant;
            this.range = range;
            this.unit = unit;
        }

        public int GetId()
        {
            return id;
        }

         public string GetName()
        {
            return name;
        }

        public string GetDescription()
        {
            return description;
        }

        public bool GetConstant()
        {
            return constant;
        }

        public int GetRange()
        {
            return range;
        }

        public IUnit GetUnit()
        {
            return unit;
        }
    }
}
