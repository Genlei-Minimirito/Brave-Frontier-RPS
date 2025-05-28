using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

// Alias so “Timer” always means the WinForms timer
using FormsTimer = System.Windows.Forms.Timer;

namespace Brave_Frontier_CG
{
    public partial class FormBattleField : Form
    {
        private FormsTimer _playerAttackTimer;
        private FormsTimer _botAttackTimer;
        private Random _random;

        // Lives for player and bot
        private int _playerLives = 3;
        private int _botLives = 3;

        // Starter and bot character names
        private readonly string _starterName;
        private string _botName;

        // Enum for RPS choices
        private enum RpsChoice { Rock, Paper, Scissors }

        /// <summary>
        /// Constructor accepting the starter card image and name.
        /// </summary>
        public FormBattleField(Image starterImage, string starterName)
            : this() // Call default ctor
        {
            _starterName = starterName;

            // Show starter portrait
            picCardHolder.Image = starterImage;
            picCardHolder.SizeMode = PictureBoxSizeMode.StretchImage;

            // Load player animations
            SetPlayerAnimations(_starterName);

            // Randomly pick a bot character (excluding player)
            var all = new[] { "Vargas", "Selena", "Lance", "Eze", "Magress", "Atro" };
            var choices = all.Where(n => n != _starterName).ToArray();
            _botName = choices[_random.Next(choices.Length)];

            // Load bot animations
            SetBotAnimations(_botName);
        }
        SoundPlayer touch = new SoundPlayer(@"C:\BSCS 1B\BFCG\touch sfx.wav");
        /// <summary>
        /// Default constructor: sets up UI and timers.
        /// </summary>
        public FormBattleField()
        {
            InitializeComponent();

            // Initialize random
            _random = new Random();

            // Configure attack timers
            _playerAttackTimer = new FormsTimer { Interval = 2650 };
            _playerAttackTimer.Tick += PlayerAttackTimer_Tick;
            _botAttackTimer = new FormsTimer { Interval = 2650 };
            _botAttackTimer.Tick += BotAttackTimer_Tick;

            // Initial UI state for animations
            picIdle.Visible = true;
            picAttack.Visible = false;
            picBotIdle.Visible = true;
            picBotAttack.Visible = false;

            // Prepare choice icons
            picPlayerChoice.SizeMode = PictureBoxSizeMode.StretchImage;
            picEnemyChoice.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayerChoice.Visible = false;
            picEnemyChoice.Visible = false;

            UpdateLivesDisplay();
            lblResult.Text = string.Empty;
        }

        private void btnRock_Click(object sender, EventArgs e) => OnPlayerChoice(RpsChoice.Rock);
        private void btnPaper_Click(object sender, EventArgs e) => OnPlayerChoice(RpsChoice.Paper);
        private void btnSci_Click(object sender, EventArgs e) => OnPlayerChoice(RpsChoice.Scissors);

        private void OnPlayerChoice(RpsChoice playerChoice)
        {
            touch.Play();
            // Disable input
            btnRock.Enabled = btnPaper.Enabled = btnSci.Enabled = false;

            // Show choices
            picPlayerChoice.Image = GetResourceImage(playerChoice);
            picPlayerChoice.Visible = true;
            var botChoice = (RpsChoice)_random.Next(3);
            picEnemyChoice.Image = GetResourceImage(botChoice);
            picEnemyChoice.Visible = true;

            // Determine outcome
            bool isDraw = playerChoice == botChoice;
            bool playerWins = (playerChoice == RpsChoice.Rock && botChoice == RpsChoice.Scissors)
                              || (playerChoice == RpsChoice.Paper && botChoice == RpsChoice.Rock)
                              || (playerChoice == RpsChoice.Scissors && botChoice == RpsChoice.Paper);

            if (isDraw)
            {
                lblResult.Text = "Draw!";
                // No attack animation
                btnRock.Enabled = btnPaper.Enabled = btnSci.Enabled = true;
            }
            else if (playerWins)
            {
                lblResult.Text = "You Win!";
                _botLives--;

                // Player attack animation
                picIdle.Visible = false;
                picAttack.Visible = true;
                _playerAttackTimer.Start();
            }
            else
            {
                lblResult.Text = "You Lose!";
                _playerLives--;

                // Bot attack animation
                picBotIdle.Visible = false;
                picBotAttack.Visible = true;
                _botAttackTimer.Start();
            }

            UpdateLivesDisplay();

            // Check for end of game
            if (_playerLives <= 0 || _botLives <= 0)
                EndGame();
        }

