using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public interface IMountableUnit
    {
        IUnit MountedUnit { get; }
        void Mount(IUnit unit);
        void Unmount();
    }
}
