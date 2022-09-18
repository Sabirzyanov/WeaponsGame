using WeaponGame.Console;
using WeaponGame.Core.CharacterClasses;
using WeaponGame.Core.Interfaces;
using WeaponGame.Core.Weapons;


ConsoleLogger logger = new ConsoleLogger();

Chakram c = new Chakram(logger)
{
    Damage = 10
};

Knife k = new Knife(logger, 50)
{
    Damage = 7,
};

Tomahawk t = new Tomahawk(logger, 40)
{
    Damage = 9,
};

Pistol m1911 = new Pistol(logger, 15, 100)
{
    Damage = 15,
};

SMG spsmg = new SMG(logger, 32, 100)
{
    MaxDurability = 100,
    Damage = 10,
    MaxAmmoCount = 32
};

Military shuhrat = new Military(logger, spsmg);
Engineer engineer = new Engineer(logger);

shuhrat.ChosenWeapon.Attack();

shuhrat.AddWeapon(m1911);
shuhrat.ChangeActiveWeapon(1);

shuhrat.ChosenWeapon.Attack();

shuhrat.ThrowWeapon(t);
shuhrat.ThrowWeapon(c);

engineer.UpgradeWeapon(m1911);

shuhrat.ChosenWeapon.Attack();
shuhrat.GetInfoAboutChosenWeapon();

engineer.RepairWeapon((IRepairable) shuhrat.ChosenWeapon);

shuhrat.GetInfoAboutChosenWeapon();


 