        private Image GetResourceImage(RpsChoice choice)
        {
            return choice switch
            {
                RpsChoice.Rock => Properties.Resources.ROCK,
                RpsChoice.Paper => Properties.Resources.PAPER,
                RpsChoice.Scissors => Properties.Resources.SCISSORS,
                _ => null
            };
        }

        private void PlayerAttackTimer_Tick(object sender, EventArgs e)
        {

            _playerAttackTimer.Stop();
            picAttack.Visible = false;
            picIdle.Visible = true;

            // Re-enable input after animation
            btnRock.Enabled = btnPaper.Enabled = btnSci.Enabled = true;
        }

        private void BotAttackTimer_Tick(object sender, EventArgs e)
        {
            _botAttackTimer.Stop();
            picBotAttack.Visible = false;
            picBotIdle.Visible = true;

            // Re-enable input after animation
            btnRock.Enabled = btnPaper.Enabled = btnSci.Enabled = true;
        }

        private void UpdateLivesDisplay()
        {
            lblPlayerLives.Text = $"Player Lives: {_playerLives}";
            lblBotLives.Text = $"Bot Lives: {_botLives}";
        }

        private void EndGame()
        {
            btnRock.Enabled = btnPaper.Enabled = btnSci.Enabled = false;

            var title = _playerLives > 0 ? "Victory" : "Defeat";
            var message = _playerLives > 0 ? "You defeated the bot!" : "You have no lives left!";

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hide();
            new FormMainMenu().Show();
            Close();
        }

        /// <summary>
        /// Load player idle/attack animations based on character name.
        /// </summary>
        private void SetPlayerAnimations(string name)
        {
            switch (name)
            {
                case "Vargas":
                    picIdle.Image = Properties.Resources.VARGAS_IDLE_ANIMATION;
                    picAttack.Image = Properties.Resources.VARGAS_ATTACK_ANIMATION;
                    break;
                case "Selena":
                    picIdle.Image = Properties.Resources.SELENA_IDLE_ANIMATION;
                    picAttack.Image = Properties.Resources.SELENA_ATTACK_ANIMATION;
                    break;
                case "Lance":
                    picIdle.Image = Properties.Resources.LANCE_IDLE_ANIMATION;
                    picAttack.Image = Properties.Resources.LANCE_ATTACK_ANIMATION;
                    break;
                case "Eze":
                    picIdle.Image = Properties.Resources.EZE_IDLE_ANIMATION;
                    picAttack.Image = Properties.Resources.EZE_ATTACK_ANIMATION;
                    break;
                case "Magress":
                    picIdle.Image = Properties.Resources.MAGRESS_IDLE;
                    picAttack.Image = Properties.Resources.MAGRESS_ATTACK;
                    break;
                case "Atro":
                    picIdle.Image = Properties.Resources.ATRO_IDLE;

                    break;
                default:
                    picIdle.Image = Properties.Resources.EZE_IDLE_ANIMATION;
                    picAttack.Image = Properties.Resources.EZE_ATTACK_ANIMATION;
                    break;
            }

            picIdle.SizeMode = PictureBoxSizeMode.StretchImage;
            picAttack.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Load bot idle/attack animations based on bot character name.
        /// </summary>
        private void SetBotAnimations(string name)
        {
            switch (name)
            {
                case "Vargas":
                    picBotIdle.Image = Properties.Resources.MONSTER1;
                    picBotAttack.Image = Properties.Resources.MONSTER1_ATTACK;
                    break;
                case "Selena":
                    picBotIdle.Image = Properties.Resources.MONSTER2;
                    picBotAttack.Image = Properties.Resources.MONSTER2_ATTACK;
                    break;
                case "Lance":
                    picBotIdle.Image = Properties.Resources.MONSTER3;
                    picBotAttack.Image = Properties.Resources.THUNDER_ATTACK;
                    break;
                case "Eze":
                    picBotIdle.Image = Properties.Resources.MONSTER4;
                    picBotAttack.Image = Properties.Resources.MONSTER4_ATTACK;
                    break;
                case "Magress":
                    picBotIdle.Image = Properties.Resources.MONSTER5;
                    picBotAttack.Image = Properties.Resources.MONSTER5_ATTACK;
                    break;
                case "Atro":
                    picBotIdle.Image = Properties.Resources.MONSTER6;
                    picBotAttack.Image = Properties.Resources.MONSTER6_ATTACK;
                    break;
                default:
                    picBotIdle.Image = Properties.Resources.MONSTER3;
                    picBotAttack.Image = Properties.Resources.THUNDER_ATTACK;
                    break;
            }

            picBotIdle.SizeMode = PictureBoxSizeMode.StretchImage;
            picBotAttack.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FormBattleField_Load(object sender, EventArgs e)
        {

        }
    }
}
