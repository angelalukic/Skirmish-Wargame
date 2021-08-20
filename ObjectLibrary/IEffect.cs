namespace ObjectLibrary
{
     public interface IEffect
    {
        EffectType GetEffect();
        string GetDescription();
        bool IsArmyEffect();
    }
}
