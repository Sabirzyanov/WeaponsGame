namespace WeaponGame.Core.Interfaces;

public interface IWeapon
{
    public int Damage { get; set; }

    public void Attack();
}