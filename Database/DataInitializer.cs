using System.Collections.Generic;
using System.Data;
using ObjectLibrary;

namespace Database
{
    // Other parts of this class are large switch statements
    // See: FactionInitializer.cs, ArmyInitializer.cs, etc.
    public partial class DataInitializer
    {
        private readonly SkirmishDatabaseData databaseData;

        public DataInitializer(SkirmishDatabaseData databaseData)
        {
            this.databaseData = databaseData;
        }

        public SkirmishData Initialize()
        {
            HashSet <IFaction> factions = InitializeFactions();
            HashSet<IArmy> armies = InitializeArmies(factions);
            HashSet<IUnit> units = InitializeUnits(armies);

            return new SkirmishData(factions, armies, units, null);
        }
    }
}
