using WeaponGame.Core.Interfaces;

namespace WeaponGame.Core.Weapons;

public class Pistol : ISingleShoot
{
    public int MaxDurability { get; set; }
    public int Durability { get; set; }
    public int Damage { get; set; }

    public int CurrentAmmoCount { get; set; }
    public int MaxAmmoCount { get; set; }

    private ILogger _logger;

    public Pistol(ILogger logger, int maxAmmoCount, int maxDurability)
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
        _logger.LogInfo("Pistol has been reloaded");
    }

    public void Upgrade(int value)
    {
        Damage += value;
        _logger.LogInfo("Pistol has been upgraded");
    }

    public void Repair(int value)
    {
        if (Durability + value > MaxDurability)
            return;

        Durability += value;
        
        _logger.LogInfo("Pistol has been repaired.");
    }



    public void SingleShoot()
    {
        if (CurrentAmmoCount < 1)
            return;
        CurrentAmmoCount--;
        Durability -= 5;
        _logger.LogInfo($"Pistol shoot one time, deal {Damage} damage");
    }
    
    public void Attack()
    {
        this.SingleShoot();
    }
    
    public override string ToString()
    {
        return $"Pistol | Damage: {Damage} | Durability: {Durability} | Ammo count: {CurrentAmmoCount}";
    }
}