namespace Actividad_1_PSP.CharacterWithPerks;

abstract class Protection : IItem
{
    public string Name { get; set; }
    public int Armor { get; set; }

    public abstract void Apply(Character character);
}
