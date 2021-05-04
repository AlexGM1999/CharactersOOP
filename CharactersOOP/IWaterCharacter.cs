using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersOOP
{
    interface IWaterCharacter
    {
        public int WaterDamage { get; }
        public int EarthResistance { get; }
        public int  FireResistance {get;}
        public void Replenish();
        public void WashOut();
    }
}
