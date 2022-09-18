namespace WeaponGame.Core.Interfaces;

public interface IReloadable
{
    public int CurrentAmmoCount { get; set; }
    public int MaxAmmoCount { get; set; }
    public void Reload();
}