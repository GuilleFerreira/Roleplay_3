using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: ICharacter
    {
        public Archer(string name)
        {
            this.Name = name;
            
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}