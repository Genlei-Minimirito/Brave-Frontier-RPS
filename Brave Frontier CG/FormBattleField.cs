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
        private Label lblEndGame;
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
        SoundPlayer battleOST = new SoundPlayer(@"C:\BSCS 1B\BFCG\Battlefield OST.wav");
        private FormsTimer _endGameTimer;
        /// <summary>
        /// Default constructor: sets up UI and timers.
        /// </summary>
        public FormBattleField()
        {
            InitializeComponent();
            battleOST.Play();
            lblEndGame = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Text = "",
                Visible = false
            };
            toolTipChoice.SetToolTip(btnRock, "SWORD DEFEATS BOW");
            toolTipChoice.SetToolTip(btnPaper, "STAFF DEFEATS SWORD");
            toolTipChoice.SetToolTip(btnSci, "BOW DEFEATS STAFF");
            // Add it to the form’s controls
            this.Controls.Add(lblEndGame);

            // (Optional) position it now or later before showing:
            lblEndGame.Location = new Point(
                (this.ClientSize.Width - lblEndGame.Width) / 2,
                (this.ClientSize.Height - lblEndGame.Height) / 2);
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

            _endGameTimer = new FormsTimer { Interval = 6000 };
            _endGameTimer.Tick += EndGameTimer_Tick;
        }

        private void btnRock_Click(object sender, EventArgs e) => OnPlayerChoice(RpsChoice.Rock);
        private void btnPaper_Click(object sender, EventArgs e) => OnPlayerChoice(RpsChoice.Paper);
        private void btnSci_Click(object sender, EventArgs e) => OnPlayerChoice(RpsChoice.Scissors);

        private void OnPlayerChoice(RpsChoice playerChoice)
        {
            
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
                RpsChoice.Rock => Properties.Resources.SWORD_GAME,
                RpsChoice.Paper => Properties.Resources.STAFF_GAME,
                RpsChoice.Scissors => Properties.Resources.BOW_GAME,
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
            lblPlayerLives.Text = $"Your Lives: {_playerLives}";
            lblBotLives.Text = $"Enemy Lives: {_botLives}";
        }

        private void EndGame()
        {
            // disable the RPS buttons
            btnRock.Enabled = btnPaper.Enabled = btnSci.Enabled = false;
            bool playerWon = _playerLives > 0;
            // determine victory/defeat text
            var title = _playerLives > 0 ? "Victory" : "Defeat";
           
                

            // award between 1–5 gems
            

            // show it in your label
            int gemReward = 0;
            if (playerWon)
            {
                gemReward = _random.Next(1, 6);
                GameState.Gems += gemReward;
            }

            // Build the label text
            if (playerWon)
            {
                // On victory, show the reward
                lblEndGame.TextAlign = ContentAlignment.MiddleCenter;
                lblEndGame.Text = $"{title}\r\nYou earned {gemReward} gem(s)!";

            }
            else
            {
                // On defeat, omit the gem line
                lblEndGame.TextAlign = ContentAlignment.MiddleCenter;
                lblEndGame.Text = $"{title}\r";
            }
            // Center it in the client area
            int x = (this.ClientSize.Width - lblEndGame.Width) / 2;
            int y = (this.ClientSize.Height - lblEndGame.Height) / 2;  // shift 50px down

            lblEndGame.Location = new Point(x, y);

            lblEndGame.Visible = true;
            lblEndGame.BringToFront();

            // start the delay before returning to menu
            _endGameTimer.Start();
        }

        private void EndGameTimer_Tick(object sender, EventArgs e)
        {
            _endGameTimer.Stop();

            // return to menu
            var menu = new FormMainMenu()
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
          
            menu.Show();

            this.Close();
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
                    picAttack.Image = Properties.Resources.VARGAS_ATTACK;
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
                case "Deku\n5☆☆☆☆☆":
                    picIdle.Image = Properties.Resources.DEKU_IDLE;
                    picAttack.Image = Properties.Resources.DEKU_ATTACK;
                    break;
                case "Lasswell\n5☆☆☆☆☆":
                    picIdle.Image = Properties.Resources.LASSWELL_IDLE;
                    picAttack.Image = Properties.Resources.LASSWELL_ATTACK;
                    break;
                case "Miku\n5☆☆☆☆☆":
                    picIdle.Image = Properties.Resources.MIKU_IDLE;
                    picAttack.Image = Properties.Resources.MIKU_ATTACK;
                    break;
                case "Natsu\n5☆☆☆☆☆":
                    picIdle.Image = Properties.Resources.NATSU_IDLE;
                    picAttack.Image = Properties.Resources.NATSU_ATTACK;
                    break;
                case "Iori Yagami\n5☆☆☆☆☆":
                    picIdle.Image = Properties.Resources.IORI_IDLE;
                    picAttack.Image = Properties.Resources.IORI_ATTACK;
                    break;
                case "Kaneki\n5☆☆☆☆☆":
                    picIdle.Image = Properties.Resources.KANEKI_IDLE;
                    picAttack.Image = Properties.Resources.KANEKI_ATTACK;
                    break;
                case "Kaito\n3☆☆☆":
                    picIdle.Image = Properties.Resources.KAITO_IDLE;
                    picAttack.Image = Properties.Resources.KAITO_ATTACK;
                    break;
                case "Kagamine Rin\n3☆☆☆":
                    picIdle.Image = Properties.Resources.RIN_IDLE;
                    picAttack.Image = Properties.Resources.RIN_ATTACK;
                    break;
                case "Kagamine Len\n3☆☆☆":
                    picIdle.Image = Properties.Resources.LEN_IDLE;
                    picAttack.Image = Properties.Resources.LEN_ATTACK;
                    break;
                case "Juzo Suzuya\n3☆☆☆":
                    picIdle.Image = Properties.Resources.JUZO_IDLE;
                    picAttack.Image = Properties.Resources.JUZO_ATTACK;
                    break;
                case "Touka Kirishima\n3☆☆☆":
                    picIdle.Image = Properties.Resources.TOUKA_IDLE;
                    picAttack.Image = Properties.Resources.TOUKA_ATTACK;
                    break;

                // 4★ units
                case "All Might\n4☆☆☆☆":
                    picIdle.Image = Properties.Resources.ALL_MIGHT_IDLE;
                    picAttack.Image = Properties.Resources.ALL_MIGHT_ATTACK;
                    break;
                case "Toki\n4☆☆☆☆":
                    picIdle.Image = Properties.Resources.TOKI_IDLE;
                    picAttack.Image = Properties.Resources.TOKI_ATTACK;
                    break;
                case "Dark Deemo and the Girl\n4☆☆☆☆":
                    picIdle.Image = Properties.Resources.DEEMO_DARK_IDLE;
                    picAttack.Image = Properties.Resources.DEEMO_DARK_ATTACK;
                    break;
                case "Deemo and the Girl\n4☆☆☆☆":
                    picIdle.Image = Properties.Resources.DEEMO_LIGHT_IDLE;
                    picAttack.Image = Properties.Resources.DEEMO_LIGHT_ATTACK;
                    break;
                case "Katsuki Bakugo\n4☆☆☆☆":
                    picIdle.Image = Properties.Resources.BAKUGO_IDLE;
                    picAttack.Image = Properties.Resources.BAKUGO_ATTACK;
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
