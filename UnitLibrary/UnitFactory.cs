using System.Collections.Generic;
using ObjectLibrary;

namespace UnitLibrary
{
    public abstract class UnitFactory : IUnit
    {
        public int Id { get; }
        public string Name { get; }
        public int BaseHealth { get; }
        public int BaseMove { get; }
        public int Cost { get; }
        public IArmy Army { get; }
        public HashSet<IAction> Actions { get; }

        protected UnitFactory(int id, string name, int health, int move, int cost, IArmy army)
        {
            this.Id = id;
            this.Name = name;
            this.BaseHealth = health;
            this.BaseMove = move;
            this.Cost = cost;
            this.Army = army;
            Actions = new();
        }

        public static IUnit GetInstance(int id, string name, int health, int move, int cost, IArmy army)
        {
            switch(name)
            {
                default:
                    return null;
                case "Recruit":
                    return new RecruitUnit(id, name, health, move, cost, army);
                case "Field Officer":
                    return new FieldOfficerUnit(id, name, health, move, cost, army);
                case "Regimental Captain":
                    return new RegimentalCaptainUnit(id, name, health, move, cost, army);
                case "Flag-bearer":
                    return new FlagBearerUnit(id, name, health, move, cost, army);
                case "Cavalry Rider":
                    return new CavalryRiderUnit(id, name, health, move, cost, army);
                case "Dusthorse":
                    return new DusthorseUnit(id, name, health, move, cost, army);
                case "Distant Poet":
                    return new DistantPoetUnit(id, name, health, move, cost, army);
                case "Subtle Blade":
                    return new SubtleBladeUnit(id, name, health, move, cost, army);
                case "Jester":
                    return new JesterUnit(id, name, health, move, cost, army);
                case "Pragma":
                    return new PragmaUnit(id, name, health, move, cost, army);
                case "Philia":
                    return new PhiliaUnit(id, name, health, move, cost, army);
                case "Eros":
                    return new ErosUnit(id, name, health, move, cost, army);
                case "Mania":
                    return new ManiaUnit(id, name, health, move, cost, army);
                case "M-8 Ovatten Steam Engine":
                    return new OvattenSteamEngineUnit(id, name, health, move, cost, army);
                case "Engineering Hardpoint":
                    return new EngineeringHardpointUnit(id, name, health, move, cost, army);
                case "Motivator Drives":
                    return new MotivatorDrivesUnit(id, name, health, move, cost, army);
                case "Arquebus Array":
                    return new ArquebusArrayUnit(id, name, health, move, cost, army);
                case "Heavy Caliver":
                    return new HeavyCaliverUnit(id, name, health, move, cost, army);
                case "Wrought Iron Slabs":
                    return new WroughtIronSlabsUnit(id, name, health, move, cost, army);
                case "Temperance":
                    return new TemperanceUnit(id, name, health, move, cost, army);
                case "Fortitude":
                    return new FortitudeUnit(id, name, health, move, cost, army);
                case "Justice":
                    return new JusticeUnit(id, name, health, move, cost, army);
                case "Prudence":
                    return new PrudenceUnit(id, name, health, move, cost, army);
                case "Student":
                    return new StudentUnit(id, name, health, move, cost, army);
                case "Prefect":
                    return new PrefectUnit(id, name, health, move, cost, army);
                case "Professor":
                    return new ProfessorUnit(id, name, health, move, cost, army);
                case "Hall-Warden":
                    return new HallWardenUnit(id, name, health, move, cost, army);
                case "Druid of the Folium":
                    return new DruidOfTheFoliumUnit(id, name, health, move, cost, army);
                case "Stalking Jaguar":
                    return new StalkingJaguarUnit(id, name, health, move, cost, army);
                case "Dire Weasel":
                    return new DireWeaselUnit(id, name, health, move, cost, army);
                case "Grand Tortoise":
                    return new GrandTortoiseUnit(id, name, health, move, cost, army);
                case "Lantern":
                    return new LanternUnit(id, name, health, move, cost, army);
                case "Torch":
                    return new TorchUnit(id, name, health, move, cost, army);
                case "Orator":
                    return new OratorUnit(id, name, health, move, cost, army);
                case "Patrician":
                    return new PatricianUnit(id, name, health, move, cost, army);
                case "Bath-Warden":
                    return new BathWardenUnit(id, name, health, move, cost, army);
                case "Veil":
                    return new VeilUnit(id, name, health, move, cost, army);
            }
        }

        public void AddAction(IAction action)
        {
            Actions.Add(action);
        }

        public void RemoveAction(IAction action)
        {
            Actions.Remove(action);
        }
    }
}
