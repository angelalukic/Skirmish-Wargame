namespace ObjectLibrary
{
    public interface IModuleUnit
    {
        void Add(IUnit unit);

        void Remove();

        IUnit GetHostUnit();
    }
}
