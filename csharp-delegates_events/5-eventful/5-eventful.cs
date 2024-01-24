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
    public float currentHp { get; private set; }

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
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

    public void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.WriteLine("Health is low!");
        }
    }

    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
        {
            HPCheck += HPValueWarning;
        }
        HPCheck?.Invoke(this, e);
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
        OnCheckStatus(new CurrentHPArgs(hp));
    }
}
