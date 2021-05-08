using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharactersOOP
{
    public class Character
    {
        [Key]
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public Character(int health, int attack, string name)
        {
            Health = health;
            Attack = attack;
            Name = name;
        }

        public void Damage(int damage)
        {
            Health -= damage;
        }


    }
}
