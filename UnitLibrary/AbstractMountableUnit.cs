using ObjectLibrary;

namespace UnitLibrary
{
    public class AbstractMountableUnit : UnitFactory, IMountableUnit
    {
        public IUnit MountedUnit { get; private set; }
        
        internal AbstractMountableUnit(int id, string name, int health, int move, int cost, IArmy army) : base(id, name, health, move, cost, army)
        {

        }

        public void Mount(IUnit unit)
        {
           this.MountedUnit = unit;
        }

        public void Unmount()
        {
            this.MountedUnit = null;
        }
    }
}
