// this class initialises the core traits (variables) of the hero character
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MonsterHunter_V2
{
    // Hero class
    public class Hero
    {
        public string Username { get; set; } // variable entered by user
        public int HP { get; set; } // current health, same as maxHP initially
        public int MaxHP { get; private set; } // 

        public Hero(string username, int hp)
        {
            Username = username;
            HP = hp;
            MaxHP = hp;
        }
    }
}
