//this class initialises the 4 monster types, with their stats and traits
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MonsterHunter_V2
{
    public class Monster : IEnemy
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; private set; }
        public int MinAttack { get; set; } // minimum for random damage range
        public int MaxAttack { get; set; } // maximum for random damage range

        public Monster(string name, int hp, int minAtt, int maxAtt)
        {
            Name = name;
            HP = hp;
            MaxHP = hp;
            MinAttack = minAtt;
            MaxAttack = maxAtt;
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    // orc
    // high health due to his size, same attack as hero
    // weak to arrows due to being a large target
    public class OswaldTheOrc : IEnemy
    {
        private string name;
        private int hp;
        private int minAtt;
        private int maxAtt;

        public OswaldTheOrc()
        {
            Name = "Oswald the Orc";
            HP = 120;
            MinAttack = 5;
            MaxAttack = 16;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public int MinAttack
        {
            get { return minAtt; }
            set { minAtt = value; }
        }
        public int MaxAttack
        {
            get { return maxAtt; }
            set { maxAtt = value; }
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    // vampire
    // same health as hero but higher attack
    // weak to spear due to the wooden shaft acting as a stake
    public class VampireVictoria : IEnemy
    {
        private string name;
        private int hp;
        private int minAtt;
        private int maxAtt;

        public VampireVictoria()
        {
            Name = "Vampire Victoria";
            HP = 100;
            MinAttack = 10;
            MaxAttack = 21;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public int MinAttack
        {
            get { return minAtt; }
            set { minAtt = value; }
        }
        public int MaxAttack
        {
            get { return maxAtt; }
            set { maxAtt = value; }
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    // wendigo
    // same health as hero, very high attack
    // weak to basic sword slash but compensates with savage counter attack
    public class WendyWendigo : IEnemy
    {
        private string name;
        private int hp;
        private int minAtt;
        private int maxAtt;

        public WendyWendigo()
        {
            Name = "Wendy Wendigo";
            HP = 100;
            MinAttack = 10;
            MaxAttack = 26;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public int MinAttack
        {
            get { return minAtt; }
            set { minAtt = value; }
        }
        public int MaxAttack
        {
            get { return maxAtt; }
            set { maxAtt = value; }
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    // skeleton
    // lower health than hero with same attack
    // takes no bonus damage but is by far the weakest overall
    public class RupertSkelington : IEnemy
    {
        private string name;
        private int hp;
        private int minAtt;
        private int maxAtt;

        public RupertSkelington()
        {
            Name = "Rupert Skellington";
            HP = 80;
            MinAttack = 5;
            MaxAttack = 16;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public int MinAttack
        {
            get { return minAtt; }
            set { minAtt = value; }
        }
        public int MaxAttack
        {
            get { return maxAtt; }
            set { maxAtt = value; }
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
}
