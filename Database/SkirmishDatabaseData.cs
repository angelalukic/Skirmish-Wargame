using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace Database
{
    public class SkirmishDatabaseData
    {
        private readonly DataTable factions;
        private readonly DataTable armies;
        private readonly DataTable units;
        private readonly DataTable actions;
        private readonly DataTable effects;

        // Join Tables
        private readonly DataTable factionArmies;
        private readonly DataTable armyUnits;
        private readonly DataTable armyEffects;
        private readonly DataTable unitActions;
        private readonly DataTable actionEffects;

        public SkirmishDatabaseData()
        {
            factions = GetData("SELECT * FROM Faction");
            armies = GetData("SELECT * FROM Army");
            units = GetData("SELECT * FROM Unit");
            actions = GetData("SELECT * FROM Action");
            effects = GetData("SELECT * FROM Effect");

            // Join Tables
            factionArmies = GetData("SELECT * FROM FactionArmies");
            armyUnits = GetData("SELECT * FROM ArmyUnits");
            armyEffects = GetData("SELECT * FROM ArmyEffects");
            unitActions = GetData("SELECT * FROM UnitActions");
            actionEffects = GetData("SELECT * FROM ActionEffects");
        }

        static DataTable GetData(string queryString)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; 
                                      AttachDbFilename=" + GetDatabasePath() + ";" +
                                      "Integrated Security=True;";

            SqlConnection connection = new(connectionString);
            SqlDataAdapter adapter = new(queryString, connection);
            DataTable data = new();
            try
            {
                connection.Open();
                adapter.Fill(data);

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return data;
        }

        static string GetDatabasePath()
        {
            // Copied from https://stackoverflow.com/a/64558353
            string codeBase = Assembly.GetExecutingAssembly().Location;
            string basePath = new Uri(codeBase).LocalPath.Split(new string[] { "\\SkirmishGame" }, StringSplitOptions.None)[0];
            return Path.Combine(basePath, "Database\\Database.mdf");
        }

        public DataTable GetFactionData()
        {
            return factions;
        }

        public DataTable GetArmyData()
        {
            return armies;
        }

        public DataTable GetUnitData()
        {
            return units;
        }

        public DataTable GetActionData()
        {
            return actions;
        }

        public DataTable GetEffectData()
        {
            return effects;
        }

        public DataTable GetFactionArmiesData()
        {
            return factionArmies;
        }

        public DataTable GetArmyUnitsData()
        {
            return armyUnits;
        }

        public DataTable GetArmyEffectsData()
        {
            return armyEffects;
        }

        public DataTable GetUnitActionsData()
        {
            return unitActions;
        }

        public DataTable GetActionEffectsData()
        {
            return actionEffects;
        }
    }
}
