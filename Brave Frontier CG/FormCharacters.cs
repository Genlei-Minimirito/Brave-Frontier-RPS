using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Brave_Frontier_CG
{
    public partial class FormCharacters : Form
    {
        // List of all 25 PictureBoxes in the order you want them to fill
        private readonly List<PictureBox> _slots;

        public FormCharacters()
        {
            InitializeComponent();

            lblName.Text = Session.UserName;
            lblGems.Text = $"{GameState.Gems}";
            toolTipNavBar.AutoPopDelay = 5000;   // stays visible for 5 seconds
            toolTipNavBar.InitialDelay = 500;    // appears after half-second hover
            toolTipNavBar.ReshowDelay = 100;    // time between successive tooltips
            toolTipNavBar.ShowAlways = true;   // even if form isn’t active

            // Attach tooltip texts to each PictureBox

            toolTipNavBar.SetToolTip(picHome, "Return to your home base.");
            toolTipNavBar.SetToolTip(picUnit, "View and manage your units.");
            toolTipNavBar.SetToolTip(picTown, "COMING SOON!");
            toolTipNavBar.SetToolTip(picShop, "COMING SOON!");
            toolTipNavBar.SetToolTip(picSummon, "Summon new units (costs gems).");
            toolTipNavBar.SetToolTip(picSocial, "COMING SOON!");

            // Build the list of all 25 PictureBoxes (adjust names as per your Designer)
            _slots = new List<PictureBox>
            {
                pictureBox1,  pictureBox2,  pictureBox4,  pictureBox3,  pictureBox5,
               pictureBox6, pictureBox7, pictureBox8, pictureBox9,
            };

            // Initialize all slots to be empty
            foreach (var box in _slots)
            {
                box.Image = null;
                box.Tag   = null;
                box.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void FormCharacters_Load(object sender, EventArgs e)
        {
            // Populate whenever the form is shown/loaded
            RefreshCollectionDisplay();
        }

        /// <summary>
        /// Fills the first N slots (N = number of collected starters) 
        /// with images from GameState.CollectedStarters.
        /// </summary>
        public void RefreshCollectionDisplay()
        {
            // 1) Clear all slots
            foreach (var box in _slots)
            {
                box.Image = null;
                box.Tag   = null;
            }

            // 2) Iterate over each collected UnitInfo
            int index = 0;
            foreach (var unit in GameState.CollectedStarters)
            {
                if (index >= _slots.Count) 
                    break;  // do not exceed 25 slots

                var box = _slots[index];
                box.Image = unit.Image;  // assign the portrait
                box.Tag   = unit.Name;   // store the unit’s name if needed later
                index++;
            }
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

        private void picSummon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormAnimeCollab();
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

        private void picUnit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form formChar = new FormCharacters();
            formChar.StartPosition = FormStartPosition.Manual;
            formChar.Location = this.Location;
            formChar.ShowDialog();
        }

        private void picTown_Click_1(object sender, EventArgs e)
        {

        }

        private void picSummon_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormAnimeCollab();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }
    }
}
