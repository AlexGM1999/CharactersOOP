using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersOOP
{
    class EarthCharacter : Character, IEarthCharacter
    {
        private int earthDamage;
        private int waterResistance;
        private int fireResistance;

        public EarthCharacter(int earthDamage, int waterResistance, int fireResistance, int health,int attack, string name)
            :base( health, attack, name)
        {
            this.earthDamage = earthDamage;
            this.waterResistance = waterResistance;
            this.fireResistance = fireResistance;

        }
        public int EarthDamage
        {
            get { return earthDamage; }
        }

        public int WaterResistance
        {
            get { return waterResistance; }
        }

        public int FireResistance
        {
            get { return fireResistance; }
        }
        public void Entangle()
        {
            throw new NotImplementedException();
        }

        public void Regrowth()
        {
            throw new NotImplementedException();
        }
    }
}
