using System.Configuration;
using System.Xml.Schema;

namespace Actividad_1_PSP.CharacterWithPerks;

class Pet
{
    public string Name{ get; set; }
    public int addedDamage{ get; set; }
    
    public abstract void Apply(Character character);

    
    public Pet(string name, int AddedDamage)
    {
        Name = name;
        addedDamage = AddedDamage;
    }
}