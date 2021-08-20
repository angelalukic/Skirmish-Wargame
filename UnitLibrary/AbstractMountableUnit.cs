using ObjectLibrary;
using System.Collections.Generic;

namespace UnitLibrary
{
    public class AbstractMountableUnit : AbstractUnit, IMountableUnit
    {
        private IUnit unit; 
        
        public AbstractMountableUnit(int id, string name, int health, int move, int cost, IArmy army) : base(id, name, health, move, cost, army)
        {

        }

        public void Mount(IUnit unit)
        {
           this.unit = unit;
        }

        public void Unmount()
        {
            this.unit = null;
        }

        public IUnit GetMountedUnit()
        {
            return unit;
        }
    }
}
