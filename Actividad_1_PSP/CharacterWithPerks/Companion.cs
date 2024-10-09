namespace Actividad_1_PSP.CharacterWithPerks;

class Companion : Pet
{
    public Companion(string name, int AddedDamage) : base(name, AddedDamage)
    {
        
        
    }

    public override void Apply(Character character)
    {
        // Aplicar efectos del escudo al personaje
    }
}