namespace ObjectLibrary
{
    public interface IModuleUnit
    {
        IUnit HostUnit { get; }
        void Add(IUnit unit);
        void Remove();
    }
}
