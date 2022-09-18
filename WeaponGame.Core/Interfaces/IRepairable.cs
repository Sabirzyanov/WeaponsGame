namespace WeaponGame.Core.Interfaces;

public interface IRepairable
{
    public int MaxDurability { get; set; }
    public int Durability { get; set; }
    
    public void Repair(int value);
}