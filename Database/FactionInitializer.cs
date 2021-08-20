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
            IFaction faction;
            HashSet<IFaction> factions = new();
            foreach (DataRow row in factionData.Rows)
            {
                int id = Int32.Parse(row["FactionID"].ToString());
                string name = row["Name"].ToString();
                switch (name)
                {
                    case "The Mordaunt Empire":
                        faction = new MordauntEmpireFaction(id, name);
                        factions.Add(faction);
                        break;
                    case "The Ventrasse Alliance":
                        faction = new VentrasseAllianceFaction(id, name);
                        factions.Add(faction);
                        break;
                }
            }
            return factions;
        }
    }
}
