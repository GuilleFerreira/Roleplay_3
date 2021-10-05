using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class ICharacter
    {

        public bool Heroe = true;
        public int VP = 0;

        private int health = 100;

        private List<IItem> items = new List<IItem>();

        public string Name { get; set; }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Attack(ICharacter personaje)
        {
            if (personaje.DefenseValue < this.AttackValue)
            {
                personaje.Health -= this.AttackValue - personaje.DefenseValue;
            }
        }
    }
}