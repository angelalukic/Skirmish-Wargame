namespace ObjectLibrary
{
    abstract class AbstractEffect : IEffect
    {
        private readonly EffectType effect;
        private readonly string description;
        private readonly bool isArmyEffect;

        public EffectType GetEffect()
        {
            return effect;
        }
        public string GetDescription()
        {
            return description;
        }
        public bool IsArmyEffect()
        {
            return isArmyEffect;
        }
    }
}
