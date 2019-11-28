﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace ExamenProjectReal
{
    abstract class Characters: GameObject
    {

        protected Random rnd;

        protected Vector2 position;

        protected int health;
        protected int mana;
        protected int strenght;
        protected int agility;
        protected int intelligence;

        protected bool ranged;

        public void Attack()
        {

        }

        public void SpecialAttack()
        {

        }


        void Flee()
        {

        }

        void UseItem(Item item)
        {

        }

        void LevelUp()
        {

        }
    }
}
