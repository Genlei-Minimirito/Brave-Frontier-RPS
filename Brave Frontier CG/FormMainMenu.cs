using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Media;

namespace Brave_Frontier_CG
{
    public partial class FormMainMenu : Form
    {
        SoundPlayer MainMenuOST = new SoundPlayer(@"C:\BSCS 1B\BFCG\Summoner BF OST.wav");
        public FormMainMenu()
        {   

            InitializeComponent();
            MainMenuOST.PlayLooping();
            lblName.Text = Session.UserName;
            lblGems.Text = $"{GameState.Gems}";
            picQuest.SizeMode = PictureBoxSizeMode.StretchImage;

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
        }

       
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
          
        }

        private void btnQuest_Click(object sender, EventArgs e)
        {

        }

        private void picQuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form battlefield = new FormSelect();
            battlefield.StartPosition = FormStartPosition.CenterParent;
            battlefield.Location = this.Location;
            battlefield.ShowDialog();


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
            Form formsumm = new FormAnimeCollab();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }

        private void picSocial_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblGems_Click(object sender, EventArgs e)
        {

        }
    }
}
