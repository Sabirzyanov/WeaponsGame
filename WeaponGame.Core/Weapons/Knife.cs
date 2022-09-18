using WeaponGame.Core.Interfaces;

namespace WeaponGame.Core.Weapons;

public class Knife : IMeleeWeapon
{
    public int MaxDurability { get; set; }
    public int Durability { get; set; }
    public int Damage { get; set; }

    private ILogger _logger;

    public Knife(ILogger logger, int maxDurability)
    {
        _logger = logger;
        MaxDurability = maxDurability;
        Durability = MaxDurability;
    }

    public void Upgrade(int value)
    {
        Damage += value;
        _logger.LogInfo("Knife has been upgraded");
    }

    public void Repair(int value)
    {
        if (Durability + value > MaxDurability)
            return;

        Durability += value;
        
        _logger.LogInfo("Knife has been repaired.");
    }

    public void Attack()
    {
        Durability -= 5;
        _logger.LogInfo($"Knife deal {Damage} damage");
    }
    
    public override string ToString()
    {
        return $"Knife | Damage: {Damage} | Durability: {Durability}";
    }
}