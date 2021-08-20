using ObjectLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using UnitLibrary;

namespace Database
{
    // See DataInitializer.cs
    public partial class DataInitializer
    {

        HashSet<IUnit> InitializeUnits(HashSet<IArmy> armies)
        {
            DataTable unitData = databaseData.GetUnitData();
            DataTable armyUnitsData = databaseData.GetArmyUnitsData();
            HashSet<IUnit> units = new();

            foreach (DataRow row in armyUnitsData.Rows)
            {
                int armyId = Int32.Parse(row["ArmyID"].ToString());
                int unitId = Int32.Parse(row["UnitID"].ToString());

                foreach (IArmy army in armies)
                {
                    if (army.GetId() == armyId)
                    {
                        // UnitID is a Primary Key, so this array will always contain one value
                        DataRow[] unit = unitData.Select("UnitID=" + unitId);

                        IUnit initializedUnit = InitializeUnits(unit[0], army);

                        // There may be armies in the database which do not yet correspond to a class.
                        // Ignore these until they are implemented in code.
                        if (initializedUnit != null)
                        {
                            units.Add(initializedUnit);
                        }

                    }
                }
            }
            return units;
        }

        void AddUnitToArmy(IArmy army, IUnit unit)
        {
            army.AddUnit(unit);
        }

        IUnit InitializeUnits(DataRow unitData, IArmy army)
        {
            int id = Int32.Parse(unitData["UnitID"].ToString());
            string name = unitData["Name"].ToString();
            int health = Int32.Parse(unitData["Health"].ToString());
            int move = Int32.Parse(unitData["Move"].ToString());
            int cost = Int32.Parse(unitData["Cost"].ToString());

            IUnit unit;

            switch (name)
            {
                default:
                    unit = null;
                    break;

                case "Recruit":
                    unit = new RecruitUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Field Officer":
                    unit = new FieldOfficerUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Regimental Captain":
                    unit = new RegimentalCaptainUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Flag-bearer":
                    unit = new FlagBearerUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Cavalry Rider":
                    unit = new CavalryRiderUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Dusthorse":
                    unit = new DusthorseUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Distant Poet":
                    unit = new DistantPoetUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Subtle Blade":
                    unit = new SubtleBladeUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Jester":
                    unit = new JesterUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Pragma":
                    unit = new PragmaUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Philia":
                    unit = new PhiliaUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Eros":
                    unit = new ErosUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Mania":
                    unit = new ManiaUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "M-8 Ovatten Steam Engine":
                    unit = new OvattenSteamEngineUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Engineering Hardpoint":
                    unit = new EngineeringHardpointUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Motivator Drives":
                    unit = new MotivatorDrivesUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Arquebus Array":
                    unit = new ArquebusArrayUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Heavy Caliver":
                    unit = new HeavyCaliverUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Wrought Iron Slabs":
                    unit = new WroughtIronSlabsUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Temperance":
                    unit = new TemperanceUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Fortitude":
                    unit = new FortitudeUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Justice":
                    unit = new JusticeUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Prudence":
                    unit = new PrudenceUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Student":
                    unit = new StudentUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Prefect":
                    unit = new PrefectUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Professor":
                    unit = new ProfessorUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Hall-Warden":
                    unit = new HallWardenUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Druid of the Folium":
                    unit = new DruidOfTheFoliumUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Stalking Jaguar":
                    unit = new StalkingJaguarUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Dire Weasel":
                    unit = new DireWeaselUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Grand Tortoise":
                    unit = new GrandTortoiseUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Lantern":
                    unit = new LanternUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Torch":
                    unit = new TorchUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Orator":
                    unit = new OratorUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Patrician":
                    unit = new PatricianUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Bath-Warden":
                    unit = new BathWardenUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
                case "Veil":
                    unit = new VeilUnit(id, name, health, move, cost, army);
                    AddUnitToArmy(army, unit);
                    break;
            }
            return unit;
        }
    }
}
