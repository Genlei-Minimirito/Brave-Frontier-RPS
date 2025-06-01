using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Brave_Frontier_CG
{
    public partial class FormAnimeCollab : Form
    {
        // This timer drives the 3-second delay between "summon animation" 
        // and showing the FormObtained.
        private System.Windows.Forms.Timer _summonDelayTimer;
        private FormSummonAnim _summonAnimForm;

        public FormAnimeCollab()
        {
            InitializeComponent();
            lblName.Text = Session.UserName;
            lblGems.Text = $"{GameState.Gems}";

            toolTipNavBar.AutoPopDelay = 5000;
            toolTipNavBar.InitialDelay = 500;
            toolTipNavBar.ReshowDelay = 100;
            toolTipNavBar.ShowAlways = true;

            toolTipNavBar.SetToolTip(picHome, "Return to your home base.");
            toolTipNavBar.SetToolTip(picUnit, "View and manage your units.");
            toolTipNavBar.SetToolTip(picTown, "COMING SOON!");
            toolTipNavBar.SetToolTip(picShop, "COMING SOON!");
            toolTipNavBar.SetToolTip(picSummon, "Summon new units (costs gems).");
            toolTipNavBar.SetToolTip(picSocial, "COMING SOON!");

            // Wire up the summon‐button click event:
            picSummonButton.Click += PicSummonButton_Click;

            // Prepare the Timer (but do not start it yet)
            _summonDelayTimer = new System.Windows.Forms.Timer();
            _summonDelayTimer.Interval = 3000;          // 3 seconds
            _summonDelayTimer.Tick += SummonDelayTimer_Tick;
        }

        private void PicSummonButton_Click(object sender, EventArgs e)
        {
            // If the player doesn’t have 5 gems, show a tooltip above the button and return.
            if (GameState.Gems < 5)
            {
                // Show the tooltip for 2 seconds, positioned 0 px right and –30 px above the button:
                toolTipNavBar.Show(
                    "You need 5 gems to summon",
                    picSummonButton,
                    0, -30,
                    2000
                );
                return;
            }

            // Otherwise subtract gems and proceed as before:
            GameState.Gems -= 5;
            lblGems.Text = $"{GameState.Gems}";

           
            this.Hide();
            // 1) Show the summon animation form
            _summonAnimForm = new FormSummonAnim();
            _summonAnimForm.StartPosition = FormStartPosition.CenterParent;
            _summonAnimForm.Show();
            _summonAnimForm.Location = this.Location;

            // 2) Start the 3-second delay timer
            _summonDelayTimer.Start();
        }

        private void SummonDelayTimer_Tick(object sender, EventArgs e)
        {
            // 1) Stop the timer so it doesn't fire again
            _summonDelayTimer.Stop();

            // 2) Close (or hide) the FormSummonAnim
            if (_summonAnimForm != null && !_summonAnimForm.IsDisposed)
            {
                _summonAnimForm.Close();
                _summonAnimForm = null;
            }

            // 3) Perform the “random pull” and open FormObtained
            //    For this example, we'll just call a helper that returns a UnitInfo.
            UnitInfo pulled = DoRandomPull();

            var obtainedForm = new FormObtained(pulled.Name, pulled.Image);
            obtainedForm.StartPosition = FormStartPosition.CenterParent;
            // When the user clicks Continue inside FormObtained, 
            // that form will add to GameState and return us to FormAnimeCollab.
            obtainedForm.Location = this.Location;
            obtainedForm.ShowDialog();
        }

        /// <summary>
        /// Dummy example of “random pull”—you’d put your 3★/4★/5★ logic here.
        /// Returns a new UnitInfo(name, portraitImage).
        /// </summary>
        private UnitInfo DoRandomPull()
        {
            // ***** Replace this example logic with your real rates *****
            //
            // For demonstration, let's say we have three lists of UnitInfo for each rarity:
            //   List<UnitInfo> threeStarUnits;
            //   List<UnitInfo> fourStarUnits;
            //   List<UnitInfo> fiveStarUnits;
            //
            // We'll randomly pick a rarity, then randomly pick from that list.

            Random rand = new Random();

            // Example rarity roll: 1–80 → 3★, 81–95 → 4★, 96–100 → 5★
            int roll = rand.Next(1, 101);

            if (roll <= 80)
            {
                // 3★
                return GetRandomFromList(Library.ThreeStarUnits, rand);
            }
            else if (roll <= 95)
            {
                // 4★
                return GetRandomFromList(Library.FourStarUnits, rand);
            }
            else
            {
                // 5★
                return GetRandomFromList(Library.FiveStarUnits, rand);
            }
        }

        /// <summary>
        /// Picks a random UnitInfo from a list; fallback to a default if empty.
        /// </summary>
        private UnitInfo GetRandomFromList(List<UnitInfo> pool, Random rand)
        {
            if (pool == null || pool.Count == 0)
            {
                // Fallback: return a placeholder UnitInfo
                return new UnitInfo("Unknown", Properties.Resources.ATRO);
            }
            return pool[rand.Next(pool.Count)];
        }


        private void picHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formhome = new FormMainMenu();
            formhome.StartPosition = FormStartPosition.Manual;
            formhome.Location = this.Location;
            formhome.ShowDialog();
        }

        private void picUnit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formChar = new FormCharacters();
            formChar.StartPosition = FormStartPosition.Manual;
            formChar.Location = this.Location;
            formChar.ShowDialog();
        }

        private void picTown_Click(object sender, EventArgs e)
        {

        }

        private void picShop_Click(object sender, EventArgs e)
        {

        }

        private void picSummon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormSummon();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }

        private void picArrowRight_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormSummon();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }

        private void pictArrowLeft_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormSummon();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }

        private void picHome_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form formhome = new FormMainMenu();
            formhome.StartPosition = FormStartPosition.Manual;
            formhome.Location = this.Location;
            formhome.ShowDialog();
        }

        private void picSummon_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormSummon();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }

        private void picUnit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form formChar = new FormCharacters();
            formChar.StartPosition = FormStartPosition.Manual;
            formChar.Location = this.Location;
            formChar.ShowDialog();
        }

        private void picSummonButton_Click(object sender, EventArgs e)
        {

        }
    }
}
