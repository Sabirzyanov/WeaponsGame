using WeaponGame.Core.Interfaces;

namespace WeaponGame.Core.CharacterClasses;

public class Military
{
    private List<IWeapon> _inventory = new();

    public IWeapon ChosenWeapon { get; private set; }

    private ILogger _logger;

    public Military(ILogger logger, IWeapon startWeapon)
    {
        _logger = logger;
        _inventory.Add(startWeapon);
        ChosenWeapon = startWeapon;
    }

    public void ChangeActiveWeapon(int inventoryPosition)
    {
        try
        {
            ChosenWeapon = _inventory[inventoryPosition];
            _logger.LogInfo("Military change weapon");
            GetInfoAboutChosenWeapon();
        }
        catch (Exception e)
        {
            _logger.LogInfo(e.Message);
            throw;
        }
    }

    public void GetInfoAboutChosenWeapon()
    {
        _logger.LogInfo(ChosenWeapon.ToString());
    }

    public void AddWeapon(IWeapon weapon)
    {
        _inventory.Add(weapon);
        _logger.LogInfo("Military pick up weapon");
    }

    public void ThrowWeapon(IThrowable weapon)
    {
        weapon.Throw();
        _logger.LogInfo("Military throw weapon");
    }

    public void SingleShoot(ISingleShoot weapon)
    {
        weapon.SingleShoot();
        _logger.LogInfo("Military single shoot");
    }

    public void AutoShoot(IAutoShoot weapon)
    {
        weapon.AutoShoot();
        _logger.LogInfo("Military auto shoot");
    }

    public void Reload(IReloadable weapon)
    {
        weapon.Reload();
        _logger.LogInfo("Military reload weapon");
    }

    public void HitByMelee(IMeleeWeapon meleeWeapon)
    {
        meleeWeapon.Attack();
        _logger.LogInfo("Military hit by melee weapon");
    }
}