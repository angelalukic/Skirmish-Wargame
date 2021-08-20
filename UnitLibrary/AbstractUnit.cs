using System.Collections.Generic;
using ObjectLibrary;

namespace UnitLibrary
{
    public abstract class AbstractUnit : IUnit
    {
        private readonly int id;
        private readonly string name;
        private readonly int health;
        private readonly int move;
        private readonly int cost;
        private readonly IArmy army;
        private HashSet<IAction> actions;

        public AbstractUnit(int id, string name, int health, int move, int cost, IArmy army)
        {
            this.id = id;
            this.name = name;
            this.health = health;
            this.move = move;
            this.cost = cost;
            this.army = army;
            actions = new();
        }

       public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetMove()
        {
            return move;
        }

        public int GetCost()
        {
            return cost;
        }

        public IArmy GetArmy()
        {
            return army;
        }

        public HashSet<IAction> GetActions()
        {
            return actions;
        }

        public void AddAction(IAction action)
        {
            actions.Add(action);
        }

        public void RemoveAction(IAction action)
        {
            actions.Remove(action);
        }
    }
}
