using System;

public delegate void HPCheckDelegate(object sender, CurrentHPArgs e);

public class CurrentHPArgs
{
    public float currentHp { get; set; }
    public float maxHp { get; set; }
}

public class Player
{
    public event HPCheckDelegate HPCheck;

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Health is low!");
            Console.ResetColor();
        }
    }

    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < e.maxHp / 4)
        {
            Console.WriteLine($"Electric Mouse isn't doing too great...");
            HPCheck += HPValueWarning;
        }
        else if (e.currentHp >= e.maxHp / 4 && e.currentHp < e.maxHp * 0.75)
        {
            Console.WriteLine($"Electric Mouse is doing well!");
            HPCheck += HPValueWarning;
        }
        else
        {
            Console.WriteLine($"Electric Mouse is knocked out!");
            HPCheck += HPValueWarning;
        }
        HPCheck?.Invoke(this, e);
    }

    public void ValidateHP(CurrentHPArgs e)
    {
        OnCheckStatus(e);
    }
}
