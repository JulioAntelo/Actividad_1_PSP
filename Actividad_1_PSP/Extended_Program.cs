using System;
using System.Collections.Generic;

public class ExtendedProgram
{
    static void MainExtended()
    {
    }
}

    class Character2
    {
        public string Name { get; set; }
        private int MaxHitPoints { get; set; }
        private int BaseDamage { get; set; }
        private int BaseArmor { get; set; }
        private List<ITem2> LstItems { get; set; }
    }

    internal interface ITem2
    {
        void Apply2(Character2 character);
    }

    abstract class Weapon2 : ITem2
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public abstract void Apply2(Character2 character);
    }

    abstract class Protection2 : ITem2
    {
        public string Name { get; set; }
        public int Armor { get; set; }

        public abstract void Apply2(Character2 character);
    }

    class Axe2 : Weapon2
    {
        public override void Apply2(Character2 character)
        {
        }
    }

    class Sword2 : Weapon2
    {
        public override void Apply2(Character2 character)
        {
        }
    }

    class Helmet2 : Protection2
    {
        public override void Apply2(Character2 character)
        {
        }
    }

    class Shield2 : Protection2
    {
        public override void Apply2(Character2 character)
        {
        }
    }
