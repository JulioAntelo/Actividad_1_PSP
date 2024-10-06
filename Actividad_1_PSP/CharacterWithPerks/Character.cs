using System.Collections.Generic;

namespace Actividad_1_PSP.CharacterWithPerks;

    class Character
    {
        public string Name { get; }
        private static int MaxHitPoints { get; set; }
        
        int OriginalMaxHitPoints;
    
        private int BaseDamage { get; set; }
        private int BaseArmor { get; set; }
        private List<IItem> LstItems;
    
        // Constructor
        public Character(string name, int maxHitPoints, int baseDamage, int baseArmor)
        {
            Name = name;
            MaxHitPoints = maxHitPoints;
            OriginalMaxHitPoints = MaxHitPoints;
            BaseDamage = baseDamage;
            BaseArmor = baseArmor;
            LstItems = new List<IItem>();
        }
    
        // Método de ataque
        public int Attack()
        {
            return BaseDamage;
        }
    
        // Método de defensa
        public int Defense()
        {
            return BaseArmor;
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
            MaxHitPoints -= damageReceived;
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
    }
