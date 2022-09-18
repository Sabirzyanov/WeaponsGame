using WeaponGame.Core.Interfaces;

namespace WeaponGame.Core.Weapons;

public class SMG : IAutoShoot, ISingleShoot
{
    public int CurrentAmmoCount { get; set; }
    public int MaxAmmoCount { get; set; }
    public int MaxDurability { get; set; }
    public int Durability { get; set; }
    public int Damage { get; set; }

    private ILogger _logger;

    public SMG(ILogger logger, int maxAmmoCount, int maxDurability)
    {
        _logger = logger;
        MaxDurability = maxDurability;
        MaxAmmoCount = maxAmmoCount;
        Durability = MaxDurability;
        CurrentAmmoCount = MaxAmmoCount;
    }

    public void Reload()
    {
        CurrentAmmoCount = MaxAmmoCount;
        _logger.LogInfo("SMG has been reloaded");
    }

    public void Upgrade(int value)
    {
        Damage += value;
        _logger.LogInfo("SMG has been upgraded");
    }

    public void Repair(int value)
    {
        if (Durability + value > MaxDurability)
            return;

        Durability += value;
        
        _logger.LogInfo("SMG has been repaired.");
    }

    public void Attack()
    {
        _logger.LogInfo($"SMG deal {Damage} damage");
    }

    public void SingleShoot()
    {
        CurrentAmmoCount--;
        Durability -= 2;
        _logger.LogInfo($"SMG shoo one time, deal {Damage} damage");
    }

    public void AutoShoot()
    {
        Durability -= 5;
        _logger.LogInfo("Auto shoot");
    }
    
    public override string ToString()
    {
        return $"SMG | Damage: {Damage} | Durability: {Durability} | Ammo count: {CurrentAmmoCount}";
    }
}