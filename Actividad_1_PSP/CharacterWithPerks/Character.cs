using System.Collections.Generic;

namespace Actividad_1_PSP.CharacterWithPerks;

class Character
{
    public string Name { get; }
    private static int MaxHitPoints { get; set; }

    int OriginalMaxHitPoints;

    private int BaseDamage { get; set; }
    private int BaseArmor { get; set; }

    public List<IItem> LstItems;

    private List<OfensiveCompanion> LstCompanions;

    // Constructor
    public Character(string name, int maxHitPoints, int baseDamage, int baseArmor)
    {
        Name = name;
        MaxHitPoints = maxHitPoints;
        OriginalMaxHitPoints = MaxHitPoints;
        BaseDamage = baseDamage;
        BaseArmor = baseArmor;
        LstItems = new List<IItem>();
        LstCompanions = new List<OfensiveCompanion>();
    }

    // Método de ataque
    public int Attack()
    {
        return SearchForWeapon() + SearchForOfensiveCompanion() +BaseDamage;
    }

    // Método de defensa
    public int Defense()
    {
        return SearchForProtection() + BaseArmor;
    }

    public int GetMaxHitPoints()
    {
        return MaxHitPoints;
    }

    // Método para recibir curación
    public void Heal(int healing)
    {
        MaxHitPoints += healing;
        if (MaxHitPoints > OriginalMaxHitPoints)
        {
            MaxHitPoints = OriginalMaxHitPoints;
        }
    }

    // Método para recibir daño
    public void ReceiveDamage(int damageReceived)
    {
        MaxHitPoints -= damageReceived-Defense();
        if (MaxHitPoints < 0)
        {
            MaxHitPoints = 0;
        }
    }

    // Equipar un ítem
    public void EquipItem(IItem item)
    {
        item.Apply(this);
        LstItems.Add(item);
    }
    
    // Equipar una pet
    public void EquipPet(OfensiveCompanion ofensiveCompanion)
    {
        ofensiveCompanion.Apply(this);
        LstCompanions.Add(ofensiveCompanion);
    }

    private int SearchForWeapon()
    {
        int WeaponDamage = 0;
        foreach (var item in LstItems)
        {
            if (item is Weapon weapon)
                WeaponDamage += weapon.Damage;
        } 
        return WeaponDamage;
        }
    
    private int SearchForProtection()
    {
        int ExtraProtection = 0;
        foreach (var item in LstItems)
        {
            if (item is Protection protection)
                ExtraProtection += protection.Armor;
        } 
        return ExtraProtection;
    }
    
    private int SearchForOfensiveCompanion()
    {
        int AddedDamage = 0;
        foreach (var compa in LstCompanions)
        {
            if (compa is OfensiveCompanion companion)
                AddedDamage += companion.addedDamage;
        } 
        return AddedDamage;
    }
                
}


