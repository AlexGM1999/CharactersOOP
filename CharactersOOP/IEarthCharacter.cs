using System;
using System.Collections.Generic;
using System.Text;

namespace CharactersOOP
{
    interface IEarthCharacter
    {
        public int EarthDamage { get; }
        public int WaterResistance { get; }
        public int FireResistance { get; }
        public void Regrowth();
        public void Entangle();
    }
}
