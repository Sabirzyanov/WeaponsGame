using WeaponGame.Core.Interfaces;

namespace WeaponGame.Core.Weapons;

public class Chakram : IThrowable
{

    public int Damage { get; set; }
    private ILogger _logger;

    public Chakram(ILogger logger)
    {
        _logger = logger;
    }
    
    public void Attack()
    {
        Throw();
    }

    public void Throw()
    {
        _logger.LogInfo($"Chakram deal {Damage} damage");
    }

    public override string ToString()
    {
        return $"Chakram | Damage: {Damage}";
    }
}