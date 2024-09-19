using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
    }
}

class Character
{
    public string Name { get; set; }
    private int MaxHitPoints { get; set; }
    private int BaseDamage { get; set; }
    private int BaseArmor { get; set; }
    private List<Item> lstItems { get; set; }
}

internal interface Item
{
    void Apply(Character character);
}

abstract class Weapon : Item
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public abstract void Apply(Character character);
}

abstract class Protection : Item
{
    public string Name { get; set; }
    public int Armor { get; set; }

    public abstract void Apply(Character character);
}

class Axe : Weapon
{
    public override void Apply(Character character)
    {
    }
}

class Sword : Weapon
{
    public override void Apply(Character character)
    {
    }
}

class Helmet : Protection
{
    public override void Apply(Character character)
    {
    }
}

class Shield : Protection
{
    public override void Apply(Character character)
    {
    }
}