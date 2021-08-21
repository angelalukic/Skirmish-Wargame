using ObjectLibrary;
using System.Collections.Generic;

namespace ActionLibrary
{
    public abstract class ActionFactory : IAction
    {

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public bool Constant { get; }
        public int Range { get; }
        public IUnit Unit { get; }

        protected ActionFactory(int id, string name, string description, bool constant, int range, IUnit unit)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Constant = constant;
            this.Range = range;
            this.Unit = unit;
        }

        public static IAction GetInstance(int id, string name, string description, bool constant, int range, IUnit unit)
        {
            switch (name)
            {
                default:
                    return null;
                case "Truncheons Out":
                    return new TruncheonsOutAction(id, name, description, constant, range, unit);
                case "Tripping Strike":
                    return new TrippingStrikeAction(id, name, description, constant, range, unit);
                case "Opportunist":
                    return new OpportunistAction(id, name, description, constant, range, unit);
                case "Weathered Blade":
                    return new WeatheredBladeAction(id, name, description, constant, range, unit);
                case "You're Coming With Me":
                    return new YoureComingWithMeAction(id, name, description, constant, range, unit);
                case "Apprehend":
                    return new ApprehendAction(id, name, description, constant, range, unit);
                case "Mob 'em Down!":
                    return new MobEmDownAction(id, name, description, constant, range, unit);
                case "Reveille!":
                    return new ReveilleAction(id, name, description, constant, range, unit);
                case "Imperial Oversight":
                    return new ImperialOversightAction(id, name, description, constant, range, unit);
                case "Lance Strike":
                    return new LanceStrikeAction(id, name, description, constant, range, unit);
                case "Wild Kick":
                    return new WildKickAction(id, name, description, constant, range, unit);
                case "Trample":
                    return new TrampleAction(id, name, description, constant, range, unit);
                case "Mount":
                    return new MountAction(id, name, description, constant, range, unit);
                case "Straight Shot":
                    return new StraightShotAction(id, name, description, constant, range, unit);
                case "Volley Fire":
                    return new VolleyFireAction(id, name, description, constant, range, unit);
                case "Climb":
                    return new ClimbAction(id, name, description, constant, range, unit);
                case "Sudden Stab":
                    return new SuddenStabAction(id, name, description, constant, range, unit);
                case "Leaping Blade":
                    return new LeapingBladeAction(id, name, description, constant, range, unit);
                case "Fool's Gambit":
                    return new FoolsGambitAction(id, name, description, constant, range, unit);
                case "Parrydance":
                    return new ParrydanceAction(id, name, description, constant, range, unit);
                case "Shieldsong":
                    return new ShieldSongAction(id, name, description, constant, range, unit);
                case "Harmony's Blade":
                    return new HarmonysBladeAction(id, name, description, constant, range, unit);
                case "Whirl of Love":
                    return new WhirlOfLoveAction(id, name, description, constant, range, unit);
                case "Passion's Blade":
                    return new PassionsBladeAction(id, name, description, constant, range, unit);
                case "Dual Strike":
                    return new DualStrikeAction(id, name, description, constant, range, unit);
                case "Lover's Shriek":
                    return new LoversShriekAction(id, name, description, constant, range, unit);
                case "Hysteria":
                    return new HysteriaAction(id, name, description, constant, range, unit);
                case "Power Source":
                    return new PowerSourceAction(id, name, description, constant, range, unit);
                case "Lumbering Beast":
                    return new LumberingBeastAction(id, name, description, constant, range, unit);
                case "Tank Shock":
                    return new TankShockAction(id, name, description, constant, range, unit);
                case "Repair":
                    return new RepairAction(id, name, description, constant, range, unit);
                case "Hydraulic Power":
                    return new HydraulicPowerAction(id, name, description, constant, range, unit);
                case "Strafing Shots":
                    return new StrafingShotsAction(id, name, description, constant, range, unit);
                case "Focused Fire":
                    return new FocusedFireAction(id, name, description, constant, range, unit);
                case "Bunker Breaker":
                    return new BunkerBreakerAction(id, name, description, constant, range, unit);
                case "Thick Metal":
                    return new ThickMetalAction(id, name, description, constant, range, unit);
                case "Shine":
                    return new ShineAction(id, name, description, constant, range, unit);
                case "Cracklemace":
                    return new CracklemaceAction(id, name, description, constant, range, unit);
                case "Mindsnare Shield":
                    return new MindsnareShieldAction(id, name, description, constant, range, unit);
                case "Stand Firm":
                    return new StandFirmAction(id, name, description, constant, range, unit);
                case "Phase Halberd":
                    return new PhaseHalberdAction(id, name, description, constant, range, unit);
                case "Spiritcutter":
                    return new SpiritcutterAction(id, name, description, constant, range, unit);
                case "Battleshaper Helm":
                    return new BattleshaperHelmAction(id, name, description, constant, range, unit);
                case "Gleaming Aegis":
                    return new GleamingAegisAction(id, name, description, constant, range, unit);
                case "Magic Darts":
                    return new MagicDartsAction(id, name, description, constant, range, unit);
                case "Spell of Forgetting":
                    return new SpellOfForgettingAction(id, name, description, constant, range, unit);
                case "Magic Bolts":
                    return new MagicBoltsAction(id, name, description, constant, range, unit);
                case "Sealed Shattering":
                    return new SealedShatteringAction(id, name, description, constant, range, unit);
                case "Magic Storm":
                    return new MagicStormAction(id, name, description, constant, range, unit);
                case "Follow My Lead":
                    return new FollowMyLeadAction(id, name, description, constant, range, unit);
                case "Suggestion":
                    return new SuggestionAction(id, name, description, constant, range, unit);
                case "Warp the Walls":
                    return new WarpTheWallsAction(id, name, description, constant, range, unit);
                case "Wild Heart":
                    return new WildHeartAction(id, name, description, constant, range, unit);
                case "Geomancy":
                    return new GeomancyAction(id, name, description, constant, range, unit);
                case "Drub":
                    return new DrubAction(id, name, description, constant, range, unit);
                case "Maul":
                    return new MaulAction(id, name, description, constant, range, unit);
                case "Pounce":
                    return new PounceAction(id, name, description, constant, range, unit);
                case "Eviscerate":
                    return new EviscerateAction(id, name, description, constant, range, unit);
                case "Dig":
                    return new DigAction(id, name, description, constant, range, unit);
                case "Advance Carefully":
                    return new AdvanceCarefullyAction(id, name, description, constant, range, unit);
                case "Squash":
                    return new SquashAction(id, name, description, constant, range, unit);
                case "Fireball":
                    return new FireballAction(id, name, description, constant, range, unit);
                case "Consuming Passion":
                    return new ConsumingPassionAction(id, name, description, constant, range, unit);
                case "Splashfire":
                    return new SplashfireAction(id, name, description, constant, range, unit);
                case "Sunder":
                    return new SunderAction(id, name, description, constant, range, unit);
                case "Hymn of Marble":
                    return new HymnOfMarbleAction(id, name, description, constant, range, unit);
                case "Sculpt":
                    return new SculptAction(id, name, description, constant, range, unit);
                case "Stone-dagger":
                    return new StoneDaggerAction(id, name, description, constant, range, unit);
                case "Somersault":
                    return new SomersaultAction(id, name, description, constant, range, unit);
                case "Crushing Fists":
                    return new CrushingFistsAction(id, name, description, constant, range, unit);
                case "Melting Will":
                    return new MeltingWillAction(id, name, description, constant, range, unit);
                case "Bladed Fan":
                    return new BladedFanAction(id, name, description, constant, range, unit);
                case "Crooked Heel":
                    return new CrookedHeelAction(id, name, description, constant, range, unit);
                case "Fluid":
                    return new FluidAction(id, name, description, constant, range, unit);
            }
        }
    }
}
