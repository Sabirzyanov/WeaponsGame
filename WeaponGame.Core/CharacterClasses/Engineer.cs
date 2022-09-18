using WeaponGame.Core.Interfaces;

namespace WeaponGame.Core.CharacterClasses;

public class Engineer
{
    private const int RepairValue = 10;
    private const int UpgradeValue = 5;
    
    private ILogger _logger;

    public Engineer(ILogger logger)
    {
        _logger = logger;
    }

    public void RepairWeapon(IRepairable repairItem)
    {
        repairItem.Repair(RepairValue);
        _logger.LogInfo("Engineer repair weapon");
    }

    public void UpgradeWeapon(IUpgradeable upgradeItem)
    {
        upgradeItem.Upgrade(UpgradeValue);
        _logger.LogInfo("Engineer upgrade weapon");
    }
}