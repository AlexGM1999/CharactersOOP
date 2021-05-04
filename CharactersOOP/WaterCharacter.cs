using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersOOP
{
    class WaterCharacter : Character, IWaterCharacter
    {
        private int waterDamage;
        private int earthResistance;
        private int fireResistance;
        public WaterCharacter(int waterDamage, int earthResistance, int fireResistance, int health, int attack,string name)
            :base(health,attack,name)
        {
            this.waterDamage = waterDamage;
            this.earthResistance = earthResistance;
            this.fireResistance = fireResistance;
        }
        public int WaterDamage
        {
            get { return waterDamage; }
        }

        public int EarthResistance
        {
            get { return earthResistance; }
        }


        public int FireResistance
        {
            get { return fireResistance; }
        }

        public void Replenish()
        {
            throw new NotImplementedException();
        }

        public void WashOut()
        {
            throw new NotImplementedException();
        }
    }
}
