namespace Actividad_1_PSP.CharacterWithPerks;

class Axe : Weapon
{
    public override void Apply(Character character)
    {
        character.Attack();
    }
}
