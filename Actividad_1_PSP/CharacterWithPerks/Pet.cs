using System.Configuration;
using System.Xml.Schema;

namespace Actividad_1_PSP.CharacterWithPerks;

abstract class Pet : IPet
{
    public string Name{ get; set; }
    public int addedDamage{ get; set; }
    

    
    public Pet(string name, int AddedDamage)
    {
        Name = name;
        addedDamage = AddedDamage;
    }

    public abstract void Apply(Character character);
}