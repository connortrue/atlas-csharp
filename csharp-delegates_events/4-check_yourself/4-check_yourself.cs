using System;

public enum Modifier
{
    Weak,
    Base,
    Strong
}

public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class CurrentHPArgs : EventArgs
{
    public float CurrentHp { get; }

    public CurrentHPArgs(float newHp)
    {
        CurrentHp = newHp;
    }
}



public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default..");
            maxHp = 100f;
        }

        this.name = name ?? "Player";
        this.maxHp = maxHp;
        this.hp = maxHp;
        HPCheck += CheckStatus;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    public float TakeDamage(float damage)
    {
        if (damage >= 0)
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            hp -= damage;
        }
        else
        {
            Console.WriteLine($"{name} takes 0 damage!");
        }
        ValidateHP(hp);
        return hp;
    }

    public float HealDamage(float heal)
    {
        if (heal >= 0)
        {
            Console.WriteLine($"{name} heals {heal} HP!");
            hp += heal;
        }
        else
        {
            Console.WriteLine($"{name} heals 0 HP!");
        }
        ValidateHP(hp);
        return hp;
    }

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                throw new ArgumentException("Invalid modifier", nameof(modifier));
        }
    }

    public event EventHandler<CurrentHPArgs> HPCheck;

    private string status;

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float maxHp = 100f;
        float halfMaxHp = maxHp / 2;
        float quarterMaxHp = maxHp / 4;

        if (e.CurrentHp == maxHp)
    {
        status = $"{name} is in perfect health!";
    }
    else if (e.CurrentHp > halfMaxHp && e.CurrentHp <= maxHp)
    {
        status = $"{name} is doing well!";
    }
    else if (e.CurrentHp > quarterMaxHp && e.CurrentHp <= halfMaxHp)
    {
        status = $"{name} isn't doing too great...";
    }
    else if (e.CurrentHp > 0 && e.CurrentHp <= quarterMaxHp)
    {
        status = $"{name} needs help!";
    }
    else if (e.CurrentHp == 0)
    {
        status = $"{name} is knocked out!";
    }

        Console.WriteLine(status);
    }
}
