using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersOOP
{
    interface IFireCharacter
    {
        public int FireDamage { get; }
        public int WaterResistance { get; }
        public int EarthResistance { get; }
        public void BurnWounds();
        public void Ignite();
    }
}
