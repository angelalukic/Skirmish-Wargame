using ObjectLibrary;

namespace UnitLibrary
{
    public class AbstractModuleUnit : UnitFactory, IModuleUnit
    {
        public IUnit HostUnit { get; private set; }

        internal AbstractModuleUnit(int id, string name, int health, int move, int cost, IArmy army) : base(id, name, health, move, cost, army)
        {

        }

        public void Add(IUnit unit)
        {
            this.HostUnit = unit;
        }

        public void Remove()
        {
            this.HostUnit = null;
        }
    }
}
