// this class determines the function of buttons and the value of displays on the user interface
using System.Text.RegularExpressions;

namespace C__MonsterHunter_V2
{
    public partial class Interface : Form
    {
        private GameEngine engine;

        public Interface()
        {
            InitializeComponent();

            engine = new GameEngine();

            // link buttons to their respective methods
            btnStart.Click += BtnStartClick;
            btnQuit.Click += BtnQuitClick;
            btnSword.Click += BtnAttackClick;
            btnArrow.Click += BtnAttackClick;
            btnSpear.Click += BtnAttackClick;

            // the attack buttons are disable before a valid hero name is entered
            SetAttackButtonsEnabled(false);

            // displays top score list
            UpdateScoreboard();
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        // selects a monster image to be displayed acording to the monster's name
        private void ImageLoad()
        {

            // Set the image based on the Monster.Name string
            switch (engine.Selector)
            {
                case "Oswald the Orc":
                    pictureBoxMonster.Image = Properties.Resources.OswaldTheOrcPic;
                    break;
                case "Vampire Victoria":
                    pictureBoxMonster.Image = Properties.Resources.VampireVictoriaPic;
                    break;
                case "Wendy Wendigo":
                    pictureBoxMonster.Image = Properties.Resources.WendyWendigoPic;
                    break;
                case "Rupert Skellington":
                    pictureBoxMonster.Image = Properties.Resources.rupertSkelingtonPic;
                    break;
                default:
                    MessageBox.Show("no image found");
                    break;
            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////

        // Enable/disable attack buttons
        private void SetAttackButtonsEnabled(bool enabled)
        {
            btnSword.Enabled = enabled;
            btnArrow.Enabled = enabled;
            btnSpear.Enabled = enabled;
        }

        // Quits game
        private void BtnQuitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Start new game
        private void BtnStartClick(object sender, EventArgs e)
        {

            string Username = UserName.Text.Trim();

            // hero name allows letters and ""
            Regex nameRule = new Regex(@"^[A-Za-z""]*$");
            if (nameRule.IsMatch(Username) == false)
            {
                MessageBox.Show("Please enter a valid name, no spaces or numbers.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Start/restart the game
            engine.StartGame(Username);

            // Reset variables for each new game
            listLog.Items.Clear();
            lblStatusReport.Text = "Battle started! Choose your attack.";
            lblMonsterName.Text = engine.Monster.Name;
            ImageLoad();
            lblMonsterHealth.Text = engine.Monster.HP.ToString();
            lblHeroName.Text = Username;
            lblHeroHealth.Text = engine.Hero.HP.ToString();

            // Set default HP colors
            UpdateHPColors();

            // Enable attack buttons
            SetAttackButtonsEnabled(true);

            // Display scoreboard
            UpdateScoreboard();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Any attack button clicked
        private void BtnAttackClick(object sender, EventArgs e)
        {
            if (engine == null || engine.Hero == null || engine.Monster == null)
            {
                MessageBox.Show("Please start the game first.", "No Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (engine.IsPlayerDead() || engine.IsEnemyDead())
            {
                MessageBox.Show("The battle has ended. Start a new game.", "Game Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetAttackButtonsEnabled(false);
                return;
            }

            // Determine attack type
            AttackType chosen = AttackType.Sword;
            if (sender == btnSword) chosen = AttackType.Sword;
            else if (sender == btnArrow) chosen = AttackType.Arrow;
            else if (sender == btnSpear) chosen = AttackType.Spear;

            // Execute attack
            string outcome = engine.Attack(chosen);

            // Add outcome to combat log
            string[] lines = outcome.Split('\n');
            for (int i = 0; i < lines.Length; i = i + 1)
            {
                string line = lines[i].Trim();
                if (line.Length > 0) listLog.Items.Add(line);
            }

            // Update Health labels
            lblMonsterHealth.Text = engine.Monster.HP.ToString();
            lblHeroHealth.Text = engine.Hero.HP.ToString();

            // Update Health colors
            UpdateHPColors();
            //////////////////////////////////////////////////////////////////////////////////////////////////
            // Check victory conditions
            if (engine.IsPlayerDead())
            {
                lblStatusReport.Text = "Hero slain! Game Over.";
                SetAttackButtonsEnabled(false);
                UpdateScoreboard();
                MessageBox.Show("Defeat! Try again.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (engine.IsEnemyDead())
            {
                lblStatusReport.Text = "Monster slain! Victory!";
                SetAttackButtonsEnabled(false);
                engine.SaveScoreIfWin();
                UpdateScoreboard();
                MessageBox.Show("Huzzah! Monster slain.", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblStatusReport.Text = "Choose your next attack.";
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Update HP label colors based on current Health
        private void UpdateHPColors()
        {
            if (engine.Hero != null)
            {
                double rangerPercent = ((double)engine.Hero.HP / engine.Hero.MaxHP) * 100;
                if (rangerPercent >= 66)
                    lblHeroHealth.ForeColor = System.Drawing.Color.Black;
                else if (rangerPercent >= 33)
                    lblHeroHealth.ForeColor = System.Drawing.Color.Orange;
                else
                    lblHeroHealth.ForeColor = System.Drawing.Color.Red;
            }

            if (engine.Monster != null)
            {
                double alienPercent = (double)engine.Monster.HP / engine.Monster.MaxHP * 100;
                if (alienPercent >= 66)
                    lblMonsterHealth.ForeColor = System.Drawing.Color.Black;
                else if (alienPercent >= 33)
                    lblMonsterHealth.ForeColor = System.Drawing.Color.Orange;
                else
                    lblMonsterHealth.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Display scoreboard list
        private void UpdateScoreboard()
        {
            engine.LoadScores();
            listScore.Items.Clear();
            for (int i = engine.TopScores.Count - 1; i >= 0; i = i - 1)
            {
                int score = engine.TopScores.Keys[i];
                string name = engine.TopScores.Values[i];
                listScore.Items.Add(name + ": " + score.ToString() + " HP");
            }
        }
    }
}
