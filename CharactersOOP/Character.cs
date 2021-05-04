using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersOOP
{
    class Character
    {
     private int health;
     private int attack;
        private string name;
        public Character(int health, int attack, string name)
        {
            this.health = health;
            this.attack = attack;
            this.name = name;
        }
        public int GetHealth
        {
            get { return health; }
        }
        public int GetAttack
        {
            get { return attack; }
        }
        public string GetName
        {
            get { return name; }
        }

        public void Damage(int damage)
        {
            health -= damage;
        }


    }
}
