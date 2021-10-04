using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: IMagicCharacter
    {
        public Wizard(string name)
        {
            this.Name = name;
            
            this.AddItem(new Staff());
        }
    }
}