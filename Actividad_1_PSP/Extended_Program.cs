using System;
using System.Collections.Generic;

namespace Actividad_1_PSP
{
    public class ExtendedProgram
    {
        static void MainExtended()
        {
        }
    }

    class Character
    {
        public string Name { get; set; }
        private int MaxHitPoints { get; set; }
        private int BaseDamage { get; set; }
        private int BaseArmor { get; set; }
        private List<ITem> LstItems { get; set; }
    }

    internal interface ITem
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
}