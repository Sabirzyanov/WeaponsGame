using WeaponGame.Core.Interfaces;

namespace WeaponGame.Core.Weapons;

public class Tomahawk : IThrowable, IMeleeWeapon
{
    public int MaxDurability { get; set; }
    private ILogger _logger;

    public int Durability { get; set; }
    public int Damage { get; set; }

    public Tomahawk(ILogger logger, int maxDurability)
    {
        _logger = logger;
        MaxDurability = maxDurability;
        Durability = MaxDurability;
    }

    public void Upgrade(int value)
    {
        Damage += value;
        _logger.LogInfo("Tomahawk has been upgraded");
    }

    public void Repair(int value)
    {
        if (Durability + value > MaxDurability)
            return;

        Durability += value;

        _logger.LogInfo("Tomahawk has been repaired.");
    }

    public void Attack()
    {
        Durability -= 5;
        _logger.LogInfo($"Tomahawk deal {Damage} damage");
    }

    public void Throw()
    {
        _logger.LogInfo("Tomahawk was thrown");
    }
    
    public override string ToString()
    {
        return $"Tomahawk | Damage: {Damage} | Durability: {Durability}";
    }
}