 using System.Collections.Generic;
using ObjectLibrary;

namespace ArmyLibrary
{
    public abstract class ArmyFactory : IArmy
    {
        public int Id { get; }
        public string Name { get; }
        public string Contributor { get; }
        public IFaction Faction { get; }
        public HashSet<IUnit> Units { get; }

        public ArmyFactory(int id, string name, string contributor, IFaction faction)
        {
            this.Id = id;
            this.Name = name;
            this.Contributor = contributor;
            this.Faction = faction;
            this.Units = new();
        }

        public static IArmy GetInstance(int id, string name, string contributor, IFaction faction)
        {
            switch (name)
            {
                default:
                    return null;
                case "Mordaunt 1st Regiment":
                    return new MordauntFirstRegimentArmy(id, name, contributor, faction);
                case "Honywood Battalion":
                    return new HonywoodBattalionArmy(id, name, contributor, faction);
                case "Cordelian Troupe":
                    return new CordelianTroupeArmy(id, name, contributor, faction);
                case "Marital Knights":
                    return new MaritalKnightsArmy(id, name, contributor, faction);
                case "Machinist Core":
                    return new MachinistCoreArmy(id, name, contributor, faction);
                case "Alliance Heartsworn":
                    return new AllianceHeartswornArmy(id, name, contributor, faction);
                case "Arcadia Academy":
                    return new ArcadiaAcademyArmy(id, name, contributor, faction);
                case "Folium Gardiani":
                    return new FoliumGardianiArmy(id, name, contributor, faction);
                case "Amber Adepts":
                    return new AmberAdeptsArmy(id, name, contributor, faction);
                case "Marble Assassins":
                    return new MarbleAssassinsArmy(id, name, contributor, faction);
            }
        }

        public void AddUnit(IUnit unit)
        {
            Units.Add(unit);
        }

        public void RemoveUnit (IUnit unit)
        {
            Units.Remove(unit);
        }
    }
}
