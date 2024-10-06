namespace Actividad_1_PSP.CharacterWithPerks;

abstract class Weapon : IItem
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public abstract void Apply(Character character);
}