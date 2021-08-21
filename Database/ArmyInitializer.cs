using System;
using System.Collections.Generic;
using System.Data;
using ArmyLibrary;
using ObjectLibrary;

namespace Database
{
    // See DataInitializer.cs
    public partial class DataInitializer
    {
        HashSet<IArmy> InitializeArmies(HashSet<IFaction> factions)
        {
            DataTable armyData = databaseData.GetArmyData();
            DataTable factionArmiesData = databaseData.GetFactionArmiesData();
            HashSet<IArmy> armies = new();

            foreach (DataRow row in factionArmiesData.Rows)
            {
                int factionId = Int32.Parse(row["FactionID"].ToString());
                int armyId = Int32.Parse(row["ArmyID"].ToString());

                foreach (IFaction faction in factions)
                {
                    if (faction.Id == factionId)
                    {
                        // ArmyID is a Primary Key, so this array will always contain one value
                        DataRow[] army = armyData.Select("ArmyID=" + armyId);

                        IArmy initializedArmy = InitializeArmy(army[0], faction);

                        // There may be armies in the database which do not yet correspond to a class.
                        // Ignore these until they are implemented in code.
                        if(initializedArmy != null)
                        {
                            armies.Add(initializedArmy);
                        }
                    }
                }
            }
            return armies;
        }

        void AddArmyToFaction(IFaction faction, IArmy army)
        {
            faction.AddArmy(army);
        }

        IArmy InitializeArmy(DataRow armyData, IFaction faction)
        {

            int id = Int32.Parse(armyData["ArmyID"].ToString());
            string name = armyData["Name"].ToString();
            string contributor = armyData["Contributor"].ToString();

            IArmy army;

            switch (name)
            {
                default:
                    army = null;
                    break;

                case "Mordaunt 1st Regiment":
                    army = new MordauntFirstRegimentArmy(id, name, contributor, faction);
                    AddArmyToFaction(faction, army);
                    break;

                case "Honywood Battalion":
                    army = new HonywoodBattalionArmy(id, name, contributor, faction);
                    AddArmyToFaction(faction, army);
                    break;

                case "Cordelian Troupe":
                    army = new CordelianTroupeArmy(id, name, contributor, faction);
                    AddArmyToFaction(faction, army);
                    break;

                case "Marital Knights":
                    army = new MaritalKnightsArmy(id, name, contributor, faction);
                    AddArmyToFaction(faction, army);
                    break;

                case "Machinist Core":
                    army = new MachinistCoreArmy(id, name, contributor, faction);
                    AddArmyToFaction(faction, army);
                    break;

                case "Alliance Heartsworn":
                    army = new AllianceHeartswornArmy(id, name, contributor, faction);
                    AddArmyToFaction(faction, army);
                    break;

                case "Arcadia Academy":
                    army = new ArcadiaAcademyArmy(id, name, contributor, faction);
                    AddArmyToFaction(faction, army);
                    break;

                case "Folium Gardiani":
                    army = new FoliumGardianiArmy(id, name, contributor, faction);
                    AddArmyToFaction(faction, army);
                    break;

                case "Amber Adepts":
                    army = new AmberAdeptsArmy(id, name, contributor, faction);
                    AddArmyToFaction(faction, army);
                    break;

                case "Marble Assassins":
                    army = new MarbleAssassinsArmy(id, name, contributor, faction);
                    AddArmyToFaction(faction, army);
                    break;
            }
            return army;
        }
    }
}
