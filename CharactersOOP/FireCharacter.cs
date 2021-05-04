using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersOOP
{
    class FireCharacter : Character, IFireCharacter
    {
        private int fireDamage;
        private int waterResistance;
        private int earthResistance;
        public FireCharacter(int fireDamage, int waterResistance, int earthResistance, int health, int attack, string name)
            : base(health,attack,name)
        {
            this.fireDamage = fireDamage;
            this.waterResistance = waterResistance;
            this.earthResistance = earthResistance;

        }
        public int FireDamage
        {
            get { return fireDamage; }
        }

        public int WaterResistance
        {
            get { return waterResistance; }
        }
        public int EarthResistance
        {
            get { return earthResistance; }
        }

        public void BurnWounds()
        {
            throw new NotImplementedException();
        }

        public void Ignite()
        {
            throw new NotImplementedException();
        }
    }
}
