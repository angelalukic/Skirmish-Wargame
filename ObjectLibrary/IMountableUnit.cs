using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public interface IMountableUnit
    {
        void Mount(IUnit unit);
        void Unmount();
        IUnit GetMountedUnit(); 
    }
}
