using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjectReal
{
    class Characters
    {

        protected Random rnd;

        protected Vector2 position;

        protected int maxHealth;
        protected int currnetHealth;
        protected int mana;
        protected int strenght;
        protected int agility;
        protected int intelligence;

        protected bool ranged;

        public abstract void Attack(); 

        public abstract void SpecialAttack();

        public abstract bool TakeDamage(int dmg);
        
        public virtual void Flee()
        {

        }

        public virtual void UseItem(Item item)
        {

        }

        public virtual void LevelUp()
        {

        }
    }
}
