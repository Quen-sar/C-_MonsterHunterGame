// this class is the basic logic of the game, determining enemy types, attack and health values, and victory conditions
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__MonsterHunter_V2
{
    public class GameEngine
    {
        private Random rnd = new Random();

        // the Hero and current monster
        public Hero Hero { get; private set; }
        public Monster Monster { get; private set; }

        // Templates for monsters, health is reset for each new game
        public List<Monster> EnemyTemplates { get; private set; }

        // Top score is determined by the hero's remaining health after victory
        public SortedList<int, string> TopScores { get; private set; }

        private string ScoreFile = "scoreboard.txt";

        // monster name is used to choose an image in Form1.cs switch statement
        public string Selector => Monster?.Name ?? string.Empty;
        ///////////////////////////////////////////////////////////////////////////////////////////
        
        public GameEngine()
        {
            // monsters have a unique health points to damage ratio
            EnemyTemplates = new List<Monster>();
            EnemyTemplates.Add(new Monster("Oswald the Orc", 150, 5, 16));
            EnemyTemplates.Add(new Monster("Vampire Victoria", 100, 10, 26));
            EnemyTemplates.Add(new Monster("Wendy Wendigo", 100, 10, 31));
            EnemyTemplates.Add(new Monster("Rupert Skellington", 80, 5, 16));

            TopScores = new SortedList<int, string>();
        }

        // Start a new game
        public void StartGame(string Username)
        {
            // Hero starts at 100 heath
            Hero = new Hero(Username, 100);

            // monster type is randomly chosen from the list
            int index = rnd.Next(EnemyTemplates.Count);
            Monster template = EnemyTemplates[index];
            Monster = new Monster(template.Name, template.HP, template.MinAttack, template.MaxAttack);
        }

        // hero dies with less than 1 health
        public bool IsPlayerDead()
        {
            return Hero != null && Hero.HP <= 0;
        }
        // monster dies with less than 1 health
        public bool IsEnemyDead()
        {
            return Monster != null && Monster.HP <= 0;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        // base attack damage is random and then multiplied for a critical strike
        public string Attack(AttackType type)
        {
            string result = "";
            bool hit = false;

            // method for determining prime numbers
            bool isPrime(int number)
            {
                if (number == 1) return false;
                if (number == 2) return true;

                var limit = Math.Ceiling(Math.Sqrt(number));

                for (int i = 2; i <= limit; ++i)
                    if (number % i == 0)
                        return false;
                return true;

            }
            ///////////////////////////////////////////////////////////////////////////////////////////
            // hit conditions
            if (type == AttackType.Sword)
            {
                // default attack, 100% accuracy
                hit = true; 
            }
            else if (type == AttackType.Arrow)
            {
                // Hits if monster Health is a prime number
                hit = isPrime(Monster.HP);
            }
            else if (type == AttackType.Spear)
            {
                // Hits if monster health a multiple by 5
                hit = (Monster.HP % 5 == 0);
            }
            ///////////////////////////////////////////////////////////////////////////////////////////
            // determines critical hit multiplier for monster types
            double critHit;

            // wendigo weak to sword
            if (hit && type == AttackType.Sword && Monster.Name == "Wendy Wendigo")
            {
                critHit = 1.5; // 50% increase
            }
            // orc weak to arrows
            else if (hit && type == AttackType.Arrow && Monster.Name == "Oswald the Orc")
            {
                critHit = 2; // 100% increase
            }
            // vampire weak to spear
            else if (hit && type == AttackType.Spear && Monster.Name == "Vampire Victoria")
            {
                critHit = 1.5; // 50% increase
            }
            else 
            { 
                critHit = 1; // no critical hit by default
            }
            ///////////////////////////////////////////////////////////////////////////////////////////
            if (hit)
            {
                int damage = rnd.Next(5, 21); // default hero attack base damage
                // total damage = base damage X critical multiplier(default 1)
                damage = (int)Convert.ToDouble(damage);
                double totDamage = damage * critHit;
                int TotDamage = (int)Math.Round(totDamage, MidpointRounding.AwayFromZero);
                //
                Monster.HP = Monster.HP - TotDamage;
                if (Monster.HP < 0)
                {
                    Monster.HP = 0;
                }
                result = result + $"{type} hit Monster for {TotDamage} damage.\n";
            }
            else
            {
                result = result + $"{type} missed!\n";
            }

            // Monster counterattack strength is unique to each monster type
            // Monsters do not score critical hits
            if (Monster.HP > 0)
            {
                int counter = rnd.Next((Monster.MinAttack), (Monster.MaxAttack));
                Hero.HP = Hero.HP - counter;
                if (Hero.HP < 0)
                {
                    Hero.HP = 0;
                }
                result = result + $"Monster countered Hero for {counter} damage.\n";
            }

            return result;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        // Top score is determined by hero health remaining after victory
        // no duplicate scores are saved, no minimum score required
        public void SaveScoreIfWin()
        {
            if (Hero != null && Hero.HP > 0 && Monster != null && Monster.HP == 0)
            {
                try
                {
                    string line = Hero.Username + "," + Hero.HP.ToString();
                    File.AppendAllText(ScoreFile, line + Environment.NewLine);

                    // Refreshes list after saving
                    LoadScores();
                }
                catch (Exception e)
                {
                    DateTime localDateTime = DateTime.Now;
                    string errMessage = e.Message;
                    File.WriteAllText("errorlog.txt", (errMessage + "exception occured: " + localDateTime + "\n"));
                }
            }
        }

        // display the scores in file in decending order
        public void LoadScores()
        {
            TopScores.Clear();

            if (File.Exists(ScoreFile) == false)
            {
                return;// file will be created if it does not exist
            }

            string[] lines = File.ReadAllLines(ScoreFile);

            for (int i = 0; i < lines.Length; i = i + 1)
            {
                string line = lines[i];
                string[] parts = line.Split(',');

                if (parts.Length == 2)
                {
                    int scoreValue = 0;
                    bool ok = int.TryParse(parts[1], out scoreValue);
                    if (ok)
                    {
                        while (TopScores.ContainsKey(scoreValue))
                        {
                            scoreValue = scoreValue - 1;
                        }

                        TopScores.Add(scoreValue, parts[0]);
                    }
                }
            }
        }
    }
}
