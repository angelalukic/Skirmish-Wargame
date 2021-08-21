using System;
using System.Collections.Generic;
using System.Data;
using FactionLibrary;
using ObjectLibrary;

namespace Database
{
    // See DataInitializer.cs
    public partial class DataInitializer
    {
        HashSet<IFaction> InitializeFactions()
        {
            DataTable factionData = databaseData.GetFactionData();
            HashSet<IFaction> factions = new();
            foreach (DataRow row in factionData.Rows)
            {
                int id = Int32.Parse(row["FactionID"].ToString());
                string name = row["Name"].ToString();
                IFaction faction = FactionFactory.GetInstance(id, name);
                factions.Add(faction);
            }
            return factions;
        }
    }
}
