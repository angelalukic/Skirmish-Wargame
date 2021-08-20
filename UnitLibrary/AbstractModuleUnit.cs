using ObjectLibrary;
using System.Collections.Generic;

namespace UnitLibrary
{
    public class AbstractModuleUnit : AbstractUnit, IModuleUnit
    {
        private IUnit unit;

        public AbstractModuleUnit(int id, string name, int health, int move, int cost, IArmy army) : base(id, name, health, move, cost, army)
        {

        }

        public void Add(IUnit unit)
        {
            this.unit = unit;
        }

        public void Remove()
        {
            this.unit = null;
        }

        public IUnit GetHostUnit()
        {
            return unit;
        }
    }
}
