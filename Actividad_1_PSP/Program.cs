using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    { 
        Character personaje1 = new Character("Personaje1", 35, 15,10);

        Console.WriteLine("Tests de pj:");
        
        Console.WriteLine(personaje1.ToString());
    }
}

class Character(string name, int MaxHitPoints,int BaseDamage,int BaseArmor)
{
    public string Name = name;
    private int MaxHitPoints = MaxHitPoints;
    private int BaseDamage = BaseDamage;
    private int BaseArmor = BaseArmor;
    private List<ITem> LstItems;

    public int Attack(int baseDamage, int baseArmor)
    {
        return baseDamage - baseArmor;
    }

    public int Defense(int baseArmor, int baseDamage)
    {
        return baseArmor - baseDamage;
    }

    public int Heal(int healing)
    {
        return healing;
    }

    public int ReceiveDamage(int damageReceived)
    {
        return damageReceived;
    }

    
}

interface ITem
{
    void Apply(Character character);
}

abstract class Weapon : ITem
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public abstract void Apply(Character character);
}

abstract class Protection : ITem
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

