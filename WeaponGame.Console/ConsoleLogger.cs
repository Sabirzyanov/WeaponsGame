using WeaponGame.Core.Interfaces;

namespace WeaponGame.Console;

public class ConsoleLogger : ILogger
{
    public void LogInfo(string msg)
    {
        System.Console.WriteLine(msg);
    }
}