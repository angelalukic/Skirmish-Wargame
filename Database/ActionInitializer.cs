using ObjectLibrary;
using ActionLibrary;
using System;
using System.Data;

namespace Database
{
    // See DataInitializer.cs
    public partial class DataInitializer
    {
        /*
        void InitializeActions()
        {
            DataTable actionData = data.GetActionData();
            IAction action;
            foreach (DataRow row in actionData.Rows)
            {
                int id = Int32.Parse(row["ActionID"].ToString());
                string name = row["Name"].ToString();
                string description = row["Description"].ToString();
                bool constant = Convert.ToBoolean(Int32.Parse(row["Constant"].ToString()));
                int range = Int32.Parse(row["Range"].ToString());

                switch(name)
                {
                    case "Truncheons Out":
                        action = new TruncheonsOutAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Tripping Strike":
                        action = new TrippingStrikeAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Opportunist":
                        action = new OpportunistAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Weathered Blade":
                        action = new WeatheredBladeAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "You're Coming With Me":
                        action = new YoureComingWithMeAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Apprehend":
                        action = new ApprehendAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Mob 'em Down!":
                        action = new MobEmDownAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Reveille!":
                        action = new ReveilleAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Imperial Oversight":
                        action = new ImperialOversightAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Lance Strike":
                        action = new LanceStrikeAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Wild Kick":
                        action = new WildKickAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Trample":
                        action = new TrampleAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Mount":
                        action = new MountAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Straight Shot":
                        action = new StraightShotAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Volley Fire":
                        action = new VolleyFireAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Climb":
                        action = new ClimbAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Sudden Stab":
                        action = new SuddenStabAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Leaping Blade":
                        action = new LeapingBladeAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Fool's Gambit":
                        action = new FoolsGambitAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Parrydance":
                        action = new ParrydanceAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Shieldsong":
                        action = new ShieldSongAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Harmony's Blade":
                        action = new HarmonysBladeAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Whirl of Love":
                        action = new WhirlOfLoveAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Passion's Blade":
                        action = new PassionsBladeAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Dual Strike":
                        action = new DualStrikeAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Lover's Shriek":
                        action = new LoversShriekAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Hysteria":
                        action = new HysteriaAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Power Source":
                        action = new PowerSourceAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Lumbering Beast":
                        action = new LumberingBeastAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Tank Shock":
                        action = new TankShockAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Repair":
                        action = new RepairAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Hydraulic Power":
                        action = new HydraulicPowerAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Strafing Shots":
                        action = new StrafingShotsAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Focused Fire":
                        action = new FocusedFireAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Bunker Breaker":
                        action = new BunkerBreakerAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Thick Metal":
                        action = new ThickMetalAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Shine":
                        action = new ShineAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Cracklemace":
                        action = new CracklemaceAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Mindsnare Shield":
                        action = new MindsnareShieldAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Stand Firm":
                        action = new StandFirmAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Phase Halberd":
                        action = new PhaseHalberdAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Spiritcutter":
                        action = new SpiritcutterAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Battleshaper Helm":
                        action = new BattleshaperHelmAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Gleaming Aegis":
                        action = new GleamingAegisAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Magic Darts":
                        action = new MagicDartsAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Spell of Forgetting":
                        action = new SpellOfForgettingAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Magic Bolts":
                        action = new MagicBoltsAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Sealed Shattering":
                        action = new SealedShatteringAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Magic Storm":
                        action = new MagicStormAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Follow My Lead":
                        action = new FollowMyLeadAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Suggestion":
                        action = new SuggestionAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Warp the Walls":
                        action = new WarpTheWallsAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Wild Heart":
                        action = new WildHeartAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Geomancy":
                        action = new GeomancyAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Drub":
                        action = new DrubAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Maul":
                        action = new MaulAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Pounce":
                        action = new PounceAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Eviscerate":
                        action = new EviscerateAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Dig":
                        action = new DigAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Advance Carefully":
                        action = new AdvanceCarefullyAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Squash":
                        action = new SquashAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Fireball":
                        action = new FireballAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Consuming Passion":
                        action = new ConsumingPassionAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Splashfire":
                        action = new SplashfireAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Sunder":
                        action = new SunderAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Hymn of Marble":
                        action = new HymnOfMarbleAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Sculpt":
                        action = new SculptAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Stone-dagger":
                        action = new StoneDaggerAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Somersault":
                        action = new SomersaultAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Crushing Fists":
                        action = new CrushingFistsAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Melting Will":
                        action = new MeltingWillAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Bladed Fan":
                        action = new BladedFanAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Crooked Heel":
                        action = new CrookedHeelAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                    case "Fluid":
                        action = new FluidAction(id, name, description, constant, range);
                        actions.Add(action);
                        break;
                }
            }

        }*/
    }
}
